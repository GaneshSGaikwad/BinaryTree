using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearchTree
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

          /*  BinarySearchTree b=new BinarySearchTree();
            b.Insert(50);
            b.Insert(30);
            b.Insert(70);
            b.Insert(60);
            b.Insert(10);
            b.Insert(90);

             b.inOrder(b.Root);*/


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
