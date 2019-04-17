using System;

namespace ConsoleCalcApp
{
    internal class CalcProcessForDelegateThree : ICalc
    {
        public void CalcStart()
        {
            var calculate = new CalculateMethodThree();

            // 戻り値のないメソッドをActionデリゲートで定義
            Action<int> write = calculate.Write;

            // 戻り値のあるメソッドをFuncデリゲートで定義
            Func<int, int, int> c1 = calculate.Add;

            write(c1(60, 100));
        }
    }

    internal class CalculateMethodThree
    {
        public int Add(int x, int y)
        {
            Console.WriteLine("Add処理が呼び出されました。");
            Console.WriteLine("{0} + {1}", x, y, x + y);
            return x + y;
        }

        public void Write(int s)
        {
            Console.WriteLine("Write処理が呼び出されました。");
            Console.WriteLine("処理結果：{0}", s);
        }
    }
}
