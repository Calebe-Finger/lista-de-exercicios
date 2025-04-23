namespace ListaDeExercicios.Exercicio03
{
    internal class Program
    {
        //Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Calcaular Cosumo de um Automóvel");
            Console.WriteLine("----------------------------------------");

            #region imput de dados
            Console.WriteLine("Qual a quilometragem inicial do veículo: ");
            int quiloIni = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a quilometragem final do veículo: ");
            int quiloFim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a quantidade de combustível consumida durante a viajem (litros): ");
            double consumo = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento de dados
            int quilometragem = quiloFim - quiloIni;
            double media = quilometragem / consumo;
            #endregion

            #region output de dados
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"A média do automóvel foi de {media}Km/L");
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
            #endregion
        }
    }
}
