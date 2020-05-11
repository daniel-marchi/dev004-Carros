using System;

namespace dev004_Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha seu carro:");
            var carroEscolha = Console.ReadLine();

            string mensagem;

            if (carroEscolha == "brazilia")
            {
                mensagem = "Brazilia não carro, é carroça!";
            }
            else
            {
                mensagem = $"O carro escolhido foi: {carroEscolha}";
            }

            Console.WriteLine(mensagem);
        }
    }
}
