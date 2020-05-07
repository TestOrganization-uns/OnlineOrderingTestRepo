using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering.Interfaces
{
    //Za svaki od interfejsa neophodno je kreirati odgovarajuce lazne implementacije koje ce isti implementirati
    //Te lazne implementacije neophodno je koristiti u testiranju, prema principima koji su radjeni na vezbama u toku semestra
    public interface IEmailSender
    {
        //Prilikom potvrdjivanja porudzbine, salje se mail koji ce imati definisano kome se salje (parametar to), 
        //koji je naslov (parametar title) i telo poruke (parametar body)
        void SendEmail(string to, string title, string body);
    }
}
