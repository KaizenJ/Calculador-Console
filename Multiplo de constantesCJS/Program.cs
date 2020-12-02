using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo_de_constantesCJS
{
    class Program
    {
        static void Main(string[] args)
        {
         //Variables
            string Nombre;
            string Apellido;
            string Curso;
            int Edad; 

         //Register 

            Console.WriteLine(" ««««« Bienvenido al register KaizenJS »»»»»»");
            Console.ReadLine();


            Console.WriteLine("Nombre del estudiante: ");
            Nombre = Console.ReadLine();
         //Console.ReadLine();

            Console.WriteLine("Apellido del estudiante: ");
            Apellido = Console.ReadLine();

            Console.WriteLine("Curso de estudiante: ");
            Curso = (Console.ReadLine());

            Console.WriteLine("Edad del estudiante");
            Edad = int.Parse(Console.ReadLine());

            if (Edad <= 12)
            {
                Console.WriteLine("Tas chikito");

            }

            else if (Edad >= 13 && Edad <= 20)
            {
                Console.WriteLine("Eres un adolecente bien-refachero");
            }

            else
            {
                Console.WriteLine("Eres un adulto");
            }

         //Auto-Calculator

            Console.WriteLine("¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦ Bienvenido a Calculator JS ¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦");
            Console.ReadLine();

            Console.WriteLine("Usuario completlo: {0} {1} ,Pertenece a : {2} ,Su edad es: {3} ", Nombre, Apellido, Curso, Edad);
            Console.ReadLine();


            int Num1, Num2, Total;
            string Linea;

            //Area de multiplicacion 
            Console.WriteLine("Digite su primer numero a multiplicar: ");
            Linea = Console.ReadLine();
            Num1 = int.Parse(Linea);

            Console.WriteLine("Digite su segundo numero a multiplicar: ");
            Linea = Console.ReadLine();
            Num2 = int.Parse(Linea);

            Console.WriteLine();
            Total = Num1 * Num2;
            Console.WriteLine("El total de su multiplicación es : " + Total);

            Console.ReadLine();

            //Area de suma
            Console.WriteLine("::**Suma**::");

            Console.WriteLine("Digite su primer numero a sumar: ");
            Linea = Console.ReadLine();
            Num1 = int.Parse(Linea);

            Console.WriteLine("Digite su segundo numero a sumar: ");
            Linea = Console.ReadLine();
            Num2 = int.Parse(Linea);

            Total = Num1 + Num2;
            Console.WriteLine("El total de su suma es: " + Total);

            Console.ReadLine();

            //Area de resta
            Console.WriteLine("::**Resta**::");

            Console.WriteLine("Digite su primer numero a restar: ");
            Linea = Console.ReadLine();
            Num1 = int.Parse(Linea);

            Console.WriteLine("Digite su segundo numero a restar: ");
            Linea = Console.ReadLine();
            Num2 = int.Parse(Linea);

            Total = Num1 - Num2;
            Console.WriteLine("El total de su resta es: " + Total);

            Console.ReadLine();

            //Area de división
            Console.WriteLine("::**División**::");

            Console.WriteLine("Digite su primer numero a dividir: ");
            Linea = Console.ReadLine();
            Num1 = int.Parse(Linea);

            Console.WriteLine("Digite su segundo numero a dividir: ");
            Linea = Console.ReadLine();
            Num2 = int.Parse(Linea);

            if (Num2 == 0)

            {
                Console.WriteLine("No se puede dividir entre cero ");
            }

            //else
            //{
            //    Console.WriteLine("");

            //}


            Total = Num1 + Num2;
            Console.WriteLine("El total de su división es: " + Total);

          
            //Key .exit
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();

        }
    }
}
