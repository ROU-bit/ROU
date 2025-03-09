namespace Homework10_封装_运算符重载
{

    #region 1
    //定义一个位置结构体或类，为其重载判断是否相等的运算符
    //(x1 , y1) == (x2 , y2) ===> 两个值相等才为true
    class Point
    {
        public int X; 
        public int Y;

        public static bool operator ==(Point a, Point b)
        {
            if (a.X == b.X && a.Y == b.Y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Point a, Point b)
        {
            if (a.X != b.X || a.Y != b.Y)
            {
                return false;
            }
            return true;
        }
    }
    #endregion


    #region 2
    //定义一个Vector3类(x,y,z)通过重载运算符实现以下运算
    //(x1,y1,z1) + (x2,y2,z2) = (x1+x2,y1+y2,z1+z2)
    //(x1,y1,z1) - (x2,y2,z2) = (x1-x2,y1-y2,z1-z2)
    //(x1,y1,z1) * num = (x1*num,y1*num,z1*num)
    class Vector3
    {
        public float X;
        public float Y;
        public float Z;

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            Vector3 v = new Vector3();
            v.X = v1.X + v2.X;
            v.Y = v1.Y + v2.Y;
            v.Z = v1.Z + v2.Z;
            return v;
            //return new Vector3( v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            Vector3 v = new Vector3();
            v.X = v1.X - v2.X;
            v.Y = v1.Y - v2.Y;
            v.Z = v1.Z - v2.Z;
            return v;
        }
        public static Vector3 operator *(Vector3 v1, float v2)
        {
            Vector3 v = new Vector3();
            v.X = v1.X * v2;
            v.Y = v1.Y * v2;
            v.Z = v1.Z * v2;
            return v;
        }
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2
            Vector3 v1 = new Vector3();
            v1.X = 8;
            v1.Y = 4;
            v1.Z = 7;
            Vector3 v2 = new Vector3();
            v2.X = 12;
            v2.Y = 34;
            v2.Z = 3;
            Vector3 v3 = new Vector3();
            v3.X = 7;
            v3.Y = 1;
            v3.Z = 0;
            float num = 1.2f;

            Vector3 ve1 = v1 + v2 + v3;
            Vector3 ve2 = v1 - v2 - v3;
            Vector3 ve3 = v1 * num;

            Console.WriteLine("v1 + v2 + v3 = {0}", ve1);
            Console.WriteLine("v1 - v2 - v3 = {0}", ve2);
            Console.WriteLine("v1 * num = {0}", ve3);



            #endregion


        }
    }
}
