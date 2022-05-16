using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public interface IResult
    {
        //Temel void'ler icin baslangic
        //get -> sadece okumak icin kullanilir.
        bool Success { get;}
        string Message { get; }
    }
}
