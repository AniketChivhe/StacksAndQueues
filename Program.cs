using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UC_1 Adding Numbers in stacks");
            Stack list = new Stack();
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();
            
            Console.ReadKey();

        }
    }
}
