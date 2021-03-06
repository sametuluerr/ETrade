﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Error = "Bir hata oluştu.";
        public static string MustBeFilled = "Zorunlu alan *";

        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string UserUpdatedSuccessfully = "Bilgileriniz başarıyla güncellendi.";

        public static string InvalidEmail = "Geçerli bir e-posta adresi giriniz *";
        public static string PasswordError = "Şifre Hatalı!";
        public static string PasswordConfirmError = "Şifreler uyuşmuyor, lütfen tekrar deneyiniz.";
        public static string SamePassword = "Yeni şifreniz eskisi ile aynı olamaz.";
        public static string OldPasswordIncorrect =
            "Girmiş olduğunuz şifre, kayıtlarımızdaki şifre ile eşleşmiyor. Lütfen eski şifrenizi doğru girdiğinizden emin olunuz.";
        public static string PasswordChanged = "Şifreniz başarılı bir şekilde değiştirildi.";
        public static string IncorrectEmailOrPassword = "E-posta adresi veya şifre yanlış.";

        public static string ErrorWhileAddingEntity = "Veri tabanına eklerken bir hata oluştu.";
        public static string ErrorWhileUpdatingEntity = "Veri tabanında güncelleme yaparken bir hata oluştu.";
        public static string ErrorWhileGettingEntity = "Veri tabanından veri alırken bir hata oluştu";
        public static string ErrorWhileDeletingEntity = "Veri tabanından silerken bir hata oluştu.";

        public static string ThereIsntSubCategory = "Kategorinin alt kategorisi yok!";

        public static string CategoryCantDeleted =
            "Silmeye çalıştığınız kategorinin, alt kategorleri bulunduğu için işleminiz gerçekleştirilmedi. Bu kategoriyi silmek istiyorsanız lütfen ilk önce alt kategorilerini siliniz.";

        public static string BrandCantDeleted =
            "Silmeye çalıştığınız markaya ait ürünler olduğu için işleminiz gerçekleştirilmedi. Bu markayı silmek istiyorsanız lütfen ilk önce ürünlerini siliniz.";


        public static string Max50Characters = "En fazla 50 karakter girebilirsiniz.";
        public static string Max30Characters = "En fazla 30 karakter girebilirsiniz.";
        public static string Max15Characters = "En fazla 15 karakter girebilirsiniz.";
        public static string PhoneError = "Telefon numaranızı, 10 karakter olacak şekilde başında 0 olmadan giriniz.";
        public static string OnlyLetters = "Sadece harf girebilirsiniz";
        public static string TcError = "Geçersiz bir TC Kimlik Numarası girdiniz.";
        public static string ManagerAddedSuccessfully = "Yönetici başarıyla eklendi. E-posta adresi ve şifresini kullanarak giriş yapabilir.";
        public static string WorkerAddedSuccessfully = "Çalışan başarıyla eklendi. E-posta adresi ve şifresini kullanarak giriş yapabilir.";

        public static string PhotoUploaded = "Fotoğraf başarıyla yüklendi.";
        public static string ProductAddedSuccessfully = "Ürün başarıyla eklendi.";
        public static string ThereIsntShippingDetails = "Sipariş bilgileri bulunamadı.";
        public static string StockInsufficient = "Sepetinizdeki bazı ürünlerin stoğu yetersiz olduğu için ürünlerin sayısı değişiklik gösterebilir.";
        public static string ThereIsNoOrder = "Sipariş bilgisi bulunamadı.";

        public static string ProductBought = "Ürün başarıyla satın alındı.";
        public static string ProductEditedSuccesfully = "Ürün başarıyla güncellendi.";
        public static string ShippingDetailEditedSuccessfully = "Teslimat bilgisi başarıyla güncellendi.";
        public static string CategoryAdded = "Kategori başarıyla eklendi.";
        public static string CategoryDeleted = "Kategori başarıyla silindi.";
        public static string ProductPhoto = "Lütfen ürünün fotoğrafını yükleyiniz.";
        public static string ShippingDetailInfo = "Tüm alanları doğru girdiğinizden emin olun.";
        public static string ProductCantEdited = "Tüm alanları doğru girdiğinizden emin olun.";
        public static string BrandAdded = "Marka başarıyla eklendi.";
        public static string BrandDeleted = "Marka başarıyla silindi.";
        public static string Delivered = " sipariş numaralı ürün teslim edildi.";
        public static string ManagerUpdated = "Yönetici başarıyla güncellendi.";
        public static string WorkerUpdated = "Çalışan başarıyla güncellendi.";
    }
}
