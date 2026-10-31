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

    // Dibuja el árbol de lado (raíz a la izquierda)
    public void PrintTree(Node node, int nivel = 0)
    {
        if (node == null) return;

        PrintTree(node.Right, nivel + 1);
        Console.WriteLine(new string(' ', nivel * 6) + node.Data);
        PrintTree(node.Left, nivel + 1);
    }

    public void GetLeaves(Node node, List<int> leaves)
    {
        if (node == null) return;

        if (node.Left == null && node.Right == null)
            leaves.Add(node.Data);

        GetLeaves(node.Left, leaves);
        GetLeaves(node.Right, leaves);
    }

    public int CountNodes(Node node)
    {
        if (node == null) return 0;
        return 1 + CountNodes(node.Left) + CountNodes(node.Right);
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

        Console.WriteLine("Árbol BST (girado 90°):");
        arbol.PrintTree(arbol.Root);
        Console.WriteLine();

        List<int> hojas = new List<int>();
        arbol.GetLeaves(arbol.Root, hojas);

        Console.WriteLine("Nodos hoja: " + string.Join(", ", hojas));
        Console.WriteLine("Total de nodos: " + arbol.CountNodes(arbol.Root));
    }
}
