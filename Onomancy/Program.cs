using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onomancy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("姓名判断プログラム　開始\r\n");
            DisplayHelp();

            while (true)
            {
                Divination name = new Divination();
                name.DivinationName();

                Console.WriteLine("\r\n\r\nもう一度、姓名判断を行いますか？");
                Console.WriteLine("yes or no(yes以外は終了)");
                if (Console.ReadLine() != "yes")
                {
                    break;
                }

                Console.WriteLine("\r\n");
            }

            Console.WriteLine("\r\n\r\n姓名判断プログラム　終了");
        }

        private static void DisplayHelp()
        {
            Console.WriteLine("説明");
            Console.WriteLine("人の姓名の字の画数から5つの格数を算出し、それらに与えられた伝統的・経験的な解釈に基づいて解釈を行う。");
            Console.WriteLine("・総格－姓名の総画数。霊数は数えない。人生を歩むにつれて色濃くでてくるといわれ、晩年の運勢に大きく影響する。");
            Console.WriteLine("・人格－姓の最後と名の最初の一字を足した画数。人物の内面をあらわし、家庭・仕事・結婚運、中年期の運勢に影響を与える。");
            Console.WriteLine("・外格－総格から人格を引いた画数。一字姓、一字名には霊数を加える。家族や職場などの外因的要素、対人関係・社会的環境一般の運勢。");
            Console.WriteLine("・地格－名の画数の合計。霊数は加えない。幼年期の運勢をあらわし、人物の成長過程に強い影響を与えるため、性格、才能、金運、適職、性的傾向に関与する。");
            Console.WriteLine("・天格－姓の総画数。霊数は加えない。祖先運。一般的に晩年になるほど影響力を強めるとされる。");
            Console.WriteLine("※霊数とは－一字姓・一字名の場合に足す数。本来、姓名判断では二文字以上の姓名を前提として鑑定方法が確立されているの、一文字の姓名においては人格・地格・外格の鑑定の際、仮数として1を加えて鑑定する。");
            Console.WriteLine("");
            Console.WriteLine("続行するには何かキーを押してください . . .");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("運勢について・・・以下の４種類で表す。");
            Console.WriteLine("　◎＝大吉");
            Console.WriteLine("　○＝小吉");
            Console.WriteLine("　△＝吉");
            Console.WriteLine("　×＝凶");
            Console.WriteLine("");
            Console.WriteLine("続行するには何かキーを押してください . . .");
            Console.ReadKey();
            Console.WriteLine("");

        }
    }
}
