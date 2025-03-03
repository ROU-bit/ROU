namespace Homework4_函数
{
    internal class Program
    {
        #region 1
        //写一个函数，比较两个数字的大小，返回最大值
        static int Com(int a, int b)
        {
            //if(a > b)
            //{
            //    return a;
            //}
            //else
            //{
            //    return b;
            //}
            return a > b ? a : b;
        }
        #endregion

        #region 2
        //写一个函数，用于计算一个圆的面积和周长，并返回打印
        //static void Sc(int r)
        //{
        //    const double PI = 3.1415926;
        //    double S = r * r * PI;
        //    double C = 2 * PI * r;
        //    Console.WriteLine("这个圆的面积是{0}，周长是{1}", S, C);
        //}
        static float[] Sc(float r)
        {
            return new float[] {3.14f * r * r, 2 * 3.14f *  r };
        }
        #endregion

        #region 3
        //写一个函数，求一个数组的总合、最大值、最小值、平均值
        static void Count(int[] a)
        {
            int sum = 0;
            float avg = 0;
            int max = 0;
            int min = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a.Length == 0)
                {
                    Console.WriteLine("数组不能为空");
                    return;
                }
                sum += a[i];
                if(i == 0)
                {
                    max = a[0];
                    min = a[0];
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            avg = sum / a.Length;
            Console.WriteLine("此数组的总和为{0}，最大值是{1}，最小值是{2}，平均值是{3}。", sum, max, min, avg );
        }
        #endregion

        #region 4
        //写一个函数，判断你传入的参数是不是质数
        //static void ZhiShu(int a)
        //{
        //    if(a <= 0)
        //    {
        //        Console.WriteLine("{0}不是质数", a);
        //        return;
        //    }
        //    for (int i = 2;i < a;i++)
        //    {
        //        if(a % i == 0)
        //        {
        //            Console.WriteLine("{0}不是质数", a);
        //            return;
        //        }
        //    }
        //    Console.WriteLine("{0}是质数", a);
        //}
        static bool IsPrime(int a)
        {
            //判断质数的逻辑
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;   //return直接跳出IsPrime函数
                }
            }
            //默认是质数
            return true;
        }
        #endregion

        #region 5
        /*
         写一个函数，判断你输入的年份是否是闰年闰年判断条件：
         年份能被400整除（2000）
         或者
         年份能被4整除，但是不能被100整除（2008）
         */
        //static void LeapYear(int a)
        //{
        //    if(a > 0)
        //    {
        //        if (a % 400 == 0 || (a % 4 == 0 && a % 100 != 0))
        //        {
        //            Console.WriteLine("{0}是闰年", a);
        //        }
        //        else
        //        {
        //            Console.WriteLine("{0}不是闰年", a);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("请输入正整数！");
        //    }
        //}
        static bool LeapYear(int a)
        {
            if (a > 0)
            {
                if (a % 400 == 0 || (a % 4 == 0 && a % 100 != 0))
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine("请输入正整数！");
            }
            return false;
        }
        #endregion


        static void Main(string[] args)
        {
            //1.输入需要比较的两个数字
            Console.WriteLine(Com(1, 2));       //2


            //2.输入半径
            float[] f = Sc(4);                              
            Console.WriteLine("这个圆的面积是{0}，周长是{1}", f[0], f[1]); //这个圆的面积是50.24，周长是25.12


            //3.输入数组
            Count(new int[] { 1, 2, 3, 4, 5 }); //此数组的总和为15，最大值是5，最小值是1，平均值是3。


            //4.输入一个正整数
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}质数", a, IsPrime(a) ? "是" : "不是" ); //98
                                                                            //98不是质数


            //5.输入一个年份
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}闰年", b, LeapYear(b) ? "是" : "不是"); //2000
                                                                            //2000是闰年

        }
    }
}
