using System;

namespace Convesor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nome = null;
            int idade = 0;
            double salario = 0;

            //Adicionando o Nome na Variável
            nome = Console.ReadLine();


      
            Console.WriteLine("Digite sua idade");
            //Adicionando a idade na Variável
            idade = int.Parse(Console.ReadLine());
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("Seu salário é: " + salario);
        }
    }
}
