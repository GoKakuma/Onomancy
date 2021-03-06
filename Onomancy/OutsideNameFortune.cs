﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onomancy
{
    /// <summary>
    /// 外格クラス
    /// </summary>
    public class OutsideNameFortune : FortuneBase, IDisplay
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="fotuneName">格名</param>
        /// <param name="names">姓名</param>
        public OutsideNameFortune(string fotuneName, List<NameBase> names) : base(fotuneName) 
        {
            CalculateStroke(names);
        }

        /// <summary>
        /// 格数を算出する
        /// </summary>
        /// <param name="names">姓名</param>
        protected override void CalculateStroke(List<NameBase> names)
        {
            this.Stroke = names[0].OutsideStroke + names[1].OutsideStroke;
        }

        /// <summary>
        /// 画面表示
        /// </summary>
        /// <param name="names">姓名</param>
        public void Display(List<NameBase> names)
        {
            for (int i = 0; i < names[0].Value.Length + names[1].Value.Length + 1; i++)
            {
                if (i == 0)
                {
                    Console.Write("└");
                }
                else if (i == names[0].Value.Length + names[1].Value.Length)
                {
                    Console.Write("┘");
                }
                else
                {
                    Console.Write("─");
                }
            }

            Console.Write("　　");
            base.Show();
        }

    }
}

