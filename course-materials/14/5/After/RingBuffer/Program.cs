using System;

namespace RingBuffer
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerRingBuffer ringBuffer = new IntegerRingBuffer(5);
            int counter = 0;
            while (counter < 20)
            {
                counter++;
                ringBuffer.Write(counter);
                Console.WriteLine(ringBuffer);
            }
            Console.WriteLine();
            while (!ringBuffer.IsEmpty)
            {
                int? oldestElementInTheBuffer = ringBuffer.Read();
                Console.WriteLine($"First integer inserted in - {oldestElementInTheBuffer} - dequeued");
                Console.WriteLine(ringBuffer);
            }
        }
    }
}
