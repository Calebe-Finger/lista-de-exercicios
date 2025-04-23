namespace ListaDeExercicios.Exercicio01
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma caixa retangular
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calcular Volume de uma Caixa Retangular");
            Console.WriteLine("---------------------------------------------");

            #region imput de dados
            Console.WriteLine("Digite o comprimento da caixa: ");
                Console.WriteLine("---------------------------------------------");
                decimal comprimento = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite a largura da caixa: ");
                Console.WriteLine("---------------------------------------------");
                decimal largura = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite a altura da caixa: ");
                Console.WriteLine("---------------------------------------------");
                decimal altura = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region processamento de dados
            decimal resultado = comprimento * largura * altura;
            #endregion

            #region output de dados
            Console.WriteLine($"O volume da caixa é de: {resultado}");
            Console.ReadLine();
            #endregion
        }
    }
}
