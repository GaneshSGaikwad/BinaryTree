using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearchTree
{
    public partial class Form1 : Form
    {
        int data;
       

        BinarySearchTree tree;
        TreeEvent tEvent = new TreeEvent();
        
       
        public Form1()
        {
            tree = new BinarySearchTree();
            TreeEvent.OnInsert += tree.Insert;
            TreeEvent.OnTraverse += tree.inOrder;
            InitializeComponent();
        }

        private void insertData_Click(object sender, EventArgs e)
        {
            TreeEvent.Insert(data);
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            data=int.Parse(txtData.Text);
           
        }

        private void displayData_Click(object sender, EventArgs e)
        {
            TreeEvent.Traverse(tree.Root);
        }
    }
}
