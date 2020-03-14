using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {

            Neandertal jes = new Neandertal();

            Homosapiens car = new Homosapiens();

            Humanos[] human = new Humanos[2];
            human[0] = jes;
            human[1] = car;

            foreach(Humanos test in human)
            {
                test.Saludar();
            }
            Console.ReadKey();
        }
    }


    interface Humanos
    {
         void Saludar();
    }


    class Neandertal :Humanos
    {
        public void Saludar() => Console.WriteLine("Hola soy un Neandertal");
        
    }

    class Homosapiens : Humanos
    {
        public void Saludar() => Console.WriteLine("Hola soy un Homosapiens");
    }



}
