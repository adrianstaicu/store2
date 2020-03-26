using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store2
{
    class Program
    {
        static void Main(string[] args)
        {
            CategorieProdus electrocasniceMici = new CategorieProdus();
            electrocasniceMici.denumireCategorie = "Electrocasnice mici";

            Produs laptop = new Produs();
            laptop.nume = "laptop Asus";
            laptop.pret = 4500;
            laptop.electrocasniceMici = electrocasniceMici;

            Produs fiercalcat = new Produs();
            fiercalcat.nume = " fier de calcat Philips";
            fiercalcat.pret = 400;
            fiercalcat.electrocasniceMici = electrocasniceMici;


          
            Console.WriteLine("Nume produs: " + laptop.nume + " Pret: " + laptop.pret + " Categorie: " + laptop.electrocasniceMici.denumireCategorie);
            Console.WriteLine("Nume produs: " + fiercalcat.nume + " Pret: " + fiercalcat.pret + " Categorie: " + fiercalcat.electrocasniceMici.denumireCategorie); 

            Console.ReadLine();
        }
    }
}
