using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Search_Tree
    {
        Node start;
        Node tail;

        public void AddToTree(int numberToAdd)
        {

        }

        public void Insert_At_End( int data)
        {
            Node node = new Node(data);
            if(start == null)
            {
                start = null;
                tail = node;
            }
            else
            {
                tail.link = node;
                tail = node;
            }
        }

        public void Search(int searchNumber)
        {

        }
    }
}
