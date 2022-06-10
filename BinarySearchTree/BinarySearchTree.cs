using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{

  

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node()
        {

        }

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }


    }

    public class BinarySearchTree
    {

       

        public Node Root { get; set; }

        public BinarySearchTree()
        {
         

            Root = null;
        }
       

        public void Insert(int i)
        {
            Node newNode = new Node(i);

            if(Root == null)
            {
                Root = newNode;
                return;
            }
            else
            {
                Node current = Root;
                Node parent=null;


                while (true)
                {
                    parent = current;

                    if(i < current.Data)
                    {
                        current=current.Left;
                        if(current == null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current=current.Right;
                        if(current == null)
                        {
                            parent.Right= newNode;
                            return ;
                        }
                    }
                }
            }

        }

        public void inOrder(Node node)
        {
            if(Root == null)
            {
                Console.WriteLine("Tree is empty");
                return;

            }
            else
            {
                if(node.Left != null)
                
                    inOrder(node.Left);

                Console.WriteLine(node.Data);
                if (node.Right != null)
                
                    inOrder(node.Right);
                



            }
        }

    }
}
