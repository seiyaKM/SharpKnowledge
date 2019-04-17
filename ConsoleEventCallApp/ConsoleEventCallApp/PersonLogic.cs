using System.Collections.Generic;

namespace ConsoleEventCallApp
{
    internal class PersonLogic
    {
        private Front front = null;

        private static readonly Dictionary<string, string> GirlTypeDic = new Dictionary<string, string>()
        {
            {"A","清楚系" },
            {"B","妹系" },
            {"C","お姉さん系" },
            {"D","ギャル系" },
        };

        public PersonLogic(Front front)
        {
            this.front = front;
            this.front.Message += Front_Message;
        }

        private string Front_Message(PersonInfo arg)
        {
            string result = string.Empty;

            if(arg == null)
            {
                result = "ERROR 最初から入力して下さい。";
            }
            else
            {
                string type = string.Empty;
                if (GirlTypeDic.ContainsKey(arg.GirlType))
                {
                    type = GirlTypeDic[arg.GirlType];
                    result = string.Format("{0}さんは{1}女子が好みなんですね（・∀・）ﾆﾔﾆﾔ", arg.Name, type);
                }
                else
                {
                    result = "該当するタイプが存在しません。（貴方の性癖は特殊です）";
                }
            }

            return result;
        }
    }
}
