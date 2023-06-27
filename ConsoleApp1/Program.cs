
// 1. Sustitución en cadenas
//Console.WriteLine("Introduce un número: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Introduce otro número: ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine($"Número 1: {a}. Número 2: {b}.");


// 2. Pedir valores por pantalla
//Console.WriteLine("Introduce un número: ");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine($"Número + 3: {num + 3}");


// 3. Constantes
//const int VALOR = 5;
//Console.WriteLine(VALOR);
//const double PI = Math.PI;
//Console.WriteLine(PI);


// 4. Métodos
//void metodoVacio()
//{
//    Console.WriteLine("Escribo por pantalla");
//}
//metodoVacio();

//int sumar(int x, int y)
//{
//    return x + y;
//}
//Console.WriteLine(sumar(1, 3));

//double dividir(int a, int b) => a / b;
//Console.WriteLine(dividir(12, 2));


// 5. Varios
//Console.WriteLine("Introduce núm y le sumaré 10 uds: ");
//int edad = Int32.Parse(Console.ReadLine());
//Console.WriteLine(edad + 10);


// 6. Comparación cadenas
//Console.WriteLine("Introduce tu nombre: ");
//string nombre = Console.ReadLine();
//int comparacion = String.Compare(nombre, "Dani", false);
//// Analizamos la cadena introducida respecto a 'Dani'
//if (comparacion == 0)
//{
//    Console.WriteLine("El nombre introducido es Dani");
//}
//else if (comparacion < 0)
//{
//    Console.WriteLine("El nombre introducido va antes en el alfabeto que Dani");
//}
//else
//{
//    Console.WriteLine("El nombre introducido va después en el alfabeto respecto a Dani");
//}


// 7. Clase Random
Random numero = new Random();
int numAleatorio = numero.Next(0, 100);
Console.WriteLine(numAleatorio);
