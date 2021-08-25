using System;
using System.Collections.Generic;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeString changeString = new ChangeString();
            string word = "**Zapato 52";
            string result = changeString.build(word);
            Console.WriteLine("===== PREGUNTA 01 =====");
            Console.WriteLine($"Entrada: {word} Salida: {result} \n");

            Console.WriteLine("===== PREGUNTA 02 =====");
            List<uint> numbers = new List<uint> { 58, 60, 55, 48, 57, 73 };
            OrderRange OrderRange = new OrderRange();
            OrderRange.build(numbers);

            Console.WriteLine("===== PREGUNTA 03 =====");
            string amount = "10.50";
            MoneyParts moneyParts = new MoneyParts();
            moneyParts.build(amount);
            Console.ReadLine();



        }
    }
}
