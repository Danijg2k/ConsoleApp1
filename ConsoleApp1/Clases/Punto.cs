using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    internal class Punto
    {
        // Coordenadas del punto
        private int x;
        private int y;


        // Constructores
        public Punto()
        {
            this.x = 0;
            this.y = 0;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        // Métodos
        public double distanciaHasta(Punto p)
        {
            int xDif = this.x - p.x;
            int yDif = this.y - p.y;
            return (Math.Sqrt(Math.Pow(xDif,2) + Math.Pow(yDif,2)));
        }


        // Getters y Setters
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }


    }
}
