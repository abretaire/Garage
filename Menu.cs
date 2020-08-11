using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageLib.Core;

namespace TpGarage
{
    public class MenuException : Exception
    {
        public MenuException() : base("Le choix n'est pas compris entre O et 11")
        {
        }
    }

    public class Menu
    {
    
        public Garage Garage { get; set; }
        public Vehicule Vehicule { get; set; }
        public Option Option { get; set; }

        public Menu(Garage garage)
        {
            Garage = garage;
        }

        public void Start()
        {

            int choix = -1;

            do
            {
                Console.WriteLine(string.Format("********** Gestion de Garage**********"));
                Console.WriteLine(string.Format("1. Afficher les véhicules"));
                Console.WriteLine(string.Format("2. Ajouter un véhicule"));
                Console.WriteLine(string.Format("3. Sélectionner un véhicule"));
                Console.WriteLine(string.Format("4. Supprimer le véhicule"));
                Console.WriteLine(string.Format("5. Afficher les options du véhicule"));
                Console.WriteLine(string.Format("6. Ajouter des options au véhicule"));
                Console.WriteLine(string.Format("7. Supprimer des options au véhicule"));
                Console.WriteLine(string.Format("8. Afficher les options"));
                Console.WriteLine(string.Format("9. Afficher les marques"));
                Console.WriteLine(string.Format("10. Afficher les types de moteurs"));
                Console.WriteLine(string.Format("11. Sauvegarder le garage"));
                Console.WriteLine(string.Format("0. Quitter l'application"));
                Console.WriteLine(string.Format(""));

                try
                {

                    choix = GetChoixMenu();



                    switch (choix)

                    {

                        case 1:
                            AfficherVehicules();
                            break;

                        case 2:
                            AjouterVehicule();
                            break;

                        case 3:
                            SelectionVehicules();
                            break;

                        case 4:
                            SuprrimerVehicules();
                            break;

                        case 5:
                            AfficherOptionVehicules();
                            break;

                        case 6:
                            AjouterOption();
                            break;

                        case 7:
                            SupprimerOptionVehicules();
                            break;

                        case 8:
                            AfficherOptions();
                            break;

                        case 9:
                            AfficherMarques();
                            break;

                        case 10:
                            AfficherTypesMoteurs();
                            break;

                        case 11:
                            SauvegarderGarages();
                            break;
                        case 0:
                            QuitterApplication();
                            break;
                        default:
                            break;

                    }

                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Erreur : {0}", ex.Message);
                    Start();

                }

                catch (MenuException ex)
                {
                    Console.WriteLine("Erreur : {0}", ex.Message);
                    Start();
                }



            } while (choix != 0);



            Console.WriteLine(string.Format("Au revoir"));


        }


        public int GetChoix()
        {
            try
            {
                Console.Write("\nVotre choix : ");
                int choix = Int32.Parse(Console.ReadLine());
                
                return choix;
            }
            catch (FormatException)
            {
                throw new FormatException("Le choix saisie n'est pas un nombre");
            }


        }

