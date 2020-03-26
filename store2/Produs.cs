using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store2
{
    class Produs
    {
        public string nume { get; set; }
        public double pret { get; set; }

        public CategorieProdus electrocasniceMici { get; set; }

        public Produs()
        {
            nume = " ";
            pret = 0;
            electrocasniceMici = new CategorieProdus(); 
        }
    }
}
