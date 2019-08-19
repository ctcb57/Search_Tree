using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Search_Tree
    {
        Node root;
        Node current;
        Node parent;


        public Search_Tree()
        {
            root = null;   
        }

        public void AddToTree(int numberToAdd)
        {
            Node node = new Node(numberToAdd);
            node.data = numberToAdd;
            if(root == null)
            {
                root = node;
                return;
            }
            else
            {
                current = root;
                while (true)
                {
                    parent = current;
                    if(numberToAdd <= current.data)
                    {
                        current = current.leftChild;
                        if(current == null)
                        {
                            parent.leftChild = node;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightChild;
                        if(current == null)
                        {
                            parent.rightChild = node;
                            return;
                        }
                    }
                }
            }
        }

        public void Search(int searchNumber)
        {
            if(searchNumber == root.data)
            {
                Console.WriteLine("Node is present");
                Console.ReadLine();
                return;
            }
            else
            {
                current = root;
                while (true)
                {

                }
            }
        }
    }
}
