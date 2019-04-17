using System;
using System.Collections.Generic;

namespace ConsoleCalcApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ICalc> calcList = new List<ICalc>();
            calcList.Add(new CalcProcessForDelegateOne());
            calcList.Add(new CalcProcessForDelegateTwo());
            calcList.Add(new CalcProcessForDelegateThree());
            calcList.Add(new CalcProcessForAnonymous());
            calcList.Add(new CalcProcessForLambda());

            foreach (var item in calcList)
            {
                Console.WriteLine("----------{0}の処理開始-----------", item.ToString());

                item.CalcStart();

                Console.WriteLine("----------{0}の処理終了----------", item.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("何か押したらキーを押したら終了します。");
            Console.ReadLine();
        }
    }
}
