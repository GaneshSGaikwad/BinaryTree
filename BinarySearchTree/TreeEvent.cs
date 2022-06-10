using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public delegate void InsertData(int data);
    public delegate void TraverseData(Node node);
    public class TreeEvent
    {

        public static event InsertData OnInsert;
        public static event TraverseData OnTraverse;

        public static void Insert(int data)
        {
            if(OnInsert != null)
            {
                OnInsert(data);
            }

        }

        public static void Traverse(Node node)
        {
            if(OnTraverse != null)
            {
                OnTraverse(node);
            }
        }
    }
}
