namespace Homework7_函数重载
{
    internal class Program
    {

        #region 1
        /*
          请重载一个函数
          让其可以比较两个int或两个float或两个double的大小 ®
          并返回较大的那个值
        */
        static int ComparingNumber(int a, int b)
        {
            return a > b ? a : b;
        }
        static float ComparingNumber(float a, float b)
        {
            return a > b ? a : b;
        }
        static double ComparingNumber(double a, double b)
        {
            return a > b ? a : b;
        }
        #endregion


        #region 2
        /*
          请重载一个函数
          让其可以比较n个int或n个float或n个double的大小
          并返回最大的那个值。（用params可变参数来完成）
         */
        static int ComparingNumbers(params int[] a)
        {
            if(a.Length  == 0)
            {
                return -1;
            }
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        static float ComparingNumbers(params float[] a)
        {
            if (a.Length == 0)
            {
                return -1;
            }
            float max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        static double ComparingNumbers(params double[] a)
        {
            if (a.Length == 0)
            {
                return -1;
            }
            double max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        #endregion

        static void Main(string[] args)
        {

            #region 1
            //输入两个int值
            Console.WriteLine(ComparingNumber(8, 5));

            //输入两个float值
            Console.WriteLine(ComparingNumber(8.7f, 5.6f));

            //输入两个double值
            Console.WriteLine(ComparingNumber(9.7984651398, 45.879465132));
            #endregion


            #region 2
            //输入两个int值
            Console.WriteLine(ComparingNumbers(8, 5, 45, 7, 8, 2, 48, 1, 84, 1, 4, 841, 54));

            //输入两个float值
            Console.WriteLine(ComparingNumbers(8.7f, 5.6f, 45.7f, 82.48f, 1.84f, 1.4f, 841.54f));

            //输入两个double值
            Console.WriteLine(ComparingNumbers(9.7984651398, 45.879465132,45.7894651,95.78418));
            #endregion



        }
    }
}
