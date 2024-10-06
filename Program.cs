using System;

class Node
{
    public int Data;
    public Node Left, Right;

    public Node(int item)
    {
        Data = item;
        Left = Right = null;
    }
}

class BinarySearchTree
{
    public Node Root;

    public BinarySearchTree()
    {
        Root = null;
    }

    // Método para insertar un nuevo nodo en el árbol
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    // Función recursiva para insertar un nuevo nodo
    private Node InsertRec(Node root, int data)
    {
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    // Método para imprimir el árbol en orden
    public void InOrder()
    {
        InOrderRec(Root);
    }

    private void InOrderRec(Node root)
    {
        if (root != null)
        {
            InOrderRec(root.Left);
            Console.Write(root.Data + " ");
            InOrderRec(root.Right);
        }
    }
}

class Program
{
    static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();

        int[] nodes = { 30, 15, 50, 10, 20, 40, 60 };

        foreach (var node in nodes)
        {
            bst.Insert(node);
        }

        Console.WriteLine("Árbol Binario de Búsqueda (In-Order):");
        bst.InOrder();
    }
}
