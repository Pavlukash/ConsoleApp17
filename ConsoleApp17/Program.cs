using System;
using System.Globalization;
using System.Runtime;
using System.Linq;

namespace ConsoleApp17
{
    internal class Program
    {
        //Написать метод, которая принимает две буквенные строки, а возвращает строку, где будут уникальные символы обоих строк в алфавитном порядке
        private static Helper _helper = new Helper();
        static void Main(string[] args)
        {
            string a = _helper.ValidateStrWithoutNums(Console.ReadLine());
            string b = _helper.ValidateStrWithoutNums(Console.ReadLine());
            Console.WriteLine(WriteUnique(a, b));
        }
        private static string WriteUnique(string a, string b)
        {
            char[] chars = (a + b).Distinct().ToArray();
            Array.Sort(chars);
            string final = new string(chars);
            return final;
            //Закоментированный ниже код является первоначальной версией, которая пиздец сложная как всегда нахуй, спасибо хоть, что без вложенных ебать их в сраку циклов
            /*char[] chars = a.Distinct().ToArray();
           char[] chars2 = b.Distinct().ToArray();
           string substring = new string(chars);
           string final = new string(chars2);
           (final = final.Insert(0, substring)).ToCharArray();
           char[] chars3 = final.ToCharArray();
           Array.Sort(chars3.Distinct().ToArray());
           final = new string(chars3);
           Console.WriteLine(final);*/

        }
    }
}

