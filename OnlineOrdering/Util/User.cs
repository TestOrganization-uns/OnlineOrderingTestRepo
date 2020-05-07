using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering.Util
{
    public class User
    {
        //Jedinstveni identifikator korisnika - ID
        public int UserId { get; set; }

        //Broj racuna korisnika
        public string AccountNumber { get; set; }

        //Ime korisnika
        public string FirstName { get; set; }

        //Prezime korisnika
        public string LastName { get; set; }

        //Stanje na racunu korisnika
        public double AccountBalance { get; set; }

        //Novcani iznos za koji je korisnik zaduzen
        public double CreditRepayment { get; set; }

        //Oznaka da li korisnik ima odobren vec jedan kredit
        public bool CreditAvailable { get; set; }

        public User()
        {

        }

        public User(int userId, string accountNumber, string firstName, string lastName)
        {
            UserId = userId;
            AccountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;
            AccountBalance = 0;
            CreditRepayment = 0;
            CreditAvailable = false;
        }

        public User(int userId, string accountNumber, string firstName, string lastName, double accountBalance, double creditRepayment, bool creditAvailable)
        {
            UserId = userId;
            AccountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;
            AccountBalance = accountBalance;
            CreditRepayment = creditRepayment;
            CreditAvailable = creditAvailable;
        }
    }
}
