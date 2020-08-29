using System;
using System.Collections.Generic;
using System.Text;

namespace RefresherConsole
{
    public class BinarySearchTree

    {
        //Check if the binary tree contains a value
        public static bool Contains(Node root, int value)
        {           
            //keep traversing until the end of the node
            while (root != null)
            {

                if (root.Value == value) return true;
                if (root.Value > value) root = root.Left;
                else root = root.Right;
            }

            return false;
        /*
        if(root == null) return false;
        if(root.Value == value) return true;
        if(root.Value > value) Contains(root.Left, value);
        return Contains(root.Right, value);     
        */

        }
    }


    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }



        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

    }
}
