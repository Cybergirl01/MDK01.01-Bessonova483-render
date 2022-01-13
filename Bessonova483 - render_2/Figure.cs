using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bessonova483___render
{
    public class Figure
    {
        public float pos;
        public float pos_x, pos_y;
        public bool selected;
        public string id;
        public RGB clr;

        virtual public bool test(float x, float y)
        {
            return false;
        }
        virtual public void draw(Graphics g)
        {

        }

        public Figure()
        {
            clr = RGB.getRandom();

        }

       virtual public float sdf(Vec2 p)
       {
            float q = Convert.ToSingle(p);
            return q;
       }
        
    }
}
