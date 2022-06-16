using System;
using System.Collections.Generic;
using System.Linq;

namespace VeeamAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> values = new List<string>()
            //{
            //    new string("text1")
            //};


            List<string> value = new List<string>()
            {
               "var", "ls", "ll"
            };
            var text = new Immutable("string1", value);

            Console.WriteLine(text.Value);
            foreach(var a in text.Values)
            {
                Console.WriteLine(a);
            }

        }
    }
}
