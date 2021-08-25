using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicios
{
    public class OrderRange
    {
        public void build(List<uint> numbers)
        {
            
            List<uint> listEven = new List<uint>();
            List<uint> listOdd = new List<uint>();

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    listEven.Add(item);
                }
                else
                {
                    listOdd.Add(item);
                }
            }

            //order
            listEven = listEven.OrderBy(q => q).ToList();
            listOdd = listOdd.OrderBy(q => q).ToList();

            //result
            var input = "Entrada: [ " + String.Join(",", numbers) + "]";
            var strEven = "Pares: [" + String.Join(",", listEven) + "]";
            var strOdd = "Impares: [" + String.Join(",", listOdd) + "]";

            Console.WriteLine(input +" =>Salida: "+strEven +" "+strOdd );
            Console.WriteLine();

        }
    }
}
