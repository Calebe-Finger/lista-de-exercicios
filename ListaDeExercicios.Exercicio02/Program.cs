namespace ListaDeExercicios.Exercicio02
{
    internal class Program
    {
        //Crie um programa para calcular o volume de um Cilindro
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Calcaular Volme de um Cilindro");
            Console.WriteLine("-------------------------------------");

            #region imput de dados
            Console.WriteLine("Digite o raio do cilíndro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilíndro: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento de dados
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            #endregion

            #region output de dados
            Console.WriteLine($"O valume do cilindro é de {volume}");
            #endregion

            Console.ReadLine();
        }
    }
}
