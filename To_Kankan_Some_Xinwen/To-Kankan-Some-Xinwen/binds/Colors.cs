using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Kankan_Some_Xinwen
{
    class Colors
    {
        //上一个颜色
        private static int last_color = 0;

        //获得随机颜色
        public static System.Drawing.Color get_color()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            int ran_num = random.Next(1, 10);
            while(ran_num == last_color)
                ran_num = random.Next(1, 10);
            last_color = ran_num;
            switch (ran_num)
            {
                case 1: return System.Drawing.Color.OrangeRed;
                case 2: return System.Drawing.Color.DarkGray;
                case 3: return System.Drawing.Color.Green;
                case 4: return System.Drawing.Color.SkyBlue;
                case 5: return System.Drawing.Color.DodgerBlue;
                case 6: return System.Drawing.Color.Fuchsia;
                case 7: return System.Drawing.Color.Purple;
                case 8: return System.Drawing.Color.Pink;
                case 9: return System.Drawing.Color.Cyan;
                case 10: return System.Drawing.Color.Violet;
                default:return System.Drawing.Color.Yellow;

            }
        }
    }
}
