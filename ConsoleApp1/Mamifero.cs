using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Mamifero
    {
        // Propiedades
        private String nombreSerVivo;

        // Constructores
        public Mamifero(String nombre)
        { 
            this.nombreSerVivo = nombre;
        }

        // Métodos
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por sí solas");
        }

        public void getNombre()
        {
            Console.WriteLine($"El nombre del ser vivo es: {this.nombreSerVivo}.");
        }
    }

    public class Caballo : Mamifero
    {
        // Constructores
        public Caballo(String nombre) : base(nombre) { }

        // Métodos
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    public class Humano : Mamifero
    {
        // Constructores
        public Humano(string nombre) : base(nombre) { }

        // Métodos
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }

    public class Gorila : Mamifero
    {
        // Constructores
        public Gorila(string nombre) : base(nombre) { }

        // Métodos
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
    }
}
