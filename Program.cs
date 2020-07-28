using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertPolishLetters
{
    class Program
    {

        /*
         * Zadanie 4:
            -Stwórz metodę, która przyjmuje 1 wartość tekstową i zwraca wynik, zdanie bez polskich znaków.
            
            Przykład:
            -Dla parametru "Język programowania" zostanie zwrócne "Jezyk programowania".
            -Dla parametru "Słowa żźśćółęą" zostanie zwrócne "Slowa zzscolea".
        */

        static void Main(string[] args)
        {

            Console.WriteLine("Podaj tekst a program usunie z niego polskie znaki");
            var text = Console.ReadLine();

            Console.WriteLine(NoPolishSigns(text));

            Console.ReadLine();

        }

        public static string NoPolishSigns(string value)
        {
            value = value.Replace("ś", "s");
            value = value.Replace("ó", "o");
            value = value.Replace("ą", "a");
            value = value.Replace("ę", "e");
            value = value.Replace("ł", "l");
            value = value.Replace("ż", "z");
            value = value.Replace("ź", "z");
            value = value.Replace("ć", "c");
            value = value.Replace("ń", "n");

            // :)

            return value;
        }

    }
}
