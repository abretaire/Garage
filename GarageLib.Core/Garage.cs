using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageLib.Core;

namespace GarageLib.Core
{
    public class VehiculesIsEmptyException : Exception
    {
        public VehiculesIsEmptyException() : base("Aucun véhicule présent")
        {

        }
    }
    public class Garage
    {
        private string Nom;
        private string Marque;
        private string Moteur;
        private string Option;

        public Garage(string nom)
        {
            this.Nom = nom;
            Console.WriteLine("                    -----------------------");
            Console.WriteLine("                     Garage : " + Nom);
        }

        public List<Vehicule> VehiculesList = new List<Vehicule>();
        public List<Moteur> moteurs = new List<Moteur>();
        public List<Option> options = new List<Option>();

        public void AjouterVehicule(Vehicule vehicule)
        {
            VehiculesList.Add(vehicule);
            Console.WriteLine(vehicule.Nom);
        }

        public void sort()
        {
            VehiculesList.Sort();
        }

        public void GetInfo()
        {
            Console.WriteLine("                   -----------------------");
            Console.WriteLine("                          Informations Garage " + Nom );

            foreach (Vehicule vehicule in VehiculesList)
            {
                Console.WriteLine("Son nom est : " + vehicule.Nom);
            }
        }

        public void AfficherVehicules()
        {


            for (int i = 0; i < VehiculesList.Count; i++)
            {

                Console.WriteLine(string.Format("Vehicules dans le garage {0} :   {1} {2}", Nom, VehiculesList[i].Nom, VehiculesList[i].Marque));
                Console.WriteLine(string.Format(""));
            }

            if (VehiculesList.Count() == 0)
            {

                throw new VehiculesIsEmptyException();
            }
        }

        public void AfficherMarques()
        {


            for (int i = 0; i < VehiculesList.Count; i++)
            {

                Console.WriteLine(string.Format("Liste des marques dans le garage {0} :   {1} ", Marque, VehiculesList[i].Marque));
                Console.WriteLine(string.Format(""));
            }

            if (VehiculesList.Count() == 0)
            {

                throw new VehiculesIsEmptyException();
            }
        }
        public void AjouterMoteur(Moteur moteur)
        {

            moteurs.Add(moteur);

        }

        public void AjouterOption(Option option)
        {

            options.Add(option);

        }

        public void AfficherOption()
        {
            for (int i = 0; i < options.Count; i++)
            {
                
                Console.WriteLine(string.Format("Options présentes du vehicule :  {0}", options[i].Nom));
            }

        }

        public void AfficherTypesMoteurs()
        {
            for (int i = 0; i < VehiculesList.Count; i++)
            {
                
                Console.WriteLine(string.Format("Type du moteur :  {0}", Moteur, VehiculesList[i].Moteur));
            }

        }

        public void AfficherOptionVehicules()
        {
            for (int i = 0; i < VehiculesList.Count; i++)
            {

                Console.WriteLine(string.Format("Options du véhicule :  {0}", Option, VehiculesList[i].Option));
            }

        }
        public void SupprimerVehicule(Vehicule vehicule)
        {
            VehiculesList.Remove(vehicule);
        }
        
      }
    }

