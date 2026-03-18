using System;

class StackUndo
{
    private string[] stack;
    private int top;

    public StackUndo(int size)
    {
        stack = new string[size];
        top = -1;
    }

    // Push operation (Add action)
    public void Push(string action)
    {
        if (top == stack.Length - 1)
        {
            Console.WriteLine("Stack Overflow! Cannot add more actions.");
            return;
        }

        stack[++top] = action;
        Console.WriteLine($"Action Added: {action}");
        Display();
    }

    // Pop operation (Undo action)
    public void Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow! No actions to undo.");
            return;
        }

        Console.WriteLine($"Undo Action: {stack[top]}");
        top--;
        Display();
    }

    // Display current state
    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Current State: Empty\n");
            return;
        }

        Console.Write("Current State: ");
        for (int i = 0; i <= top; i++)
        {
            Console.Write(stack[i]);
            if (i != top) Console.Write(" -> ");
        }
        Console.WriteLine("\n");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        StackUndo editor = new StackUndo(10);

        // Sample operations
        editor.Push("Type A");
        editor.Push("Type B");
        editor.Push("Type C");

        editor.Pop(); // Undo
        editor.Pop(); // Undo

        Console.WriteLine("Final State After Operations:");
        editor.Display();
    }
}