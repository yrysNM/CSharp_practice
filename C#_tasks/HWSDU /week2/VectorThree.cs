using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    class VectorThree
    {
        public float x, y, z;

        public VectorThree()
        {
            this.x = 1;
            this.y = 1;
            this.z = 1;
        }

        public VectorThree(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"Vector3({this.x}, {this.y}, {this.z})";
        }

        public float distanceVectorThree(VectorThree v1, VectorThree v2)
        {
            VectorThree v3 = (v1 - v2);
            float res = (float)Math.Sqrt(Math.Pow(v3.x, 2) + Math.Pow(v3.y, 2) + Math.Pow(v3.z, 2));
            return res;
        }

        public static VectorThree operator +(VectorThree v1, VectorThree v2)
        {
            VectorThree v3 = new VectorThree();
            v3.x = v1.x + v2.x;
            v3.y = v1.y + v2.y;
            v3.z = v1.z + v2.z;
            return v3;
        }

        public static VectorThree operator -(VectorThree v1, VectorThree v2)
        {
            VectorThree v3 = new VectorThree();
            v3.x = v1.x - v2.x;
            v3.y = v1.y - v2.y;
            v3.z = v1.z - v2.z;
            return v3;
        }

        public static VectorThree operator *(VectorThree v1, float a)
        {
            VectorThree v2 = new VectorThree();
            v2.x = v1.x * a;
            v2.y = v1.y * a;
            v2.z = v1.z * a;
            return v2;
        }

        public static VectorThree operator /(VectorThree v1, float a)
        {
            VectorThree v2 = new VectorThree();
            v2.x = v1.x / a;
            v2.y = v1.y / a;
            v2.z = v1.z / a;
            return v2;
        }

        public static bool operator ==(VectorThree v1, VectorThree v2)
        {
            return v1.x == v2.x && v1.z == v2.z && v1.y == v2.y;
        }
        public static bool operator !=(VectorThree v1, VectorThree v2)
        {
            return v1.x != v2.x || v1.z != v2.z || v1.y != v2.y;
        }
    }
}