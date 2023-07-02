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
//Random numero = new Random();
//int numAleatorio = numero.Next(0, 100);
//Console.WriteLine(numAleatorio);



// 8. Excepciones
//Console.WriteLine("Introduce un número: ");
//int num;

//try
//{
//    num = int.Parse(Console.ReadLine());
//}
//catch (OverflowException e)
//{
//    Console.WriteLine("El número introducido es demasiado largo para un int");
//}
//catch (ArgumentNullException e)
//{
//    Console.WriteLine("No se puede parsear un valor null");
//}
//catch (Exception e) when (e.GetType() != typeof(FormatException)) // Excepción con filtro
//{
//    Console.WriteLine($"Ha ocurrido una excepción no conocida: {e.Message}");
//}
//catch (FormatException e)
//{
//    Console.WriteLine($"No has introducido un número \nMensaje de error: {e.Message}");
//}



// 9. Uso checked (int y long)
//int maxEntero = int.MaxValue;
//Console.WriteLine(maxEntero);
//Console.WriteLine(maxEntero + 20);
/* Lo anterior no da error aunque se salga de rango (para que analice el overflow de forma estricta hay que (una de dos):
 * 1. Meter el bloque de código en checked
 * 2. Utilizar checked a nivel de línea
 * 3. Click derecho en proyecto -> properties -> build -> advanced -> check for arithmetic overflow
 */

// Opción 1 - Lo anterior pero comprobando estrictamente (nivel de bloque)
//checked
//{
//    Console.WriteLine("-----------");
//    Console.WriteLine(maxEntero);
//    Console.WriteLine(maxEntero + 20); // OverflowException (se checkea estrictamente)
//}
// Opción 2 - También comprobando estrictamente (nivel de línea)
//Console.WriteLine("-----------");
//Console.WriteLine(maxEntero);
//Console.WriteLine(checked (maxEntero + 20)); // OverflowException (se checkea estrictamente)
// Opción 3 - Seguir instrucciones del paso 3 arriba. No haría falta marcar nada, checkearía el proyecto.



// 10. Uso unchecked (int y long) -> (debemos tener el proyecto checkeando arithmetic overflow) -> mirar paso 3 anterior
//int maxEntero = int.MaxValue;
//Console.WriteLine("-----------");
//Console.WriteLine(maxEntero);
//Console.WriteLine(unchecked(maxEntero + 20)); // En este caso no lanza OverflowException (ya que decimos que no compruebe estrictamente)



// 11. Biblioteca de clases .NET (ver espacio de nombres con todos los métodos) -> https://learn.microsoft.com/es-es/dotnet/api/?view=net-7.0



// 12. Arrays
//using ConsoleApp1.Clases;

//// Explícitos
//int[] enteros = new int[3];
//enteros[0] = 1;
//enteros[1] = 2;
//enteros[2] = 3;

//double[] doubles = new double[] { 1, 5.6, 8, 9 };

//Empleado[] empleados = new Empleado[3];
//empleados[0] = new Empleado();
//empleados[1] = new Empleado("Dani", 22);
//Empleado emp = new Empleado("Sheraz", 25);
//empleados[2] = emp;

//// Implícitos
//var datos = new[] { 1, 2.5, 3 };        // Detecta que double es el mejor dato para el array en esta situación
//Console.WriteLine(datos.GetType());
//var nombres = new[] { "Chaima", "Luisma", "Alberto" };
//Console.WriteLine(nombres.GetType());


//// Arrays de tipos o clases anónimas
//var personas = new[]
//{
//    new {nombre = "Juan", edad = 19},
//    new {nombre = "María", edad = 49},
//    new {nombre = "Diana", edad = 35}
//};



// 13. Bucles for, foreach
//using ConsoleApp1.Clases;

//Empleado[] empleados = new Empleado[3];
//empleados[0] = new Empleado();
//empleados[1] = new Empleado("Dani", 22);
//Empleado emp = new Empleado("Sheraz", 25);
//empleados[2] = emp;

//for (int i = 0; i < empleados.Length; i++)
//{
//    Console.WriteLine(empleados[i]);
//}

//Console.WriteLine("=====");

//foreach (Empleado empleado in empleados)
//{
//    Console.WriteLine(empleado);
//}



// 14. Comentario TODO
// TODO: Este es un comentario visible desde la 'Lista de Tareas', donde se indicarán archivos líneas en las que tenemos comentarios TODO.



// 15. POO
//using ConsoleApp1.Clases;

//Punto p1 = new Punto(9, 5);
//Punto p2 = new Punto();

//Console.WriteLine(p1.X);
//p1.X = 4;
//Console.WriteLine(p1.X);



// 16. Herencia
using ConsoleApp1;

Caballo babieca = new Caballo("Babieca");
Humano juan = new Humano("Juan");
Gorila copito = new Gorila("Copito");

babieca.getNombre();
juan.getNombre();
copito.getNombre();