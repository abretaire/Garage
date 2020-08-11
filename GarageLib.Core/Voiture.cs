using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{
    public class Voiture : Vehicule
    {
        private double Puissance; 
        private int NbrePortes;
        private int NbreDeSieges;
        private double TailleCoffre;

        public override double Taxes => (Puissance * 10);

        public Voiture(string nom, double prix, string marque, Option option, Moteur moteur,double puissance, int nbrePortes, int nbreDeSieges, double tailleCoffre)
            : base(nom, prix, marque, option, moteur) 
        {

            this.Puissance = puissance;
            this.NbrePortes = nbrePortes;
            this.NbreDeSieges = nbreDeSieges;
            this.TailleCoffre = tailleCoffre;
        }

        public override void AfficherMoreinfo()
        {
            Console.WriteLine("                    -----------------------");
            Console.WriteLine("La puissance de ce vehicule est de : " + Puissance + " wh");
            Console.WriteLine("Le nombre de portes de ce vehicule est de : " + NbrePortes );
            Console.WriteLine("Le nombre de siege de ce vehicule est de : " + NbreDeSieges);
            Console.WriteLine("La taille du coffre de ce vehicule est de : " + TailleCoffre + " m3");
            Console.WriteLine("La taxe sur ce vehicule est de " + Taxes + " euros");
        }
    }
}
