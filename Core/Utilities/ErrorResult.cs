using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class ErrorResult:Result
    {
        //Islem Sonucu Basarisiz Sonucu
        public ErrorResult(string message):base(false, message)
        {

        }

        public ErrorResult():base(false)
        {
            
        }
    }
}
