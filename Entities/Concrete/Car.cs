using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{

    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        [Required]
        [MinLength(2)]
        public string CarName { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        [Required]
        [MinLength(1)]
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
