using System.Runtime.InteropServices;

namespace Homework8_封装_静态类和静态构造函数
{

    #region 1
    //写一个用于数学计算的静态类
    //该类中提供计算圆面积，圆周长，矩形面积，矩形周长，取一个数的绝对值等办法

    static class MathTools
    {
        public static float PI = 3.14f;
        /// <summary>
        /// 计算圆的面积
        /// </summary>
        /// <param name="r">圆的半径</param>
        /// <returns></returns>
        static public float CircleS(float r)
        {
            return r * r * PI;
        }
        /// <summary>
        /// 计算圆的周长
        /// </summary>
        /// <param name="r">圆的半径</param>
        /// <returns></returns>
        static public float CircleC(float r)
        {
            return 2 * PI * r;
        }

        static public float RectangleC(float a , float b)
        {
            return a * b;
        } 
        static public float RectangleS(float a , float b)
        {
            return (a + b) * 2;
        }
        public static float GetABS(float a)
        {
            if (a < 0)
            {
                return -a;
            }
            else
            { 
                return a; 
            }
        }
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MathTools.CircleS(4));
            Console.WriteLine(MathTools.CircleC(4));
            Console.WriteLine(MathTools.RectangleS(4,7));
            Console.WriteLine(MathTools.RectangleC(4,7));
        }
    }
}
