using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //public'ler buyuk harfle yazilir!!! private field olsaydi productAdded yazilirdi.

        //Common magic string
        public static string MaintenanceTime = "Sistem bakimda";

        //Car magic string
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarsUpdated = "Arabalar güncellendi";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarNameInvalid = "Araba ismi gecersiz";


        //User magic string
        public static string UserAdded = "Kullanici eklendi";
        public static string UserDeleted = "Kullanici silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UsersListed = "Kullanicilar listelendi";
        public static string EmailsListed = "Emailler listelendi";
        public static string FirstNameInvalid = "Kullanici ismi gecersiz";
        public static string LastNameInvalid = "Kullanici soyismi gecersiz";

        //Customer magic string
        public static string CustomerAdded = "Musteri eklendi";
        public static string CustomerDeleted = "Musteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Musteri listelendi";
        public static string CompanyNamesListed = "Sirket isimleri listelendi";
        public static string CompanyNameInvalid = "Sirket ismi gecersiz";

        //Rental magic string
        public static string RentalAdded = "Kiralama yapildi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string RentalInvalid = "Kiralama basarisiz";
        public static string RentalListed = "Kiralamalar listelendi";
        public static string RentDatesListed = "Kiralama tarihleri listelendi";
        public static string ReturnDatesListed = "Iade tarihleri listelendi";

        //Color magic string
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorsListed = "Renkler listelendi";
        public static string ColorNameInvalid = "Renk ismi gecersiz";

        //Brand magic string
        public static string BrandAdded = "Brand eklendi";
        public static string BrandDeleted = "Brand silindi";
        public static string BrandUpdated = "Brand güncellendi";
        public static string BrandsListed = "Brand'ler listelendi";
        public static string BrandNameInvalid = "Brand ismi gecersiz";


        //Model magic string
        public static string ModelAdded = "Model eklendi";
        public static string ModelDeleted = "Model silindi";
        public static string ModelUpdated = "Model güncellendi";
        public static string ModelsListed = "Model'ler listelendi";
        public static string ModelYearInvalid = "Model ismi gecersiz";

    }
}
