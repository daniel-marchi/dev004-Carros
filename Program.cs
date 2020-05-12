using System;

namespace dev004_Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha seu carro:");
            var carro = Console
                                    .ReadLine()
                                    .ToLower()
                                    .Trim();

            if (!ValidarCarro(carro))
                throw new Exception("Você precisa digitar algo! Carro é nulo ou em branco....");

            Console.WriteLine((carro == "chevette" || carro == "chevete" || carro == "xeveti")
                                    ? "Chevette é carro antigo, mas é carrão!"
                                    : $"O carro escolhido foi: {carro}");
        }

        public static bool ValidarCarro(string carro)
        {
            return !string.IsNullOrWhiteSpace(carro);
            // || carro.IsNumber()...
        }
    }
}