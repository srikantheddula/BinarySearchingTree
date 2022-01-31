using System;

namespace BinarySearchTree
{
     class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(56); //Creting an object for class
            binaryTree.Insert(30);  //Inserting the values to the Binary tree
            binaryTree.Insert(70);
            binaryTree.Insert(67);
            binaryTree.Display();
            bool result = binaryTree.IfExists(67, binaryTree);
            Console.WriteLine(result);
        }
    }
}
