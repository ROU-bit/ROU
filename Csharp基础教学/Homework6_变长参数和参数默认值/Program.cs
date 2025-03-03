namespace Homework6_变长参数和参数默认值
{
    internal class Program
    {
        #region 1
        //使用params参数，求多个数字的和以及平均数
        static void Calc(params int[] a)
        {
            if(a.Length == 0)
            {
                Console.WriteLine("null");
                return;
            }
            int sum = 0;
            float avg = 0;
            for(int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            avg = sum / a.Length;
            Console.WriteLine("这些数字的和为{0},平均数为{1}。", sum, avg);
        }
        #endregion

        #region 2
        //使用params参数，求多个数字的偶数以及奇数和
        static void Sum(params int[]num)
        {
            int evenSum = 0;
            int oddSum = 0;
            if (num.Length == 0)
            {
                Console.WriteLine("null");
                return;
            }
            for (int i = 0;i < num.Length;i++)
            {
                if(num[i] % 2 == 0)
                {
                    evenSum += num[i];
                }
                else
                {
                    oddSum += num[i];
                }
            }
            Console.WriteLine("这个数字的偶数和为{0}，奇数和为{1}。", evenSum, oddSum);
        }


        #endregion


        static void Main(string[] args)
        {
            #region 1
            //写数字
            Calc();                             //null
            Calc(45, 1, 56, 78, 145);           //这些数字的和为325,平均数为65。
            #endregion


            #region 2
            //写数字
            Sum();                              //null
            Sum(45, 8, 4, 21, 95);              //这个数字的偶数和为12，奇数和为161。
            #endregion


        }
    }
}
