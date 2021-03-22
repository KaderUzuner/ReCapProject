using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {

        public static string SuccessAdd = "Ekleme başarılı";
        public static string ErrorAdd = "Ekleme başarısız";
        public static string SuccessDelete = "Silme başarılı";
        public static string ErrorDelete = "Silme başarısız";
        public static string SuccessUpdate = "Güncelleme başarılı";
        public static string ErrorUpdate = "Güncelleme başarısız";
        public static string SuccessListed = "Listeleme başarılı";
        public static string ErrorListed = "Listeleme başarısız";
        public static string BrandNameInvalid = "Marka adı geçersiz. En az 2 karakterli olmalı";
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir.";
        public static string RentalAdded = "Kiralama işlemi başarılı.";
        public static string RentalUpdatedReturnDateError = "Araç teslim alınmış";
        public static string RentalUpdatedReturnDate = "Araç Teslim Alındı.";
        public static string RentalListed = "Kiralama listelendi";
        public static string CarUndelivered = "Araba henüz teslim edilmeemiş";
        public static string ImageLimitExpiredForCar = "Bir arabaya maximum 5 fotoğraf eklenebilir";
        public static string InvalidImageExtension = "Geçersiz dosya uzantısı, fotoğraf için kabul edilen uzantılar";
        public static string CarImageMustBeExists = "Böyle bir resim bulunamadı";
        public static string ValidImageFileTypes = "Geçerli görüntü dosyası türüdür.";
        public static string CarHaveNoImage = "Arabaya ait bi resim yok";
        public static string AuthorizationDenied = "Yetkilendirme Reddedildi";
        //public static string CarAdded = "Araba eklendi";
        //public static string CarDeleted = "Araba silindi";
        //public static string CarUpdated = "Araba güncellendi";

        //public static string BrandAdded = "Marka eklendi";
        //public static string BrandDeleted = "Marka silindi";
        //public static string BrandUpdated = "Marka güncellendi";
        //public static string BrandNameInValid = "Marka ismi geçersiz";

        //public static string ColorAdded = "Renk eklendi";
        //public static string ColorDeleted = "Renk silindi";
        //public static string ColorUpdated = "Renk güncellendi";
    }
}

