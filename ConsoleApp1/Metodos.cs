using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Metodos
    {
        int numero1 = 5;

        int numero2 = 6;

        void primerMetodo()
        {
            Console.WriteLine(numero1 + numero2);
        }

        void segundoMetodo()
        {
            Console.WriteLine(numero1 - numero2);
        }

        int suma(int operador1, int operador2) => operador1 + operador2;

        int suma(int numero1, int numero2, int numero3) => numero1 + numero2;
    }
}
