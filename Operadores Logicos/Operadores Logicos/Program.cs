using System;

namespace Operadores_Logicos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Digite um nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
            // 11
           if(nome == "Bruno" && idade == 18)
            {
                Console.WriteLine("Seu nome é "+nome+" e sua idade é "+idade+" anos");

            }
            if (nome == "Bruno" || idade == 18)
            {
                Console.WriteLine("Seu nome pode ser Bruno ou sua idade pode ser 18 anos");

            }

            bool falso = true;
            bool verdade = false;

            if(!falso)
            {
                Console.WriteLine("Falso é verdade");
            }
            if (!verdade)
            {
                Console.WriteLine("Verdade é verdade");
            }

        }
    }
}
