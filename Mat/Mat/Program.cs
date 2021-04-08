using System;

namespace Mat
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2;
            valor1 = 28;
            valor2 = 2;

            double soma = valor1 + valor2;

            double multiplica = valor1 * valor2;

            double dividir = valor1 / valor2;

            double subtrair = valor1 - valor2;

            double media = soma / 2;
            Console.WriteLine("A soma de: "+valor1 +" + "+valor2+" = "+soma);

            Console.WriteLine("A multiplicação de: " + valor1 + " . " + valor2 + " = " + multiplica);

            Console.WriteLine("A divisão de: " + valor1 + " / " + valor2 + " = " + dividir);

            Console.WriteLine("A subtração de: " + valor1 + " - " + valor2 + " = " + subtrair);

            Console.WriteLine("A média de: " + valor1 + " e " + valor2 + " = " + media);
        }
    }
}
