using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Spring.Context.Support;

namespace WarStoryServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlApplicationContext ctx = new XmlApplicationContext("WarStory.xml");
                Console.WriteLine("Spring configuration succeeded, quartz jobs running.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.Out.WriteLine("--- Press <return> to quit ---");
                Console.ReadLine();
            }
            Console.Out.WriteLine("--- Press <return> to quit ---");
            Console.ReadLine();
        }
    }
}
