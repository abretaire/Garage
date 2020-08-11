using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageLib.Core;

namespace TpGarage
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Option Phare = new Option("Phare", 10);
             //Phare.AfficherOption();

             Option Volant = new Option("Volant", 18.5);
             //Volant.AfficherOption();

             Moteur diesel = new Moteur("Diesel", 65.5);
             //diesel.AfficherMoteur();

             Moto m = new Moto("MotoAntoine", 20.5, "BMW", Phare, diesel, 5);
             m.AfficherInfo(); 

             Voiture v = new Voiture("VoiturePaul", 35.5, "Seat", Phare, diesel, 158.2, 6, 3, 10.9);
             v.AfficherInfo();

             Garage g = new Garage("Garage République");
             Console.WriteLine("-- Les véhicules ajouté(es) --");
             g.AjouterVehicule(m);
             g.AjouterVehicule(v);


             Camion c = new Camion("CamionRomain", 15.5, "Scania", Phare, diesel, 6, 3.1, 11);
             c.AfficherInfo();
             c.AjouterOption(Volant);
             c.AfficherMoreinfo();

             c.GetTotalPrix();*/
            
            Garage g = new Garage("Garage République");
           
         
        
            Menu Accueil = new Menu(g);
            Accueil.Start();


            Console.ReadKey();
        }
    }
}
