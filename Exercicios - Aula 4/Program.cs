namespace Exercicios___Aula_4
{
    internal class Program
    {
        static void Main(string[] args)

        {
             
            
                Console.Clear();

                Console.WriteLine("Volume Calculator");

                Console.WriteLine("Digite 1 para iniar");
                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();


                Console.WriteLine("Digite o Comprimento");

                string primeiroNumeroString = "";

                primeiroNumeroString = Console.ReadLine();

                double primeiroNumero = Convert.ToDouble(primeiroNumeroString);

                Console.WriteLine("Digite a Largura");

                string segundoNumeroString = Console.ReadLine();

                double segundoNumero = Convert.ToDouble(segundoNumeroString);

                Console.WriteLine("Digite a Altura");

                string terceiroNumeroString = Console.ReadLine();
                
                double terceiroNumero = Convert.ToDouble(terceiroNumeroString);

                double resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero * segundoNumero * terceiroNumero;
                }

                Console.WriteLine("O resultado é: " + resultado);

                Console.ReadLine();


            



        }
    }
}
