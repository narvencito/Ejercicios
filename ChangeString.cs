using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
    public class ChangeString
    {
        public string build(string word)
        {
            List<char> abc = new List<char>() 
            { 
             'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' 
            };

            StringBuilder result = new StringBuilder();

            char[] wordArr = word.ToArray();

            foreach (var item in wordArr)
            {
                if (char.IsLetter(item))
                {
                    if (char.IsUpper(item))
                    {
                        result.Append(char.ToUpper(item.Equals('Z') ? 'A' : abc[abc.IndexOf(char.ToLower(item)) + 1]));
                    }
                    else
                    {
                        result.Append( char.ToLower(item).Equals('z') ? 'a' : abc[abc.IndexOf(char.ToLower(item)) + 1]);
                    }
                }
                else
                {
                    result.Append(item);
                }                
            }

            return result.ToString();

        }
    }
}
