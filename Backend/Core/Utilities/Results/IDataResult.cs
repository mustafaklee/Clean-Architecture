using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //eğer dönüş olarak data modelini dönmek istersek.
    //IDataResult IResult'daki succes ve message ifadelerini içerir.
    public interface IDataResult<out T>:IResult
    {
        T Data { get; }
    }
}
