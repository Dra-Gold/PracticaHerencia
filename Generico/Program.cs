using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(4);
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(1200));
            archivos.agregar(new Empleado(2000));
            archivos.agregar(new Empleado(7000));

            Empleado nombre = archivos.getElemento(2);
            Console.WriteLine(nombre.getSalario());
            Console.ReadKey();
        }
    }

    class AlmacenObjetos<T>
    {

        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];
        }

        public void agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public T getElemento(int i)
        {
            return datosElemento[i];
        }


        private T[] datosElemento;
        private int i=0;
    }

    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

        private double salario;
    }

}
