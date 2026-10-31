using System;
using System.Collections.Generic;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

public class TreeTraversals
{
    // 1. Recorrido Preorden 
    
    public void PreOrder(Node node)
    {
        if (node == null) return;
        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // 2. Recorrido Inorden (Left, Root, Right) - Imprime BST ordenado
    public void InOrder(Node node)
    {
        if (node == null) return;
        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // 3. Recorrido Posorden 
    public void PostOrder(Node node)
    {
        if (node == null) return;
        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }

    // 4. Recorrido BFS por niveles
  
    public void LevelOrder(Node root)
    {
        if (root == null) return;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            Console.Write(current.Data + " ");

            if (current.Left != null) queue.Enqueue(current.Left);
            if (current.Right != null) queue.Enqueue(current.Right);
        }
    }
}

public class Program
{
    public static void Main()
    {
        //        4
        //       / \
        //      2   6
        //     / \ / \
        //    1  3 5  7
        
        Node root = new Node(4);
        root.Left = new Node(2);
        root.Right = new Node(6);
        root.Left.Left = new Node(1);
        root.Left.Right = new Node(3);
        root.Right.Left = new Node(5);
        root.Right.Right = new Node(7);

        TreeTraversals t = new TreeTraversals();

        Console.Write("Preorden:   "); t.PreOrder(root);   Console.WriteLine();
        Console.Write("Inorden:    "); t.InOrder(root);    Console.WriteLine();
        Console.Write("Posorden:   "); t.PostOrder(root);  Console.WriteLine();
        Console.Write("Por niveles: "); t.LevelOrder(root); Console.WriteLine();
    }
}
