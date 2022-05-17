using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{

    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string CarName { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public double DailyPrice { get; set; }

        //Kuantum
        [ForeignKey("ColorId")]
        public Color Color { get; set; }


        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }

    }
}
