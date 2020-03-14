using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona juan = new Persona("Juan");
           
            //juan.Pensar();
            //juan.Nombre();

            Joven Jessica = new Joven("Jessica");
            // Jessica.Pensar();
            // Jessica.Nombre();

            Persona[] Humanos = new Persona[2];
            Humanos[0] = juan;
            Humanos[1] = Jessica;

            foreach(Persona s in Humanos)
            {
                s.Pensar();
                s.Nombre();
            }

            Console.ReadKey();
        }
    }



    public class Persona
    {
        public Persona(String nombre) => nombreVivo=nombre ;
        public void Pensar() => Console.WriteLine($"{nombreVivo} Pensado");
        public virtual void Nombre() => Console.WriteLine(nombreVivo);

        private String nombreVivo;
    }


    public class Joven : Persona
    {
        public Joven(string nombre) : base(nombre)
        {
            this.nombre = nombre;
        }

        public override void Nombre() => Console.WriteLine($"Sobrescribe metodo padre {nombre}");
        private String nombre;
    }
}
