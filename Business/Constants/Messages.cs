﻿using System;
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
        public static string CarsListed = "Arabalar listelendi";
        public static string CarNameInvalid = "Araba ismi gecersiz";


        //User magic string
        public static string UserAdded = "Kullanici eklendi";
        public static string UserDeleted = "Kullanici silindi";
        public static string UsersListed = "Kullanicilar listelendi";
        public static string EmailsListed = "Emailler listelendi";
        public static string FirstNameInvalid = "Kullanici ismi gecersiz";
        public static string LastNameInvalid = "Kullanici soyismi gecersiz";

        //Customer magic string
        public static string CustomerAdded = "Musteri eklendi";
        public static string CustomerDeleted = "Musteri silindi";
        public static string CustomersListed = "Musteri listelendi";
        public static string CompanyNamesListed = "Sirket isimleri listelendi";

        //Rental magic string
        public static string RentalAdded = "Kiralama yapildi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalInvalid = "Kiralama basarisiz";
        public static string RentalListed = "Kiralamalar listelendi";
        public static string RentDatesListed = "Kiralama tarihleri listelendi";
        public static string ReturnDatesListed = "Iade tarihleri listelendi";
    }
}