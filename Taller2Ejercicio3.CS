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

    // Inorden: guarda las claves en una lista
  
    public void InOrder(Node node, List<int> resultado)
    {
        if (node == null) return;
        InOrder(node.Left, resultado);
        resultado.Add(node.Data);
        InOrder(node.Right, resultado);
    }

    // Verifica que cada elemento sea estrictamente mayor que el anterior
    public bool EsEstrictamenteAscendente(List<int> lista)
    {
        for (int i = 1; i < lista.Count; i++)
        {
            if (lista[i] <= lista[i - 1])
                return false;
        }
        return true;
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

        List<int> inorden = new List<int>();
        arbol.InOrder(arbol.Root, inorden);

        Console.WriteLine("Inorden: " + string.Join(" ", inorden));
        Console.WriteLine("¿Estrictamente ascendente? " + arbol.EsEstrictamenteAscendente(inorden));
    }
}
