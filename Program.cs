using System;

namespace dev004_Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha seu carro:");
            var carroEscolha = Console.ReadLine();

            var carro = carroEscolha.ToLower().Trim();

            string mensagem;
            if (carro == "chevette" || carro == "chevete" || carro == "xeveti")
            {
                mensagem = "Chevette é carro antigo, mas é carrão!";
            }
            else if (!string.IsNullOrWhiteSpace(carro))
            {
                mensagem = $"O carro escolhido foi: {carroEscolha}";
            }
            else
            {
                mensagem = $"Escreve alguma coisa animal!";
            }

            Console.WriteLine(mensagem);
        }
    }
}