using System;

namespace ConsoleCalcApp
{
    internal class CalcProcessForAnonymous : ICalc
    {
        public delegate int CalculateDelegateFour(int x, int y);

        public void CalcStart()
        {
            // 匿名メソッド
            CalculateDelegateFour calc = delegate (int x, int y)
            {
                Console.WriteLine("匿名処理が実行されました。");
                Console.WriteLine("{0} + {1}", x, y);
                return x + y;
            };
            Write(calc);
        }

        public void Write(CalculateDelegateFour calc)
        {
            Console.WriteLine("Write処理が呼び出されました。");
            Console.WriteLine("処理結果：{0}", calc(80, 120));
        }
    }
}
