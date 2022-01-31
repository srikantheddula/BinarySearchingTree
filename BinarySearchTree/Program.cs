using System;

namespace BinarySearchTree
{
     class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(56); 
            binaryTree.Insert(30);  //Inserting the values to the Binary tree
            binaryTree.Insert(70);
            binaryTree.Display();
        }
    }
}
