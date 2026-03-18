using System;

// Node class
class Node
{
    public int empId;
    public string name;
    public Node next;

    public Node(int id, string name)
    {
        this.empId = id;
        this.name = name;
        this.next = null;
    }
}

// Linked List class
class EmployeeLinkedList
{
    private Node head;

    // Insert at Beginning
    public void InsertAtBeginning(int id, string name)
    {
        Node newNode = new Node(id, name);
        newNode.next = head;
        head = newNode;
    }

    // Insert at End
    public void InsertAtEnd(int id, string name)
    {
        Node newNode = new Node(id, name);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }

        temp.next = newNode;
    }

    // Delete by Employee ID
    public void Delete(int id)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        // If head node is to be deleted
        if (head.empId == id)
        {
            head = head.next;
            return;
        }

        Node temp = head;

        while (temp.next != null && temp.next.empId != id)
        {
            temp = temp.next;
        }

        if (temp.next == null)
        {
            Console.WriteLine("Employee not found.");
        }
        else
        {
            temp.next = temp.next.next;
        }
    }

    // Display list
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.empId} - {temp.name}");
            temp = temp.next;
        }
    }
}

// Main Program
class Program
{
    public static void Main(string[] args)
    {
        EmployeeLinkedList list = new EmployeeLinkedList();

        // Insert sample data
        list.InsertAtEnd(101, "John");
        list.InsertAtEnd(102, "Sara");
        list.InsertAtEnd(103, "Mike");

        // Delete employee with ID 102
        list.Delete(102);

        // Display list
        Console.WriteLine("Employee List After Deletion:");
        list.Display();
    }
}