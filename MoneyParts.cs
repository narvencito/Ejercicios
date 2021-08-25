using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    public class MoneyParts
    {
        public void build(string pAmount)
        {
            double amount = Convert.ToDouble(pAmount);
            List<double> denomination = new List<double> { 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200 };
            StringBuilder result = new StringBuilder();

            foreach (var item in denomination)
            {
                int quotient = Convert.ToInt32(amount/item);

                if (amount ==  item * quotient)
                {
                    List<double> elements = new List<double>();
                    for (int i = 0; i < quotient; i++)
                    {
                        elements.Add(item);
                    }
                    result.Append("[" + String.Join(", ", elements) + "]");
                }

             
            }
           Console.WriteLine("Entrada: "+pAmount + " =>Salida: [" + result+"]");
        }
    }
}
