using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering.Interfaces
{
    //Za svaki od interfejsa neophodno je kreirati odgovarajuce lazne implementacije koje ce isti implementirati
    //Te lazne implementacije neophodno je koristiti u testiranju, prema principima koji su radjeni na vezbama u toku semestra
    public interface IErrorLogger
    {
        //Metoda koja ce logovati potencijalnu gresku koja se moze desiti prilikom porucivanja proizvoda
        void LogError(string message);
    }
}
