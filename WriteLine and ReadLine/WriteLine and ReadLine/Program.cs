using System;

namespace WriteLine_and_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adicionando Variável nomePessoa
            string nomePessoa = "Bruno";

            /*
           Adicionando Variável idadePessoa
             Adicionando Variável salárioPessoa
             */

            int idadePessoa = 18;
            double salarioPessoa = 1565.54;

            //Mostrar o Console para digitar o nome
            Console.WriteLine("Digite seu nome");

            //ReadLine
            nomePessoa = Console.ReadLine();

            //Mostrando Valores na Tela
            Console.WriteLine("Nome: "+nomePessoa);
            Console.WriteLine("Idade: " + idadePessoa);
            Console.WriteLine("Salário: " + salarioPessoa);


        }
    }
}
