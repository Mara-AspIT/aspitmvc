using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ubåd.Models
{
    public class UBådRepository : IUbådRepository
    {

        public List<UBåd> HentAlle()
        {
            List<UBåd> både = new List<UBåd>();
            både.Add(new UBåd() { Nummer = 200, Navn = "båd 1" });
            både.Add(new UBåd() { Nummer = 250, Navn = "båd 2" });
            både.Add(new UBåd() { Nummer = 430, Navn = "båd 3" });
            return både;
        }

        public List<UBåd> HentNogle(int antal)
        {
            return HentAlle().Take(antal).OrderBy(i => i.Nummer).ToList();
        }


    }
}