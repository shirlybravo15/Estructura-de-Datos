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

public class BST
{
    public Node Root;

    public Node Insert(Node node, int key)
    {
        if (node == null) return new Node(key);

        if (key < node.Data)
            node.Left = Insert(node.Left, key);
        else if (key > node.Data)
            node.Right = Insert(node.Right, key);

        return node;
    }

    public void Add(int key)
    {
        Root = Insert(Root, key);
    }

    public void PreOrder(Node node)
    {
        if (node == null) return;
        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    public void InOrder(Node node)
    {
        if (node == null) return;
        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    public void PostOrder(Node node)
    {
        if (node == null) return;
        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }
}

public class Program
{
    public static void Main()
    {
        int[] claves = { 45, 23, 67, 12, 34, 56, 89 };

        BST arbol = new BST();
        foreach (int k in claves)
            arbol.Add(k);

        Console.Write("Preorden: "); arbol.PreOrder(arbol.Root);  Console.WriteLine();
        Console.Write("Inorden:  "); arbol.InOrder(arbol.Root);   Console.WriteLine();
        Console.Write("Posorden: "); arbol.PostOrder(arbol.Root); Console.WriteLine();
    }
}
