using System;

namespace ConsoleEventCallApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Front front = new Front();
            front.Run();

            Console.WriteLine("キー押下で終了します。");
            Console.ReadKey();
        }
    }
}
