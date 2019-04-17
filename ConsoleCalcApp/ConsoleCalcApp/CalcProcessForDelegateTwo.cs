using System;

namespace ConsoleCalcApp
{
    internal class CalcProcessForDelegateTwo : ICalc
    {
        public delegate void CalculateDelegateTwo(int x, int y);

        public void CalcStart()
        {            
            var calculate = new CalculateMethodTwo();

            CalculateDelegateTwo calc = calculate.Add;
            calc += calculate.Sub;

            calc(30, 50);
        }
    }

    internal class CalculateMethodTwo
    {
        /// <summary>
        /// デリゲートに代入すたためのメソッド（足し算）
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public void Add(int x, int y)
        {
            Console.WriteLine("Add処理が呼び出されました。");
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }

        /// <summary>
        /// デリゲートに代入するためのメソッド（引き算）
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public void Sub(int x, int y)
        {
            Console.WriteLine("Sub処理が呼び出されました。");
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        }
    }
}
