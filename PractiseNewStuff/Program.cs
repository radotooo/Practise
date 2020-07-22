using System;
using System.Collections.Concurrent;
using System.Threading;

namespace PractiseNewStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter<int, string> stringify = x => x.ToString();
            var a = stringify(10);
            var generic = new Generics<string>();

            //var cc = new ConcurrentDictionary<char, int>();
            //var d = 'c';
            //var b = 'c';

            //while (true)
            //{
            //    var input = Convert.ToChar(Console.ReadLine());
            //    if (input == 'x')
            //    {
            //        break;
            //    }
            //    cc.AddOrUpdate(input, 1, (input, oldValue) => oldValue + 1);
            //}
            //foreach (var item in cc)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}
            //cc.AddOrUpdate('c', 1, (a, x) => x++);
            generic.PrintType2("dd");
            var gedsa = new Generics<Test>();
        }
    }
}
