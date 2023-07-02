using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    internal class Empleado
    {
        // Propiedades
        private String nombre;
        private int edad;


        // Constructores
        public Empleado() { }

        public Empleado(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }


        // Getters, Setters
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }


        // ToString (Override)
        public override string ToString()
        {
            return ($"Nombre: {(this.nombre ?? "John Doe")}. Edad: {(this.edad == 0 ? 18 : this.edad)}.");
        }
    }
}
