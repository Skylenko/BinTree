using System;

namespace ConsoleApplication
{
    public class BinTree
    {
        private Node root;
        
        public void put(int obj)
        {
            
            Node currentNode = new Node();
            currentNode.element = obj;
            

            
            if (root == null)
            {
                root = currentNode;
                return;
            }

            Node temp = root;
            
            Node parent = temp;
            while (temp != null)
            {
                parent = temp;
                if (currentNode.CompareTo(temp) < 0)
                {
                    temp = temp.left; 
                } else if (currentNode.CompareTo(temp) > 0)
                {
                    temp = temp.right;
                }
           
            }

            if (currentNode.CompareTo(parent) < 0)
            {
                parent.left = currentNode;
            } else if (currentNode.CompareTo(parent) > 0)
            {
                parent.right = currentNode;
            }
        }

    }

    internal class Node : IComparable
    {
        internal int element;
        internal Node left;
        internal Node right;

        public int CompareTo(object obj)
        {
            return element - (int)obj;
        }
    }
}