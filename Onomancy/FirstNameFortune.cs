using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onomancy
{
    /// <summary>
    /// 地格クラス
    /// </summary>
    public class FirstNameFortune : FortuneBase, IDisplay
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="fotuneName">格名</param>
        /// <param name="names">姓名</param>
        public FirstNameFortune(string fotuneName, List<NameBase> names) : base(fotuneName) 
        {
            CalculateStroke(names);
        }

        /// <summary>
        /// 格数を算出する
        /// </summary>
        /// <param name="names">姓名</param>
        protected override void CalculateStroke(List<NameBase> names)
        {
            this.Stroke = names[1].TotalStroke;
        }

        /// <summary>
        /// 画面表示
        /// </summary>
        /// <param name="names">姓名</param>
        public void Display(List<NameBase> names)
        {
            for (int i = 0; i < names[0].Value.Length + names[1].Value.Length + 1; i++)
            {
                if (i == names[0].Value.Length + 1)
                {
                    if (names[1].Value.Length == 1)
                    {
                        Console.Write("│");
                    }
                    else
                    {
                        Console.Write("└");
                    }

                }
                else if (i==names[0].Value.Length + names[1].Value.Length)
                {
                    Console.Write("┘");
                }
                else if (i > names[0].Value.Length + 1 && i < names[0].Value.Length + names[1].Value.Length)
                {
                    Console.Write("─");
                }
                else
                {
                    Console.Write("　");
                }
            }

            Console.Write("　　");
            base.Show();
        }

    }
}
