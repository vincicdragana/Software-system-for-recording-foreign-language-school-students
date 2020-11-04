using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface OpstiDomenskiObjekat
    {
        string nazivTabele { get; }
        string primarniKljuc { get; }
        string uslovPrimarni { get; }
        string uslovOstalo { get; }
        string izmena { get; }
        string unos { get; }

        OpstiDomenskiObjekat procitaj(DataRow red);

    }
}
