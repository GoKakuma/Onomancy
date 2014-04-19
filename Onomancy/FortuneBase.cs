using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onomancy
{
    /// <summary>
    /// 運勢（格）の基底クラス
    /// </summary>
    public abstract class FortuneBase
    {
         /// <summary>
        /// 運勢テーブル
        /// </summary>
        private static CSVTable OnomancyTable = new CSVTable("Fortune.tbl");

        /// <summary>
        /// 格名
        /// </summary>
        private string name;

        /// <summary>
        /// 画数
        /// </summary>
        private int stroke;

        /// <summary>
        /// 運勢記号
        /// </summary>
        private string onomancyMark;

        /// <summary>
        /// 画数プロパティ
        /// </summary>
        public int Stroke
        {
            set
            {
                this.stroke = value;
                GetFortune();
            }
            get
            {
                return this.stroke;
            }
        }
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">格名</param>
        public FortuneBase(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 運勢を取得する
        /// </summary>
        protected void GetFortune()
        {
            foreach (List<string> value in OnomancyTable.values)
            {
                if (stroke == Int32.Parse(value[0]))
                {
                    onomancyMark = value[1];
                    continue;
                }
            }
        }

        /// <summary>
        /// 画数と運勢を画面表示する
        /// </summary>
        public void Show()
        {
            Console.WriteLine("{0}　　画数　{1,2}　運勢　{2}", name, stroke, onomancyMark);
        }

        /// <summary>
        /// 格数を算出する
        /// </summary>
        /// <param name="names">姓名</param>
        protected abstract void CalculateStroke(List<NameBase> names);

    }
}
