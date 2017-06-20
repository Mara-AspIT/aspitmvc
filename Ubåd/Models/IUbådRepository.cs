using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubåd.Models
{
    public interface IUbådRepository
    {
        List<Ubåd.Models.UBåd> HentAlle();
        List<Ubåd.Models.UBåd> HentNogle(int a);

    }
}
