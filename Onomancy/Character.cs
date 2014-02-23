using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onomancy
{
    /// <summary>
    /// 文字クラス
    /// </summary>
    public class Character
    {
        /// <summary>
        /// 文字データ
        /// </summary>
        private char data;

        /// <summary>
        /// 画数
        /// </summary>
        private int stroke;

        /// <summary>
        /// 文字データプロパティ
        /// </summary>
        public char Data
        {
            set
            {
                this.data = value;
            }
            get
            {
                return this.data;
            }
        }

        /// <summary>
        /// 画数プロパティ
        /// </summary>
        public int Stroke
        {
            set
            {
                this.stroke = value;
            }
            get
            {
                return this.stroke;
            }
        }

    }
}
