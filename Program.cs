using System;

namespace CsOrientado
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Banco conta1 = new Banco();
            double numerodaConta = random.Next(7654321);

            Console.WriteLine("Bem vindo ao atendimento.\n");
            Console.WriteLine("-----Vi que você é novo!\nDeseja começar com um depósito na sua conta? (Y para sim/N para não)");
            string opt = Console.ReadLine();

            if (opt == "y")
            {
                CriarContaDeposito(numerodaConta);

            }
            else if (opt == "n")
            {
                CriarConta(numerodaConta);
            }
            Console.WriteLine(".......\n");
            Console.WriteLine("Deseja executar mais alguma ação?");
            Console.WriteLine("\n(1)Saque:" +
                              "\n(2)Depósito" +
                              "\n(0)Finalizar.");
            Console.WriteLine(".......\n");
            int menu = int.Parse(Console.ReadLine());

            do
            {
                if (menu == 1)
                {
                    Console.WriteLine("(Lembre-se que descontamos 5 reais de taxa)\n" +
                                      "Informe o valor a ser sacado:");
                    conta1.Saque = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Seu saldo atual é de: {conta1.Saldo}");
                    if (conta1.Saldo < 0)
                    {
                        Console.WriteLine("     Seu saldo está negativo:");
                    }
                }
                else if(menu == 2)
                {
                    Console.WriteLine("Deseja depositar qual valor?");
                    conta1.Deposito = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Seu saldo atual é de: {conta1.Saldo}");
                }
                Console.WriteLine("Deseja executar mais alguma ação?");
                Console.WriteLine("\n(1)Saque:" +
                                  "\n(2)Depósito" +
                                  "\n(0)Finalizar.");
                menu = int.Parse(Console.ReadLine());

            } while (menu != 0);
            Console.WriteLine("Operação encerrada, muito obrigado.");
;
        }
        static Banco CriarContaDeposito(double numerodaConta)
        {
            Console.WriteLine("Perfeito.");
            Console.WriteLine("Me diz seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Por fim, a quantia a ser depositada: ");
            double primeiroDeposito = double.Parse(Console.ReadLine());
            Banco conta1 = new Banco(nome, numerodaConta, primeiroDeposito);
            Console.WriteLine($"****\nBem vindo sr(a) {conta1.OwnerName}, aqui estão seus dados:\n" +
                              $"--Conta de número: {conta1.Numero}\n" +
                              $"--Propriedade de: {conta1.OwnerName}\n" +
                              $"--Saldo em conta: {conta1.Saldo}");
            return conta1;
        }
        static Banco CriarConta(double numerodaConta)
        {
            Console.WriteLine("Perfeito...\n");
            Console.WriteLine("Me diz seu nome: ");
            string nome = Console.ReadLine();
            Banco conta1 = new Banco(nome, numerodaConta);
            Console.WriteLine($"Bem vindo sr(a) {conta1.OwnerName}, aqui estão seus dados:\n" +
                              $"Conta de número: {conta1.Numero}\n" +
                              $"Propriedade de: {conta1.OwnerName}\n" +
                              $"Saldo em conta: {conta1.Saldo}");
            return conta1;
        }
    }
}
