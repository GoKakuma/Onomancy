using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onomancy
{

    /// <summary>
    /// 名前の基底クラス
    /// </summary>
    abstract public class NameBase
    {
        /// <summary>
        /// 画数テーブル
        /// </summary>
        private static CSVTable Stroketable = new CSVTable("Stroke.tbl");

        /// <summary>
        /// 名前
        /// </summary>
        private string value;

        /// <summary>
        /// 文字画数リスト
        /// </summary>
        private List<Character> characters = new List<Character>();

        /// <summary>
        /// 総格
        /// </summary>
        private int totalStroke;

        /// <summary>
        /// 補助格
        /// </summary>
        private int supportStroke;

        /// <summary>
        /// 人格
        /// </summary>
        private int humanStroke;

        /// <summary>
        /// 外格
        /// </summary>
        private int outsideStroke;

        /// <summary>
        /// 名前プロパティ
        /// </summary>
        public string Value
        {
            set
            {
                this.value = value;
                this.MakeCharacters();
            }
            get
            {
                return this.value;
            }

        }

        /// <summary>
        /// 文字リストプロパティ
        /// </summary>
        public List<Character> Characters
        {
            set
            {
                this.characters = value;
            }
            get
            {
                return this.characters;
            }
        }

        /// <summary>
        /// 総格プロパティ
        /// </summary>
        public int TotalStroke
        {
            set
            {
                this.totalStroke = value;
            }
            get
            {
                return this.totalStroke;
            }

        }

        /// <summary>
        /// 補助格プロパティ
        /// </summary>
        public int SupportStroke
        {
            set
            {
                this.supportStroke = value;
            }
            get
            {
                return this.supportStroke;
            }
        }

        /// <summary>
        /// 人格プロパティ
        /// </summary>
        public int HumanStroke
        {
            set
            {
                this.humanStroke = value;
            }
            get
            {
                return this.humanStroke;
            }

        }

        /// <summary>
        /// 外格プロパティ
        /// </summary>
        public int OutsideStroke
        {
            set
            {
                this.outsideStroke = value;
            }
            get
            {
                return this.outsideStroke;
            }
        }

        /// <summary>
        /// コンソール画面から文字列を取得する
        /// </summary>
        public abstract void put();

        /// <summary>
        /// 画数を取得する
        /// </summary>
        protected void GetStroke()
        {
            foreach (Character character in characters)
            {
                foreach (List<string> value in Stroketable.values)
                {
                    if (character.Data.ToString() == value[0])
                    {
                        totalStroke += character.Stroke = Int32.Parse(value[1]);
                        continue;
                    }
                }
            }

            if (this.value.Length == 1)
            {
                this.supportStroke = 1;
            }

        }

        /// <summary>
        /// 文字リスト作成
        /// １文字ずつ分解する。
        /// </summary>
        private void MakeCharacters()
        {
            foreach (char c in value)
            {
                Character character = new Character();

                character.Data = c;

                this.characters.Add(character);
            }
        }
    }
}
