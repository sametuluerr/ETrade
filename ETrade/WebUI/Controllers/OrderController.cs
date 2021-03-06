﻿using Business.Abstract;
using Business.Constants;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebUI.Models;

namespace WebUI.Controllers
{
    
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IUserService _userService;
        private IProductService _productService;


        public OrderController(IOrderService orderService, IUserService userService, IProductService productService)
        {
            _orderService = orderService;
            _userService = userService;
            _productService = productService;
        }

        [Authorize(Roles = "Customer")]
        [HttpGet]
        public IActionResult GetByEmail(string email)
        {
            var model = new OrderListViewModel();

            var result = _userService.GetByMail(email);

            if (!result.Success)
            {
                return RedirectToAction("InternalError", "Error", new { errorMessage = result.Message });
            }

            var result2 = _orderService.GetOrders(result.Data.Id);

            if (!result2.Success)
            {
                TempData.Add(TempDataTypes.ThereIsNoOrder, Messages.ThereIsNoOrder);
                return View(model);
            }

            model.Orders = result2.Data;

            return View(model);

        }
        [Authorize(Roles = "Customer")]
        public IActionResult OrderDetails(int orderId)
        {
            var result = _orderService.GetOrderDetails(orderId);
            if (!result.Success)
            {
                return RedirectToAction("InternalError", "Error", new { errorMessage = result.Message });
            }

            var model = new OrderDetailsListViewModel
            {
                OrderId = orderId,
                OrderDetails = new List<OrderDetailDto>()
            };

            foreach (var orderDetail in result.Data)
            {
                var product = _productService.GetById(orderDetail.ProductId);
                if (!product.Success)
                {
                    return RedirectToAction("InternalError", "Error", new { errorMessage = product.Message });
                }
                model.OrderDetails.Add(new OrderDetailDto
                {
                    UnitPrice = orderDetail.UnitPrice,
                    ProductId = orderDetail.ProductId,
                    ProductName = product.Data.Product.ProductName,
                    Quantity = orderDetail.Quantity
                });
            }
            return View(model);
        }

        [Authorize(Roles = "Manager,Worker")]
        public IActionResult Index(bool ship = false)
        {
            var result = _orderService.GetAll(ship);
            if (!result.Success)
            {
                return RedirectToAction("InternalError", "Error", new { errorMessage = result.Message });
            }

            var model = new OrderIndexViewModel
            {
                Orders = result.Data,
                Control = ship
            };

            return View(model);
        }

        [Authorize(Roles = "Manager,Worker")]
        public IActionResult Deliver(int orderId)
        {
            var result = _orderService.Deliver(orderId);
            if (!result.Success)
            {
                return RedirectToAction("InternalError", "Error", new { errorMessage = result.Message });
            }
            TempData.Add(TempDataTypes.OrderDelivered,orderId + Messages.Delivered);
            return RedirectToAction("Index", "Order");
        }
    }
}
