﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onomancy
{
    /// <summary>
    /// 姓クラス
    /// </summary>
    public class FamilyName : NameBase
    {
        /// <summary>
        /// 姓をコンソール画面から取得する
        /// </summary>
        public override void put()
        {
            Console.WriteLine("姓を入力して下さい。");

            this.Value = Console.ReadLine();

            //Console.WriteLine("入力した姓は「{0}」です。", this.Value);

            // 画数の取得
            base.GetStroke();

            //人格の取得
            this.FumanStroke = this.Characters[this.Characters.Count - 1].Stroke;

            //外格の取得
            if (this.SupportStroke == 1)
            {
                this.OutsideStroke = 1;
            }
            else
            {
                this.OutsideStroke = this.Characters[0].Stroke;
            }
        }
    }
}
