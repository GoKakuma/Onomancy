using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onomancy
{
    public class FullName
    {
        private Fortune totalFortune = new Fortune("総格");
        private Fortune fumanFortune = new Fortune("人格");
        private Fortune outsideFortune = new Fortune("外格");
        private Fortune familyFortune = new Fortune("天格");
        private Fortune firstFortune = new Fortune("地格");
        private FamilyName family = new FamilyName();
        private FirstName first = new FirstName();

        public void DivinationYourName()
        {
            family.put();
            first.put();

            Console.Write("\r\n\r\n判定中");

            for (int i = 0; i < 3; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Write("・");
            }
            Console.Write("\r\n\r\n");

            Console.Write("{0}　{1}さんの判定結果は\r\n\r\n", family.Value, first.Value);

            // 総格
            totalFortune.Stroke = family.TotalStroke + first.TotalStroke;
            totalFortune.Show();
            //Console.WriteLine("総格{0}", totalStroke);

            // 人格
            fumanFortune.Stroke = family.FumanStroke + first.FumanStroke;
            fumanFortune.Show();
            //Console.WriteLine("人格{0}", fumanStroke);

            // 外格
            outsideFortune.Stroke = family.OutsideStroke + first.OutsideStroke;
            outsideFortune.Show();
            //Console.WriteLine("外格{0}", ousideStroke);

            // 天格
            familyFortune.Stroke = family.TotalStroke;
            familyFortune.Show();
            //Console.WriteLine("天格{0}", family.TotalStroke);

            // 地格
            firstFortune.Stroke = first.TotalStroke;
            firstFortune.Show();
            //Console.WriteLine("地格{0}", first.TotalStroke);
        }

    }
}
