using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rental:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }


        //Defaulted Value
        [DefaultValue(null)]
        public DateTime ReturnDate { get; set; }

        //Foreign key tanımlamaları
        [ForeignKey("CarId")]
        public Car Car { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}
