using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Onomancy
{
    /// <summary>
    /// CSVテーブルクラス
    /// </summary>
    public class CSVTable
    {
        /// <summary>
        /// データ
        /// </summary>
        public List<List<String>> values = new List<List<String>>();

        /// <summary>
        /// テーブルを読み込む
        /// </summary>
        /// <param name="tableName">テーブル名</param>
        public CSVTable(string tableName)
        {
            StreamReader reader;
            string readLine;

            try
            {
                reader = new StreamReader(tableName, Encoding.GetEncoding("Shift_JIS"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("テーブルオープンエラー:{0}", tableName);
                throw new Exception("テーブルオープンエラー");
            }

            try
            {
                while ((readLine = reader.ReadLine()) != null)
                {
                    string[] array;

                    //カンマで分ける
                    array = readLine.Split(',');

                    //リストに追加
                    List<string> value = new List<string>(array);
                    values.Add(value);

                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (reader != null) { reader.Close(); }
            }

        }

    }
}
