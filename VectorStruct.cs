using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    public struct Vector
    {
        float x, y, z;
        

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            Vector result;
            result.x = a.x + b.x;
            result.y = a.y + b.y;
            result.z = a.z + b.z;
            return result;
        }
        /*public static Vector operator -(Vector a, Vector b)
        {

        }
        public static Vector operator *(Vector a, Vector b)
        {
 
        }
        public static Vector operator /(Vector a, Vector b)
        {

        }*/
        public static Vector VectorUp(Vector a)
        {
            a.y++;
            return a;
        }

        
    }
}
