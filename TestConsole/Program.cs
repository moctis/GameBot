using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    using CoreBLL;

    class Program
    {
        private static EventyList<double> list;

        static void Main(string[] args)
        {
            TestEventList();
            Console.ReadKey();
        }

        private static void TestEventList()
        {
            list = new EventyList<double>();
            list.OnAdd += list_OnAdd;
            Add(10);
            Add(20);
            Add(10);
        }

        private static void list_OnAdd(EventyList<double> sender, double item)
        {
            Console.WriteLine("Add {0}", item);
        }

        public static void Add(int item)
        {
            if (!list.Contains(item))
                list.Add(item);
        }
    }
}
