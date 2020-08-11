using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{
    public class Camion : Vehicule
    {
        private int NbresDessieux;
        private double PoidsDeChargement;
        private double VolumeDeChatgement; 

        public override double Taxes => (NbresDessieux * 50);
       
        public Camion(string nom, double prix, string marque, Option option, Moteur moteur, int nbresDessieux, double poidsDeChargement, double volumeChargement)
            :base(nom, prix, marque, option, moteur)
        {
            this.NbresDessieux = nbresDessieux;
            this.PoidsDeChargement = poidsDeChargement;
            this.VolumeDeChatgement = volumeChargement;
        }

        public override void AfficherMoreinfo()
        {
            Console.WriteLine("                    -----------------------");
            Console.WriteLine("Le nombre d'essieux est de : " + NbresDessieux);
            Console.WriteLine("Le poids de chargement  est de : " + PoidsDeChargement + " kg");
            Console.WriteLine("Le volume de chargement  est de : " + VolumeDeChatgement + " m3");
            Console.WriteLine("la taxe sur ce vehicule est de " + Taxes + " euros");
        }

    }
}
