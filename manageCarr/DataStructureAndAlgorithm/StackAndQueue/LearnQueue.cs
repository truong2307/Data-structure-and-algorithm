using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.DataStructureAndAlgorithm.StackAndQueue
{
    public static class LearnQueue
    {
        private const int MaxValue = 50;
        public class Queue
        {
            public int[] Value { get; set; } = new int[MaxValue];   
            public int Rear { get; set; } = -1;
            public int Front { get; set; } = -1;
        }

        public static void Enqueue(this Queue queue, int value)
        {
            queue.Value[++queue.Rear] = value;

            if(queue.Front == -1)
            {
                queue.Front++;
                queue.Front = queue.Rear;
            }
        }

        public static int Dequeue(this Queue queue)
        {
            return queue.Value[queue.Front++];
        }

        public static void DisplayQueue(this Queue queue)
        {
            for (int i = queue.Front; i <= queue.Rear; i++)
            {
                Console.Write(queue.Value[i] + " ");
            }
        }
    }
}
