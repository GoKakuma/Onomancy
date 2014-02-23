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
            Console.WriteLine("総格－　");
            Console.WriteLine("人格－　");
            Console.WriteLine("外格－　");
            Console.WriteLine("天格－　");
            Console.WriteLine("地格－　\r\n\r\n");

            while (true)
            {
                FullName name = new FullName();
                name.DivinationYourName();

                Console.WriteLine("\r\n\r\nもう一度、姓名占いを行いますか？");
                Console.WriteLine("yes or no");
                if (Console.ReadLine() != "yes")
                {
                    break;
                }

                Console.WriteLine("\r\n");
            }

            Console.WriteLine("\r\n\r\n姓名判断プログラム　終了");
        }
    }
}
