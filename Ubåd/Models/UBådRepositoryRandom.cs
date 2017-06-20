using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ubåd.Models
{
    public class UBådRepositoryRandom : IUbådRepository
    {
        public List<UBåd> HentAlle()
        {
            List<UBåd> både = new List<UBåd>();
            for (int i = 1; i < 100; i++)
            {
                både.Add(new UBåd()
                    { Nummer = i, Navn = "båd " + i });
            }
            return både;
        }

        public List<UBåd> HentNogle(int antal)
        {
            return HentAlle().Take(antal).OrderBy(i => i.Nummer).ToList();
        }

    }
}