using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    public class Scene
    {
        public List<Circles> circles { get; set; }
        public int Combo { get; set; }
        public int flagMax { get; set; }
        public int threeLives { get; set; }


        public Scene()
        {
            circles = new List<Circles>();
            Combo = 0;
            flagMax = 0;
            threeLives = 3;
        }
        public void Draw(Graphics g)
        {
            foreach(Circles c in circles) {
                c.Draw(g);
            }
        }
        
        public void addC(Circles c)
        {
            circles.Add(c);
        }
        
        public void Click(int x, int y) {
            for (int i = 0; i < circles.Count; i++)
            {
                if (circles[i].Clicked(x, y))
                {
                    Combo++;
                    circles.RemoveAt(i);
                    if (Combo > flagMax)
                        flagMax = Combo;
                }
                else
                {
                    threeLives--;
                    Combo = 0;
                    circles.RemoveAt(i);
                }
            }
        }
        public void removeC() 
        {
            for (int i = 0; i < circles.Count-1; i++)
                circles.RemoveAt(i);
        }

        internal void removeAllC()
        {
            for (int i = 0; i < circles.Count; i++)
                circles.RemoveAt(i);
        }
    }
}
