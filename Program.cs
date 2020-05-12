using System;

namespace dev004_Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha seu carro:");
            var carroEscolha = Console.ReadLine();

            var carro = carroEscolha.ToLower();

            string mensagem;
            if (!string.IsNullOrWhiteSpace(carro) && (carro == "chevette" || carro == "chevete" || carro == "xeveti"))
            {
                mensagem = "Chevette é carro antigo, mas é carrão!";
            }
            else
            {
                mensagem = $"O carro escolhido foi: {carroEscolha}";
            }

            Console.WriteLine(mensagem);
        }
    }
}