using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public double DailyPrice { get; set; }
        public short ModelYear { get; set; }
        public string CustomerFrstName { get; set; }
        public string CustomerLastName { get; set; }
        public DateTime CarRentDate { get; set; }
        public DateTime CarReturnDate { get; set; }
    }
}
