using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Başarıyla Eklendi!";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz!";
        public static string ProductListed = "Ürünler Listelendi!";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 10 Ürün Olabilir!";
        public static string ProductUpdated = "Ürün Başarıyla Güncellendi!";
        public static string ProductNameAlreadyExists = "Bu İsimde Zaten Başka Bir Ürün Var!";
        
        public static string CategoryLimitExceeded = "Kategori Limiti Aşıldığı İçin Yeni Ürün Eklenemiyor!";

        public static string UserNotFound = "Kullanıcı Bulunamadı!";
        public static string PasswordError = "Parola Hatalı!";
        public static string SuccessfulLogin = "Sisteme Giriş Başarılı!";
        public static string UserAlreadyExists = "Bu Kullanıcı Zaten Mevcut!";
        public static string UserRegistered = "Kullanıcı Başarıyla Kaydedildi!";
        public static string AccessTokenCreated = "Access Token Başarıyla Oluşturuldu!";

        public static string AuthorizationDenied = "Yetkiniz Yok!";
        public static string MaintenanceTime = "Sistem Şu An Bakımda!";
    }
}
