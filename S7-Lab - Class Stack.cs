using System;

class Stack
{
    private int[] stack = new int[1]; // fixed size
    private int sp = 0;

    public void Push(int v) // push has to track the length
    {
        if (sp >= stack.Length)
        {
            // double the size
            int[] newstack = new int[stack.Length*2];

            stack.CopyTo(newstack, 0);

            stack = newstack;
        }
        //stack[sp++] = v;
        stack[sp] = v;
        sp = sp + 1;
    }

    public int Pop()
    {
        //return stack[--sp];
        sp = sp - 1;
        return stack[sp];
    }

    public int Top
    {
        get
        {
            return stack[sp - 1];
        }
    }

    public bool IsEmpty
    {
        get
        {
            return sp == 0;
            //if(sp == 0)
            //{ return true; }
            //else
            //{ return false; }
        }
        
    }
}

class Arrays_Stacks
{
    static void Main()
    {
        var stack = new Stack();

        stack.Push(5);
        stack.Push(3);
        stack.Push(2);
        stack.Push(9);

        Console.WriteLine("The last value pushed was {0}", stack.Top);

        while (!stack.IsEmpty)
        {
            Console.WriteLine("Popping {0}", stack.Pop());
        }

        Console.Write("Press Enter...");
        Console.ReadLine();
    }
}