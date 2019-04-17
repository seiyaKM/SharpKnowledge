using System;

namespace ConsoleCalcApp
{
    internal class CalcProcessForDelegateOne : ICalc
    {
        /// <summary>
        /// デリゲート型を定義
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public delegate int CalculateDelegateOne(int x, int y);

        public void CalcStart()
        {
            var calculate = new CalculateMethodOne();
            int x = 10;
            int y = 20;

            // Addメソッドをデリゲートに代入
            var calc = new CalculateDelegateOne(calculate.Add);
            Console.WriteLine("{0} + {1} = {2}", x, y, calc(x, y));

            // Subメソッドをデリゲートに代入
            calc = new CalculateDelegateOne(calculate.Sub);
            Console.WriteLine("{0} - {1} = {2}", x, y, calc(x, y));
        }
    }

    internal class CalculateMethodOne
    {
        /// <summary>
        /// デリゲートに代入するためのメソッド（足し算）
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Add(int x, int y)
        {
            Console.WriteLine("Add処理が呼び出されました。");
            return x + y;
        }

        /// <summary>
        /// デリゲートに代入するためのメソッド（引き算）
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Sub(int x, int y)
        {
            Console.WriteLine("Sub処理が呼び出されました。");
            return x - y;
        }
    }
}
