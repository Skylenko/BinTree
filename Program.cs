using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BinTree binTree = new BinTree();
            binTree.put(5);
            binTree.put(1);
            binTree.put(9);
            
            Console.WriteLine(binTree);
            Console.ReadLine();
        }
    }
}