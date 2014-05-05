using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onomancy
{
    /// <summary>
    /// 姓名判断クラス
    /// </summary>
    public class Divination
    {
        /// <summary>
        /// 姓名判断する
        /// </summary>
        public void DivinationName()
        {
            FamilyName family = new FamilyName();
            FirstName first = new FirstName();
            family.put();
            first.put();

            Console.Write("\r\n\r\n判定中");

            for (int i = 0; i < 3; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Write("・");
            }
            Console.Write("\r\n\r\n");

            Console.Write("{0}　{1}さんの判定結果\r\n", family.Value, first.Value);

            var names = new List<NameBase>();
            names.Add(family);
            names.Add(first);

            TotalNameFortune totalNameFortune = new TotalNameFortune("総格", names);
            HumanNameFortune humanNameFortune = new HumanNameFortune("人格", names);
            OutsideNameFortune outsideNameFortune = new OutsideNameFortune("外格", names);
            FirstNameFortune firstNameFortune = new FirstNameFortune("地格", names);
            FamlyNameFortune familyNameFortune = new FamlyNameFortune("天格", names);

            var displays = new List<IDisplay>();
            displays.Add(humanNameFortune);
            displays.Add(outsideNameFortune);
            displays.Add(firstNameFortune);
            displays.Add(familyNameFortune);
            displays.Add(totalNameFortune);
            foreach (var d in displays)
            {
                d.Display(names);
            }

        }

    }
}
