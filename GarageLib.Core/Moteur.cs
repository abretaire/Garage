using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{
    public class Moteur
    {
        public string Type;
        public double puissance;
        public double Puissance { get => puissance; set => puissance = value; }

        public Moteur(string type, double puissance)
        {
           
            if(type == "DIESEL" || type == "HYBRIDE" || type == "ELECTRIQUE" || type == "ESSENCE")
            {
            this.Type = type;
            this.Puissance = puissance;
            }
            else
            {
                this.Type = "";
                this.Puissance = 0;
            }
        }

        public void AfficherMoteur()
        {
            Console.WriteLine("le moteur est de type : " + Type + " et de puissance " + Puissance + " kw");
        }

  
    }
}
