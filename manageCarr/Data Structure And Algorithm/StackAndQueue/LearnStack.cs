using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.Data_Structure_And_Algorithm.StackAndQueue
{
    public static class LearnStack 
    {
        private const int MaxValue = 50;
        public class Stack
        {
            public int[] Value { get; set; } = new int[MaxValue];
            public int Top { get; set; } = -1;
        }

        public static void Push(this Stack stack, int value)
        {
            //another way
            // stack.Value[stack.Top] = value;
            //stack.Top++;

            stack.Value[++stack.Top] = value;
        }

        public static int Pop(this Stack stack)
        {
            //another way
            // int value = stack.Value[stack.Top];
            // stack.Top--; return value;

            return stack.Value[stack.Top--];
        }

        public static bool IsEmpty(this Stack stack)
        {
            return stack.Top < 0;
        }

        public static bool IsFull(this Stack stack)
        {
            return stack.Top == MaxValue;
        }

        public static void DisplayStack(this Stack stack)
        {
            for (int i = 0; i <= stack.Top; i++)
            {
                Console.Write(stack.Value[i]+" ");
            }
        }
    }
}