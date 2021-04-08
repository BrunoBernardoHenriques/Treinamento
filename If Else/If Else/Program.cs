using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double numero = 0;

            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número");

             //Testar se número é par 
            double parouimpar = numero % 2;

            if(parouimpar != 0)
            {
                Console.WriteLine(numero + " é Impar");
            }
            else if(parouimpar == 0)
            {
                Console.WriteLine(numero + " é Par");
            }
          


        }
    }
}
