using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Interfaces
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public interface ILoggable
        {
            void Log();
            string Name { get; set; }
        }

        public class Animal : ILoggable
        {
            private string name;

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public void Log()
            {
                Console.WriteLine("Bork! I am " + name + ".");
            }
        }

        public class Vehicle : ILoggable
        {
            private string name;

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public void Log()
            {
                Console.WriteLine("Skrrrt! Vroom Vroom! I am " + name + ".");
            }
        }

        [STAThread]
        static void Main()
        {
            List<Animal> Animals = new List<Animal>();
            List<Vehicle> Vehicles = new List<Vehicle>();
            var garfield = new Animal() { Name = "Garfield" };
            var courage = new Animal() { Name = "Courage" };
            var diddy = new Animal() { Name = "Diddy" };
            var dogmeat = new Animal() { Name = "Dogmeat" };
            var cujo = new Animal() { Name = "Cujo" };
            var car = new Vehicle() { Name = "Speedy" };
            var optimus = new Vehicle() { Name = "Optimus Prime" };
            var motorcycle = new Vehicle() { Name = "Zoom" };
            Animals.Add(garfield);
            Animals.Add(courage);
            Animals.Add(diddy);
            Animals.Add(dogmeat);
            Animals.Add(cujo);
            Vehicles.Add(car);
            Vehicles.Add(optimus);
            Vehicles.Add(motorcycle);
            foreach (var animal in Animals)
            {
                animal.Log();
            }
            foreach (var vehicle in Vehicles)
            {
                vehicle.Log();
            }
            var a = 1;

        }
    }
}
