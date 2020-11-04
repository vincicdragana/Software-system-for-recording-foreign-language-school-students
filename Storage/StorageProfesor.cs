using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class StorageProfesor
    {
        private List<Profesor> profesori;

        public StorageProfesor()
        {
            profesori = new List<Profesor>() {
                new Profesor {
                ImePrezime = "Mika Peric",
                Jmbg = "218471243290"
            } };

            Profesor p = new Profesor();
            p.ImePrezime = "Pera Peric";
            p.Jmbg = "3098591283750";


            Profesor p1 = new Profesor()
            {
                ImePrezime = "Zika Peric",
                Jmbg = "78264291876501"
            };
            profesori.Add(p);
            profesori.Add(p1);
        }

        public List<Profesor> VratiSve()
        {
            return profesori;
        }
    }
}
