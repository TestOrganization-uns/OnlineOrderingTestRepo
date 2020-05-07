using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering.Interfaces
{
    //Za svaki od interfejsa neophodno je kreirati odgovarajuce lazne implementacije koje ce isti implementirati
    //Te lazne implementacije neophodno je koristiti u testiranju, prema principima koji su radjeni na vezbama u toku semestra
    public interface IOrder
    {
        //Metoda koja ce snimiti porudzbinu u bazu na osnovu prosledjenog ID-a korisnika i porudzbine
        void SaveOrderToDB(int orderId, int userId);
    }
}
