using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering.Interfaces
{
    //Za svaki od interfejsa neophodno je kreirati odgovarajuce lazne implementacije koje ce isti implementirati
    //Te lazne implementacije neophodno je koristiti u testiranju, prema principima koji su radjeni na vezbama u toku semestra
    public interface IUserLogger
    {
        //Metoda koja treba da vrati ID korisnika koji se prosledjuje kao parametar metode u okviru koje se ova metoda poziva
        int GetLoggedUserId();

        //Metoda na osnovu prethodno dobijenog ID-a korisnika treba da pronadje broj racuna korisnika
        string GetUserAccountNumber(int userId);
    }
}
