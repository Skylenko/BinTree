using System;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BinTree<Student> binTree = new BinTree<Student>();
            binTree.Put(new Student("23.4.2017", "AAvanov", "Math", 75));
            binTree.Put(new Student("23.4.2017", "Avanov", "Math", 75));
            binTree.Put(new Student("23.4.2017", "Xvanov", "Math", 75));
            binTree.Put(new Student("23.4.2017", "Yvanov", "Math", 75));

            foreach (Student s in binTree)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}