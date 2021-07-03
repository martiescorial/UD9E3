using System;

namespace UD9E3
{
    class Operaciones
    {
        int valor1;
        int valor2;

        public Operaciones()
        {
            Console.WriteLine("Introduzca un primer valor");
            string linea1 = Console.ReadLine();
            valor1 = int.Parse(linea1);

            Console.WriteLine("Introduzca un segundo valor");
            string linea2 = Console.ReadLine();
            valor2 = int.Parse(linea2);
        }

        public void SumaValores()
        {
            int suma = valor1 + valor2;
            Console.WriteLine("La suma es:" + suma);
        }

        public void RestaValores()
        {
            int resta = valor1 - valor2;
            Console.WriteLine("La resta es:" + resta);
        }

        public void MultValores()
        {
            int multiplicacion = valor1 * valor2;
            Console.WriteLine("El producto es:" + multiplicacion);
        }

        public void DivValores()
        {
            int division = valor1 / valor2;
            Console.WriteLine("La division es:" + division);
        }

        static void Main(string[] args)
        {
            Operaciones operacion1 = new Operaciones();
            operacion1.SumaValores();
            operacion1.RestaValores();
            operacion1.MultValores();
            operacion1.DivValores();
            Console.ReadKey();
        }
    }
}