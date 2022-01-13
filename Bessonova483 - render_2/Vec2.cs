using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bessonova483___render
{
    public class Vec2
    {
       public float x, y;

        public static Vec2 fromPolar(float angle)
        {
            float angle0 = (float)(Math.PI * angle / 180.0f);
            float sin = (float)Math.Sin(angle0);
            float cos = (float)Math.Cos(angle0);
            return new Vec2(sin, cos);
        }
        
        public Vec2()
        {
        x=0.0f;
        y=0.0f;
        
        }

        public Vec2(float x1, float y1)
        {
        x=x1;
        y=y1;
        }

        public static Vec2 operator +(Vec2 a, Vec2 b)
          {
              return a + b ;
          }
          
          public static Vec2 operator *(Vec2 a, float b)
          {
              return a * b;
          }

        /* public static Vec2 operator -(Vec2 a, Vec2 b)
          {
              return new Vec2 { Value = a + b };
          }
          */
        
          public static float operator -(Vec2 a, float b)
          {
              return a - b;
          }


        public float Len(float s)
        { float AB = (float) Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
           return AB;
        }

        public float abs(float m){
            float abs = Math.Abs(m);
            return abs;
        }

        
        public float Max(float v)
        {
            return v;
        }

       
    }
}
