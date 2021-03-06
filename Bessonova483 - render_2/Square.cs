using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bessonova483___render
{
    public class Square : Figure
    {
        public float side;
        static public int local_id;

        public Square(string side1)
        {

            local_id++;
            id = "square" + local_id.ToString();
            side = float.Parse(side1);
        }

        public override bool test(float x, float y)
        {
            float half_side = side * 0.5f;
            float xmin = pos_x - half_side;
            float xmax = pos_x + half_side;
            float ymin = pos_y - half_side;
            float ymax = pos_y + half_side;
            if (x < xmin || y < ymin) return false;
            if (x > xmax || y > ymax) return false;
            return true;
        }

        public override void draw(Graphics g)
        {
            float half_side = side * 0.5f;
            float x0 = pos_x - half_side;
            float y0 = pos_y - half_side;
            Pen p = Pens.Black;
            if (selected == true) p = Pens.Red;
            g.DrawRectangle(p, x0, y0, side, side);
        }

         public override float sdf(Vec2 p)
         {
             float half_side = side * 0.5f;

            float P = Convert.ToSingle(p) - pos;
            float s = p.abs(P);
            float d = s - half_side;
            float inner_d = Math.Min(Math.Max(p.x, p.y), 0.0f);
             float outer_d = p.Len(p.Max(0.0f));
             return inner_d + outer_d;

         }
    }
}
