// File: memberobject_ex1.cs
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

class RPN
{
    private Stack stack = new Stack();
    
    public void Process(string str)
    {
        switch (str)
        {
            case "+":
            {
                int v2 = stack.Pop();
                int v1 = stack.Pop();

                stack.Push(v1 + v2);
                break;
            }
            case "-":
            {
                int v2 = stack.Pop();
                int v1 = stack.Pop();

                stack.Push(v1 - v2);
                break;
            }
            default:
            {
                int v1  = int.Parse(str);
                stack.Push(v1);
                break;
            }
        }
    }

    public int Result
    {
        get
        {
            return stack.Top;
        }
    }
}

class ex17
{
    public static void Main()
    {
        RPN rpn = new RPN();
        
        while (true)
        {
            string str;
            
            Console.Write("RPN>");
            str = Console.ReadLine();
            
            rpn.Process(str);
            
            Console.WriteLine("={0}", rpn.Result);
        }
    }
}    