using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GarageLib.Core;

namespace GarageTest
{
    [TestFixture]
    public class GarageTest
    {
        [Test]
        public void TestCreationOption()
        {
            // Arrange : créer une option
            Option option = new Option("Cuir", 2000);

            // Act : c'est aussi la création d'option

            //Assert
            Assert.AreEqual("Cuir", option.Nom);
            Assert.AreEqual(2000, option.Prix);
        }

        [Test]
        public void TestCreationMoto()
        {
            // Arrange : créer une option
            Moteur moteur = new Moteur("Diesel", 80);
            Option option = new Option("Cuir", 2000);
            Moto m = new Moto("MotoAntoine", 20.5, "BMW", option, moteur, 5);

            // Act : c'est aussi la création d'option

            //Assert
            Assert.AreEqual(m.Nom, "MotoAntoine");
            Assert.AreEqual(m.Prix, 150000);
            Assert.AreEqual(m.Marque, "BMW");
            Assert.AreEqual(m.Option, option);
            Assert.AreEqual(m.Moteur, moteur);
        }

        [Test]
        public void TestCalculerTaxeMoto()
        {
            // Arrange : créer une option
            Moteur moteur = new Moteur("Diesel", 80);
            Option option = new Option("Cuir", 2000);
            Moto m = new Moto("MotoAntoine", 20.5, "BMW", option, moteur, 5);

            // Act : c'est aussi la création d'option
            m.AfficherMoreinfo();

        }

        [Test]
        public void TestCreationCamion()
        {
            Moteur moteur = new Moteur("Essence", 200);
            Option option = new Option("Cuir", 2000);

            Camion c = new Camion("CamionRomain", 15.5, "Scania", option, moteur, 6, 3.1, 11);

            Assert.AreEqual(c.Nom, "CamionRomain");
            Assert.AreEqual(c.Prix, 120000);
            Assert.AreEqual(c.Marque, "Scania");
            Assert.AreEqual(c.Option, option);
            Assert.AreEqual(c.Moteur, moteur);
        }

        [Test]
        public void PrixTotalVehicule()
        {
            Moteur moteur = new Moteur("Diesel", 80);
            Option option = new Option("Cuir", 2000);
            Moto m = new Moto("MotoAntoine", 20.5, "BMW", option, moteur, 5);

            m.GetTotalPrix();

        }

        [Test]
        public void TestToInt32FormatException()
        {
            Moteur moteur = new Moteur("Diesel", 80);
            Option option = new Option("Cuir", 2000);
            Moto m = new Moto("MotoAntoine", 20.5, "BMW", option, moteur, 5);

            var ex = Assert.Throws<VehiculesIsEmptyException>(() => m.AfficherInfo());

            Assert.That(ex.Message, Is.EqualTo("exception test"));
        }
    }
}