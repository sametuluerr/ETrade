﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Dtos
{
    public class EditWorkerDto : IDto
    {
        public int WorkerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long IdentityNo { get; set; }
        public byte CityId { get; set; }
        public short DistrictId { get; set; }
        public string Street { get; set; }
        public string AddressNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public byte GenderId { get; set; }
    }
}

