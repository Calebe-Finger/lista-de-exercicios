using System;

namespace ListaDeExercicios.Exercicio04
{
    internal class Program
    {
        //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Converter graus Celsius para Fahrenheit");
            Console.WriteLine("--------------------------------------------------");

            #region imput de dados
            Console.WriteLine("Qual a temperatura em graus Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento de dados
            double fahrenheit = (celsius * (9.0 / 5)) + 32;
            #endregion

            #region output de dados
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"A temperatura de {celsius}°C equivale a {fahrenheit}°F");
            #endregion

            Console.ReadLine();
        }
    }
}
