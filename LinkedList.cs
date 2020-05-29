using System;

public class Node
{
    public int _data;
    public Node Next;

    public Node(int val)
    {
        _data = val;
        Next = null;
    }

    public void PrintNode()
    {
        Console.Write(_data);
        if (Next != null)
        {
            Console.Write(" => ");
            Next.PrintNode();
        }
        else
        {
            Console.WriteLine("\n ");
        }
    }

    public void AddToListSequentially(int val)
    {
        if (Next == null)
        {
            Next = new Node(val);
        }
        else
        {
            Next.AddToListSequentially(val);
        }
    }
}

////////////////////////////////////////////////////////////////////
public class CustomLinkedList
{
    public Node HeadNode;

    public CustomLinkedList()
    {
        HeadNode = null;
    }

    public void AddToCustomLinkedListSequentially(int val)
    {
        if (HeadNode != null)
        {
            HeadNode.AddToListSequentially(val);
        }
        else
        {
            HeadNode = new Node(val);
        }
    }

    public void AddToCustomLinkedListInBeginning(int val)
    {
        if (HeadNode == null)
        {
            HeadNode = new Node(val);
        }
        else
        {
            Node temp = new Node(val);
            temp.Next = HeadNode;
            HeadNode = temp;
        }
    }

    public void DeleteFromCustomLinkedListFromBeginning()
    {
        if (HeadNode == null)
        {
            Console.WriteLine("First add elements to custom linked list \n");
        }
        else
        {
            Node temp = HeadNode.Next;
            HeadNode = temp;
        }
    }

    public void DeleteFromCustomLinkedListAtLast()
    {
        Node prevNode = null, currentNode = HeadNode;
        if (HeadNode == null)
        {
            Console.WriteLine("First please add elements to custom linked list \n");
            return;
        }

        while (currentNode.Next != null)
        {
            prevNode = currentNode;
            currentNode = currentNode.Next;
        }

        if (currentNode.Next == null)
        {
            prevNode.Next = null;
        }

    }

    public void PrintNodes()
    {
        if (HeadNode != null)
        {
            HeadNode.PrintNode();
        }
    }

}

/////////////////////////////////////////////////////////////
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World");
        CustomLinkedList linkedList = new CustomLinkedList();

        //linkedList.DeleteFromCustomLinkedListFromBeginning();
        linkedList.AddToCustomLinkedListSequentially(2);
        linkedList.AddToCustomLinkedListSequentially(3);
        linkedList.AddToCustomLinkedListSequentially(5);
        Console.WriteLine("Printing Nodes after adding 2, 3 and 5");
        linkedList.PrintNodes();

        linkedList.AddToCustomLinkedListInBeginning(1);
        Console.WriteLine("Printing Nodes after adding 1 in beginning");
        linkedList.PrintNodes();

        linkedList.DeleteFromCustomLinkedListFromBeginning();
        Console.WriteLine("Printing Nodes after deleting node from beginning");
        linkedList.PrintNodes();

        linkedList.DeleteFromCustomLinkedListAtLast();
        Console.WriteLine("Printing Nodes after deleting node from last");
        linkedList.PrintNodes();
    }
}
