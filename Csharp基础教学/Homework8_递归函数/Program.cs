namespace Homework8_递归函数
{
    internal class Program
    {

        #region 1
        //使用递归的方式打印0~10
        static void Output(int a)
        {
            if(a > 10)
            {
                return;
            }
            Console.Write(a + " ");
            ++a;
            Output(a);
        }
        #endregion


        #region 2
        //传入一个值，递归求该值的阶乘 并返回5！= 1*2*3*4*5
        static int Factorial(int a)
        {
            // 基础情况：如果a小于等于1，则返回1
            if (a == 1)
            {
                return 1;
            }
                // 递归调用：计算a * Factorial(a - 1)
                return a * Factorial(a - 1);
        }

        #endregion


        #region 3
        //使用递归求 1！+2！ +3！ +4！+ ⋯ + 10！
        static int Multiply(int a)
        {
            if(a == 1)
            {
                return 1;
                //return Multiply(1);
            }
            return Factorial(a) + Multiply(a - 1);
        }
        #endregion


        #region 4
        //一根竹竿长100m，每天砍掉一半，求第十天它的长度是多少（从第0天开始）
        static void Bamboo(int day, float length)
        {
            length /= 2;
            if(day == 10)
            {
                Console.WriteLine("第十天竹子长{0}米",length);
                return;
            }
            ++day;
            Bamboo(day, length);
        }
        #endregion


        #region 5
        //不允许使用循环语包、条件语句，在控制台中打印出1-200这200个数。
        //（提示：递归+*短路*）
        static bool Fun5(int a)
        {
            Console.Write(a + " ");
            return a == 200 || Fun5(a + 1);
        }


        #endregion




        static void Main(string[] args)
        {

            #region 1

            Output(0);      //0 1 2 3 4 5 6 7 8 9 10
            Console.WriteLine();

            #endregion


            #region 2

            Console.WriteLine("5! = 1 * 2 * 3 * 4 * 5 = " + Factorial(5));  // 120

            #endregion


            #region 3

            
            Console.WriteLine(Multiply(10));        //4037913

            #endregion


            #region 4
            Bamboo(0, 100);                         //第十天竹子长0.048828125米
            #endregion


            #region 5
            Fun5(1);
            #endregion


        }
    }
}