        public int GetChoixMenu()
        {
            int choix = GetChoix();

            if (choix < 0 || choix > 11)
            {
                throw new MenuException();
            }

            return choix;
        }
        public void AfficherVehicules()
        {
            Garage.AfficherVehicules();
        }
        public void AjouterVehicule()
        {
            int choixCreation;

            Console.WriteLine(" Veuillez entrer le nom du Vehicule ");
            string nom = Console.ReadLine();

            Console.WriteLine(" Veuillez entrer le prix du Vehicule (nombre) € ");
            double prix = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Veuillez entrer la marque du Vehicule ");
            string marque = Console.ReadLine();

            Moteur Diesel = new Moteur("Essence", 136);
            Option BoiteAuto = new Option("Boite Automatique", 2500);


            Console.WriteLine(" Veuillez entrer le type du Vehicule: 1->(Voiture) 2->(moto) 3->(camion) ");
            choixCreation = Convert.ToInt32(Console.ReadLine());

            if (choixCreation == 1)
            {
                Console.WriteLine(" Veuillez entrer la puissance de la voiture ");
                int puissance = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Veuillez entrer le nombre de portes de la voiture  ");
                int nbrePortes = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine(" Veuillez entrer le nombre de sieges de la voiture ");
                int nbreDeSieges = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Veuillez entrer la taille du coffre de la voiture ");
                double tailleCoffre = Convert.ToInt32(Console.ReadLine());


                Voiture voiture = new Voiture(nom, prix, marque, BoiteAuto, Diesel, puissance, nbrePortes, nbreDeSieges, tailleCoffre);
                Console.WriteLine(" Voiture crée ");
                Garage.AjouterVehicule(voiture);

            }
            else if (choixCreation == 2)
            {


                Console.WriteLine(" Veuillez entrer le volume cylindré de la moto ");
                int cylindre = Convert.ToInt32(Console.ReadLine());


                Moto moto = new Moto(nom, prix, marque, BoiteAuto, Diesel, cylindre);
                Console.WriteLine(" Moto crée ");
                Garage.AjouterVehicule(moto);

            }
            else if (choixCreation == 3)
            {
                Console.WriteLine(" Veuillez entrer le nombre d'essieux du camion  ");
                int nbresDessieux = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Veuillez entrerle poid de la charge du camion  ");
                double poidsDeChargement = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Veuillez entrer le volume de charge du camion  ");
                int volumeChargement = Convert.ToInt32(Console.ReadLine());

                Camion camion = new Camion(nom, prix, marque, BoiteAuto, Diesel, nbresDessieux, poidsDeChargement, volumeChargement);
                Console.WriteLine(" Camion créé ");
                Garage.AjouterVehicule(camion);
            }

        }
        public void SuprrimerVehicules()
        {


            Console.WriteLine(" Veuillez entrer le nom du Vehicule à supprimer ");
            string nom = Console.ReadLine();


            Vehicule vehicule = null;
            if (Garage.VehiculesList.Count > 0)
            {

                for (int i = 0; i < Garage.VehiculesList.Count; i++)
                {
                    if (Garage.VehiculesList[i].Nom == nom)
                    {
                        vehicule = Garage.VehiculesList[i];
                    }
                }

                Garage.SupprimerVehicule(vehicule);
                Console.WriteLine(" Voiture supprimée ");
            }
            else
            {
                Console.WriteLine("\n > On ne peut supprimer de vehicule s'il n'en existe pas !\n");
            }
        }

        public void SelectionVehicules()
        {


            Console.WriteLine(" Veuillez entrer le nom du Vehicule séléctionner ");
            string nom = Console.ReadLine();


            Vehicule vehicule = null;

            if (Garage.VehiculesList.Count > 0)
            {

                for (int i = 0; i < Garage.VehiculesList.Count; i++)
                {
                    if (Garage.VehiculesList[i].Nom == nom)
                    {
                        vehicule = Garage.VehiculesList[i];
                    }

                }

                vehicule.AfficherInfo();
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("\n > On ne peut séléctionner de vehicule s'il n'en existe pas !\n");
            }

        }
        public void AfficherOptionVehicules()
        {
            Garage.AfficherOptionVehicules();
        }
        public void AjouterOption()
        {
            Console.WriteLine("les options de votre véhicule");
            Console.WriteLine(" Veuillez entrer le nom de votre option  ");
            string nom = Console.ReadLine();

            Console.WriteLine(" Veuillez entrer le prix de votre option  ");
            double prix = Convert.ToInt32(Console.ReadLine());

            Option option = new Option(nom, prix);
            Console.WriteLine("Option de votre véhicule créee");
            Garage.AjouterOption(option);
            
        }
        public void SupprimerOptionVehicules()
        {
            // Pas trouvé
        }
        public void AfficherOptions()
        {
            Garage.AfficherOption();
        }
        public void AfficherMarques()
        {
           Garage.AfficherMarques();
        }
        public void AfficherTypesMoteurs()
        {
            Garage.AfficherTypesMoteurs();
        }
        public void SauvegarderGarages()
        {
            // Pas trouvé
        }
        public void QuitterApplication()
        {
            Environment.Exit(0);
        }
    }
}


