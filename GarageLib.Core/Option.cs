using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageLib.Core;

namespace GarageLib.Core
{
    public class Option
    {
        public string Nom { get; set; }
        public double prix;
        public double Prix { get => prix; set => prix  =value; }

        public Option(string nom, double prix)
        {
            this.Nom = nom;
            this.Prix = prix;
        }

        public void AfficherOption()
        {
            Console.WriteLine(Nom + " est une option qui coute : " + Prix + " euros"); 
        }
    }
}
