// File: property_ex4.cs
// Grow the array in the Push function.
using System;

class Stack
{
    private int[] stack = new int[10];
    private int sp = 0;
    
    public void Push(int v)
    {
        stack[sp++] = v;
		
		if (sp >= stack.Length)
        {

            int x = stack.Length + 1;
            int[] newstack = new int[x];

            //existingArray.CopyTo(newArray,0);
            stack.CopyTo(newstack, 0);

            // now stack points to the newstack
            stack = newstack;
        }
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
