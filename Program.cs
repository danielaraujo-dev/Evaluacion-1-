using System;
using System.Globalization;
namespace Evaluacion_1_vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int numReg, contador = 1, salario = 1000, horallegada, minutollegada;
            double horastrabajadas, salariosemanal;


            while (contador == 1)
            {

                //Bienvenida al sistema
                Console.WriteLine("Bienvenido al Sitema de Registro y Manejo de personal Laboral de Microsoft.");
                Console.WriteLine("");
                Console.WriteLine("Por favor ingrese su Número de registro");
                Console.WriteLine("Recuerde que no puede utilizar decimales");
                numReg = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Bienvenido al sitema Usuario " + numReg);
                Console.WriteLine("");

                //Horario de Ingreso al trabajo
                Console.WriteLine("Usted ha accedido al sistema el siguiente día y la siguiente hora: ");
                DateTime localDate = DateTime.Now;
                Console.WriteLine(localDate.ToString());
                Console.WriteLine("");

                Console.WriteLine("Por favor Ingrese su Hora de llegada a las áreas de Trabajo");
                Console.WriteLine("Utilice Formato Militar");
                horallegada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Ahora Ingrese el Minuto de llegada");
                minutollegada = Convert.ToInt32(Console.ReadLine());

                if (horallegada > 8)
                {
                    Console.WriteLine("Hora de llegada Tardía. ¡No puede ingresar a trabajar!");
                }
                else
                {
                    Console.WriteLine("Bienvenido al trabajo");
                }
                if (minutollegada <= 5)
                {
                    Console.WriteLine("Consulte con el supervisor si puede ingresar al trabajo");
                }
                else
                {
                    Console.WriteLine("Hora de llegada Tardía. ¡No puede ingresar a trabajar!");
                }

                //calculadora
                Console.WriteLine("Ahora, Ingrese sus horas trabajadas la semana pasada");
                horastrabajadas = Convert.ToDouble(Console.ReadLine());

                salariosemanal = horastrabajadas * salario;
                Console.WriteLine("");
                Console.WriteLine("Usted ganó " + salariosemanal + " B.s S esta semana.");

                Console.WriteLine("");
                Console.WriteLine("¿Desea continuar con la operación?");
                Console.WriteLine("1. si");
                Console.WriteLine("0. no");
                contador = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
