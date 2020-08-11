using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{
    public class Moto :  Vehicule
    {
        private int Cylindre;

        public override double Taxes => Math.Truncate(Cylindre * 0.3);
        public Moto()
        {

        }
        public Moto(string nom, double prix, string marque , Option option, Moteur moteur, int cylindre) : base (nom, prix, marque, option, moteur)
        {
            this.Cylindre = cylindre;
        }
        
        
        public override void AfficherMoreinfo()
        {
            Console.WriteLine("                    -----------------------");
            Console.WriteLine("Le volume du cylindre est de : " + Cylindre + " m3");
            Console.WriteLine("la taxe sur ce vehicule est de " + Taxes + "E");
        }
    }
}
