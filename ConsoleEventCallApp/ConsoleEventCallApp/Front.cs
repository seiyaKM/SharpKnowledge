using System;

namespace ConsoleEventCallApp
{
    internal class Front
    {
        private PersonLogic logic = null;

        public PersonInfo Person { get; private set; }

        public event Func<PersonInfo, string> Message;

        public void Run()
        {
            logic = new PersonLogic(this);

            Communication();
        }

        private void Communication()
        {
            string confirmation = string.Empty;
            do
            {
                Person = new PersonInfo();

                Console.WriteLine("Q.あなたの名前を入力して下さい。");

                Person.Name = Console.ReadLine();
                
                Console.WriteLine("\nQ.女性のタイプを入力して下さい。");
                Console.WriteLine("A：清楚系／B：妹系／C：お姉さん系／D：ギャル系");

                Person.GirlType = Console.ReadLine();

                Console.WriteLine("\n入力内容は以下の通りで間違いないですか?");
                Console.WriteLine("名前：{0}", Person.Name);
                Console.WriteLine("タイプ：{0}", Person.GirlType);
                Console.WriteLine();
                Console.WriteLine("Y/N");
                Console.WriteLine();

                confirmation = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(confirmation) || !confirmation.Equals("Y"));

            string message = string.Empty;
            if(Message != null)
            {
                message = Message(Person);
            }
            Console.WriteLine(message);            
        }

    }
}
