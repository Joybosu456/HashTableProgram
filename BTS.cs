using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(56);
            Node n1 = new Node(30);
            Node n2 = new Node(70);
            

            root.left = n1;
            root.right = n2;

            Node nodeToFind = BinarySearchTree(root, 60);
            Console.WriteLine(nodeToFind.value);

            Node newroot = BinarySearchTree(root, 54);
            Console.WriteLine(newroot.right.right.right.value);



        }
    }
    class Node//creating Node class.
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int value)//creating constractar.
        {
            this.value = value;
        }
    }
    class BinarySearcgTree
    {
        public static Node Search(Node root, int value)
        public static Node Insert(Node root, int value)
        {
            if (root.value == value)
            {
                return root;
            }
            else if (value < root.value)
            {
                if (root.left != null)
                {
                    root.left = Insert(root left, value);
                }
                else
                {
                    Node newNode = new Node(value);
                    root.left = newNode;
                }
            }
            else if (value > root.value)
            {
                if (root.right != null)
                {
                    root.right = Insert(root.right, value);
                }
                else
                {
                    Node newNode = new Node(value);
                    root.right = newNode;
                }
            }
            return root;
        }


    }

    class BinarySearchTree
    {
        public static Search(Node root, int value)
        {
            if (root.value == value)
            {
                return root;
            }
            else if (value < root.value)
            {
                root = Search(root.left, value);
            }
            else if (value > root.value)
            {
                root = Search(root.right, value);
            }
            return root;
        }


    }


}