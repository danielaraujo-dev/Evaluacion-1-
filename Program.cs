using System;
using System.Globalization;

namespace Evaluacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int numReg, contador=1, salario = 1000;
            double horastrabajadas, salariosemanal;

            
            while(contador == 1) 
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

                Console.WriteLine("Máxima Hora de llegada permitida: ");
                DateTime fecahYhora = DateTime.Now;
                TimeSpan hora = new TimeSpan(8, 0, 0);

                fecahYhora = fecahYhora.Date + hora;

                Console.WriteLine(fecahYhora.ToString());

                if (localDate > fecahYhora)
                {
                    Console.WriteLine("Hora de llegada Tardía. ¡No puede ingresar a trabajar!");
                }
                else
                {
                    Console.WriteLine("Bienvenido al trabajo");
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
