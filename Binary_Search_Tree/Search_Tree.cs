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

        public bool Search(int searchNumber)
        {
            if(root == null)
            {
                Console.WriteLine("No result found");
                Console.ReadLine();
                return false;
            }
            current = root;
            if(current.data == searchNumber)
            {
                Console.WriteLine($"{searchNumber} located in search tree");
                Console.ReadLine();
                return true;
            }
            while (true)
            {
                parent = current;
                if(searchNumber < parent.data)
                {
                    current = parent.leftChild;
                    if(current == null)
                    {
                        Console.WriteLine("No result found");
                        Console.ReadLine();
                        return false;
                    }
                    else if (searchNumber == current.data)
                    {
                        Console.WriteLine($"{searchNumber} located in search tree");
                        Console.ReadLine();
                        return true;
                    }
                }
                else
                {
                    current = parent.rightChild;
                    if(current == null)
                    {
                        Console.WriteLine("No result found");
                        Console.ReadLine();
                        return false;
                    }
                    else if (searchNumber == current.data)
                    {
                        Console.WriteLine($"{searchNumber} located in search tree");
                        Console.ReadLine();
                        return true;
                    }
                }
            }
                
            
        }
    }
}
