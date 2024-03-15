namespace Calculadora.ConsoleApp
//Calculadora - 1ª
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Calculadora");

                Console.WriteLine("Digite 1 para adicionar");

                Console.WriteLine("Digite 2 para subtrair");

                Console.WriteLine("Digite 3 para multiplicar");

                Console.WriteLine("Digite 4 para dividir");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                    break;

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "S" && operacao != "s")
                {
                    Console.WriteLine("Operação invalida, tente novamente.");
                    Console.ReadLine();

                    continue;
                }

                Console.WriteLine("Digite o primeiro número:");
                string primeiroNumeroString = "";

                primeiroNumeroString = Console.ReadLine();
                double primeiroNumero = Convert.ToDouble(primeiroNumeroString);

                Console.WriteLine("Digite o segundo número:");
                string segundoNumeroString = Console.ReadLine();

                double segundoNumero = Convert.ToDouble(segundoNumeroString);

                double resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                else if (operacao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        // caso for 0, pedir para o usuário digitar de novo
                        Console.WriteLine("Segundo número não pode ser ZERO");
                        Console.ReadLine();

                        Console.WriteLine("Digite o segundo número novamente: ");
                        segundoNumero = Convert.ToInt32(Console.ReadLine());
                    }

                    resultado = primeiroNumero / segundoNumero;
                }

                Console.WriteLine("O resultado é: " + resultado);
                Console.ReadLine();
            }
        }
    }
}
