// File: property_ex2.cs
// Write an integer stack class 
using System;

class Stack
{
    private int[] stack = new int[10];
    private int sp = 0;

    public void Push(int v)
    {
        stack[sp++] = v;
    }

    public int Top
    {
        get
        {
            return stack[sp-1];
        }
    }

    public bool IsEmpty
    {
        get
        {
            return sp == 0;
        }
    }

    public int Pop()
    {
        return stack[--sp];
    }
}

class pex2
{
    public static void Main()
    {
        Stack stack = new Stack();

        stack.Push(5);
        stack.Push(10);
        stack.Push(15);
                    
        Console.WriteLine("The last value pushed was {0}", stack.Top);
        
        while (!stack.IsEmpty)
        {
            Console.WriteLine("Popping value {0}", stack.Pop());
        }
    }
}
