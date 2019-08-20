using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Search_Tree test = new Search_Tree();
            test.AddToTree(100);
            test.AddToTree(75);
            test.AddToTree(125);
            test.AddToTree(60);
            test.AddToTree(112);
            test.AddToTree(80);
            test.AddToTree(140);
            test.Search(14);
        }
    }
}
