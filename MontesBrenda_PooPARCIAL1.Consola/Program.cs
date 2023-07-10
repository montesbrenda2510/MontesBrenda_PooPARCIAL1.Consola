using MontesBrenda_PooPARCIAL1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontesBrenda_PooPARCIAL1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crear una priramide");
            var ladodelabase = PedirInt("Ingrese el lado de la base: ");
            var altura = PedirInt("Ingrese la altura: ");

            Piramide piramide = new Piramide(ladodelabase, altura);

            Console.WriteLine("Informacion de la piramide");
            Console.WriteLine($"la arista es:{piramide.GetCalcularArista()}");
            Console.WriteLine($"El Area es: {piramide.GetArea()}");
            Console.WriteLine($"El volumen es: {piramide.GetVolumen()}");

            Console.ReadLine();


        }

        private static int PedirInt(string mensaje)
        {
            int nro;
            do
            {
                string str;
                Console.Write(mensaje);
                str = Console.ReadLine();

                if (int.TryParse(str, out nro))
                {
                    break;
                }
                Console.WriteLine("Número no válido");

            } while (true);
            return nro;

        }
    }
}
