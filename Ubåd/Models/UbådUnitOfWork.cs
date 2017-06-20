using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ubåd.Models
{
    class UbådUnitOfWork // factory metode
    {
        public static IUbådRepository GetRepo() {

            // hvis der står ... i config.filen så gør....
            if (DateTime.Now.Millisecond % 2 == 0)
            {
                return new Models.UBådRepositoryRandom();
            }
            else
            {
                return new Models.UBådRepository();
            }
        }
    }
}