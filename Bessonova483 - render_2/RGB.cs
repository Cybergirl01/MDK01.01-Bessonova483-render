using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bessonova483___render
{
    public class RGB
    {
        float r, g, b;

        public static RGB getRandom()
        {

            ///Создание объекта для генерации чисел
            Random rnd = new Random();

            float val1 = (float)rnd.NextDouble();
            float val2 = (float)rnd.NextDouble();
            float val3 = (float)rnd.NextDouble();
            return new RGB(val1, val2, val3);
        }

        public RGB()
        {
            r = 0.0f;
            g = 0.0f;
            b = 0.0f;
        }

        public RGB(float x)
        {
            if (r == x)
                r = 1.0f;
            else if (g == x)
                g = 1.0f;
            else
                b = 1.0f;
        }

        public RGB(float r1, float g1, float b1)
        {
            r = r1;
            g = g1;
            b = b1;
            getColor();
        }

          public static RGB operator +(RGB a, RGB b)
          {
              return  a + b ;
          }
          
          public static float operator *(RGB a, float b)
          {
              return a * b;
          }

        public Color getColor()
        {

            Color color = Color.FromArgb(255, (int)(r * 255), (int)(g * 255), (int)(b * 255));
            return color;

        }
    }
}
