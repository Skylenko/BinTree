using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class BinTree<K> : IEnumerable<K> where K : IComparable
    {
        private Node<K> _root;

        public void Put(K key)
        {
            Node<K> currentNode = new Node<K>();
            currentNode.key = key;

            if (_root == null)
            {
                _root = currentNode;
                return;
            }

            Node<K> temp = _root;

            Node<K> parent = temp;

            while (temp != null)
            {
                parent = temp;
                if (currentNode.CompareTo(temp) < 0)
                {
                    temp = temp.left;
                }
                else if (currentNode.CompareTo(temp) > 0)
                {
                    temp = temp.right;
                }
            }

            if (currentNode.CompareTo(parent) < 0)
            {
                parent.left = currentNode;
            }
            else if (currentNode.CompareTo(parent) > 0)
            {
                parent.right = currentNode;
            }
        }

        public class Node<K> : IComparable<Node<K>> where K : IComparable
        {
            public K key;
            public Node<K> left;
            public Node<K> right;

            public int CompareTo(Node<K> other)
            {
                return key.CompareTo(other.key);
            }
        }

        private LinkedList<K> EntryList()
        {
            LinkedList<K> list = new LinkedList<K>();
            
            return CLR(_root, list);
        }

        private LinkedList<K> CLR(Node<K> node, LinkedList<K> list)
        {
            if (node != null)
            {
                list.AddLast(node.key);
                CLR(node.left, list); // обойти левое поддерево
                CLR(node.right, list); // обойти правое поддерево
            }
            return list;
        }

        public IEnumerator<K> GetEnumerator()
        {
            foreach (var K in EntryList())
            {
                yield return K;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}