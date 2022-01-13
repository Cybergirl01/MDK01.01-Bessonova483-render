using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bessonova483___render
{
    public class Ray 
    {
        Vec2 org, dir;

        public Ray(Vec2 org, Vec2 dir) {
            org = org;
            dir = dir;
        }

       public Vec2 pointAtDistance(float t){

            Vec2 plus = org + dir;
            Vec2 point = plus * t;
            return point;
       }
        

    }
}
