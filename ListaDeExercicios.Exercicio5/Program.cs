namespace ListaDeExercicios.Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o
            //total de vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Calculador de Salário");
            Console.WriteLine("------------------------------------");

            #region imput de dados
            Console.WriteLine("Informe o valor do salário base: ");
            double salBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas: ");
            int totVendas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o percentual de comissão: ");
            double comissao = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento de dados
            comissao = comissao / 100;      //transforma em porcentagem

            double totSalario = (totVendas * comissao) + salBase;
            #endregion

            #region output de dados
            Console.WriteLine($"O salário total do vendendor é de R${totSalario.ToString("F2")}: ");
            #endregion

            Console.ReadLine();
        }
    }
}
