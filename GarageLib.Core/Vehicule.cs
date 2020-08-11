using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{
    public abstract class  Vehicule : IComparable <Vehicule>
    {
        public static int Id = 0;

        public string Nom { get; set; }
        public double prix;
        public double Prix { get => prix; set => prix = value; }
        public string Marque { get; set; }
        public Option Option;

        public Moteur Moteur;

        public Vehicule()
        {

        }

        
        public Vehicule(string nom, double prix, string marque, Option option, Moteur moteur)
        {
            Id = Id + 1;
            this.Nom = nom;
            this.Prix = prix;
            this.Marque = marque;
            this.Option = option;
            this.Moteur = moteur;
        }

        public void AfficherInfo()
        {
            Console.WriteLine("                    -----------------------");
            Console.WriteLine("                          Information du véhicule");
            Console.WriteLine("");
            Console.WriteLine("L'id du vehicule est : " + Id);
            Console.WriteLine("Son nom est : " + Nom);
            Console.WriteLine("Son prix est : " + Prix+ "k");
            Console.WriteLine("Sa marque est : " + Marque);
            Option.AfficherOption();
            Moteur.AfficherMoteur();
            /*if (V.Count == 0)
            {
                throw new VehiculesIsEmptyException();
            }*/

        }

        public List<Option> optionslist = new List<Option>();
        public List<Vehicule> V = new List<Vehicule>();


        public void AjouterOption(Option option)
        {
            this.optionslist.Add(option);
            Console.WriteLine("-- Les options ajouté(es) --");
            option.AfficherOption();
        }

        public void GetMoteur()
        {
            Console.WriteLine("                    -----------------------");
            Console.WriteLine("le moteur de ce " + Nom +" est : " + Moteur.Type);

        }

        public void  GetMarque()
        {
            Console.WriteLine("                    -----------------------");
            Console.WriteLine("la marque de ce " + Nom + " est : " + Marque);
        }

        public void GetOption()
        {
            Console.WriteLine("                   -----------------------");
            Console.WriteLine("le moteur de ce " + Nom + " est : " +Option.Nom);
            for (int i = 0; i < optionslist.Count; i++)
            {
                Console.WriteLine("le moteur de ce " + Nom + " est : " + optionslist[i].Nom);
            }
            
        }

        public void GetPrix()
        {
            Console.WriteLine("                    -----------------------");
            Console.WriteLine("la marque de ce " + Nom + " est : " + Prix+ "K");
            Console.WriteLine("la taxe sur ce vehicule est de " + Taxes);
        }

        public abstract double Taxes { get; }

        public abstract void AfficherMoreinfo();

        public void GetTotalPrix()
        {
            double Total = 0;

            for (int i = 0; i < optionslist.Count; i++)
            {
                Total = Total + optionslist[i].Prix;
            }

            Total = Total + Taxes + prix;
            Console.WriteLine("                    -----------------------");
            Console.WriteLine("                              TOTAL " + Nom);
            Console.WriteLine("le prix TTC de ce vehicule est de : " + Total);
        }

        
         public int CompareTo(Vehicule Other_vehicule)
         {

            if (this.Prix == Other_vehicule.Prix)
            {
                return this.Nom.CompareTo(Other_vehicule.Nom);
            }
            return this.Prix.CompareTo(Other_vehicule.Prix); 
          }

    }
}
