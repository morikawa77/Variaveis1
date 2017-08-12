using System;

namespace Variaveis1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			string nome, cidade, bairro;
			Console.Write("Digite o seu nome: ");
			nome = Console.ReadLine();
			Console.Write("Digite sua cidade: ");
			cidade = Console.ReadLine();
			Console.Write("Digite seu bairro: ");
			bairro = Console.ReadLine();
			Console.Write("A pessoa " + nome + " mora em " + cidade + " no bairro " + bairro);
			Console.ReadLine();
        }
    }
}
