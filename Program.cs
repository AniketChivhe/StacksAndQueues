using System;

namespace UC3_UC4_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UC3 And UC4 - Queue ");
            Queue list = new Queue();
            list.Enqueue(56);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Display();

            for (int i = 0; i < 3; i++)
            {
                list.Dequeue();
                list.Display();
            }
            list.Display();// this.top=this.top.next
            Console.ReadKey();

        }
    }
}