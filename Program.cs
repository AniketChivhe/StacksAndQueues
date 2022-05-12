using System;

namespace UC2_StackPopAndPeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UC_2 Stack Pop And Peak");
            PopAndPeak list = new PopAndPeak();
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();

            //Using For loop for delete all entry
            for (int i = 0; i < 3; i++)
            {
                list.Peak();
                list.Pop();
                list.Display();
            }

            Console.ReadKey();

        }
    }
}
