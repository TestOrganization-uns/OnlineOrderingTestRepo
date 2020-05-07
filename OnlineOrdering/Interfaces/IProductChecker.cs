using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering.Interfaces
{
    //Za svaki od interfejsa neophodno je kreirati odgovarajuce lazne implementacije koje ce isti implementirati
    //Te lazne implementacije neophodno je koristiti u testiranju, prema principima koji su radjeni na vezbama u toku semestra
    public interface IProductChecker
    {
        //Metoda koja vraca informaciju da li je svaki od proizvoda dostupan na stanju
        bool CheckProductAvailability(int orderId);
    }
}
