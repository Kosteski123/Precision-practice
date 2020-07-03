using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    public class Circles
    {  
        //public Point SecondCenter { get; set; }
        public Point Center { get; set; }
        public Color ColorInner;
        public Color ColorOutter;
        public Random r;
        public static int radius = 40;
        public Circles(Point center)
        {
            r = new Random();
            Center = center;
            ColorInner = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));//random color
            ColorOutter = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        public void Draw(Graphics g) {
            Brush b1 = new SolidBrush(ColorOutter); 
            Brush b2 = new SolidBrush(ColorInner);
            Brush b3 = new SolidBrush(Color.Black);
            g.FillEllipse(b1, Center.X - radius, Center.Y - radius, 2 * radius, 2 * radius);//outter
            g.FillEllipse(b3, Center.X - radius + 8, Center.Y - radius + 8, (2 * radius) - 16, (2 * radius) - 16);//separator
            g.FillEllipse(b2, Center.X - radius+10, Center.Y - radius+10, (2 * radius) - 20, (2 * radius) -20);//inner
            b1.Dispose();
            b2.Dispose();
            b3.Dispose();
        }

        public bool Clicked(int x, int y)
        {
            int  diff = (Center.X - x) * (Center.X - x) + (Center.Y - y) * (Center.Y - y);
            return diff <= radius * radius;
        }
    }
}
