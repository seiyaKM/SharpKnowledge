using System;

namespace ConsoleCalcApp
{
    internal class CalcProcessForLambda : ICalc
    {
        public void CalcStart()
        {
            // =>の左側がパラメータ、右側が式
            Func<int, int> function = x => x * x;

            // パラメータが複数ある場合は()の中に指定する
            Func<int, int, int> calc2 = (x, y) => x + y;

            // 複数のステートメントになる場合はステートメントブロックを使用して
            // メソッドと同様にreturn分で戻り値を指定する
            Func<int, int, int> calc3 = (x, y) =>
            {
                int result = x - y;
                return result;
            };

            Console.WriteLine("処理結果：{0}", function(20));

            Console.WriteLine("処理結果：{0}", calc2(20, 20));

            Console.WriteLine("処理結果：{0}", calc3(20, 25));
        }
    }
}
