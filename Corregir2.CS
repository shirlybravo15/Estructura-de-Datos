using System;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
    }
}

public class BSTDeletion
{
    public Node DeleteNode(Node root, int key)
    {
        if (root == null) return root;

        if (key < root.Data)
            root.Left = DeleteNode(root.Left, key);
        else if (key > root.Data)
            root.Right = DeleteNode(root.Right, key);
        else
        {
          
            if (root.Left == null) return root.Right;
            else if (root.Right == null) return root.Left;

           
            root.Data = MinValue(root.Right);

            root.Right = DeleteNode(root.Right, root.Data);
        }
        return root;
    }

    private int MinValue(Node root)
    {
        int minv = root.Data;
        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }
        return minv;
    }
}

public class Program
{
    static void InOrder(Node node)
    {
        if (node == null) return;
        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    public static void Main()
    {
        Node root = new Node(4);
        root.Left = new Node(2);
        root.Right = new Node(6);
        root.Left.Left = new Node(1);
        root.Left.Right = new Node(3);
        root.Right.Left = new Node(5);
        root.Right.Right = new Node(7);

        BSTDeletion bst = new BSTDeletion();

        Console.Write("Original:          "); InOrder(root); Console.WriteLine();

        root = bst.DeleteNode(root, 1);  
        Console.Write("Elimina 1 (hoja):  "); InOrder(root); Console.WriteLine();

        root = bst.DeleteNode(root, 6);  
        Console.Write("Elimina 6 (2 hijos): "); InOrder(root); Console.WriteLine();

        root = bst.DeleteNode(root, 4);   // raíz con dos hijos
        Console.Write("Elimina 4 (raíz):  "); InOrder(root); Console.WriteLine();
    }
}
