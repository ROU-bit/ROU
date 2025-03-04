namespace Homework10_冒泡排序
{
    internal class Program
    {
        #region 2
        //写一个函数，实现一个数组的排序，并返回结果，可以根据参数决定是升序还是降序
        static void UpDown(int[]arr2, bool boo) 
        {
            bool bo;
            for (int i = 0; i < arr2.Length - 1; i++)
            {
                bo = false;
                for(int j = 0; j < arr2.Length - 1 - i; j++)
                {

                    bool booo = boo ? arr2[j] > arr2[j + 1] : arr2[j] < arr2[j + 1];

                    if (booo)
                    {
                        bo = true;
                        int temp = arr2[j];
                        arr2[j] = arr2[j + 1];
                        arr2[j + 1] = temp;
                    }
                }
                if (!bo)
                { 
                    break;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }    









        #endregion

        static void Main(string[] args)
        {

            #region 1
            /*
             定义一个数组，长度为20，每个元素值随机0~100的数
             使用冒泡排序进行升序排序并打印
             使用冒泡排序进行降序排序并打印
             */
            int[] arr1 = new int[20];
            int[] arr2 = new int[20];
            Random r = new Random();

            Console.WriteLine("原数组为:");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = r.Next(0, 101);
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0;i < arr2.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            //升序排序
            Console.WriteLine("升序排序后的数组为:");
            bool ifShort = false;
            for (int m = 0; m < arr1.Length; m++)
            {
                ifShort = false;
                for (int n = 0; n < arr1.Length - 1 - m; n++)
                {
                    if (arr1[n] > arr1[n + 1])
                    {
                        ifShort = true;
                        int temp = arr1[n];
                        arr1[n] = arr1[n + 1];
                        arr1[n + 1] = temp;
                    }
                }
                if (!ifShort)
                {
                    break;
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] +" ");
            }
            Console.WriteLine();

            //降序排序
            Console.WriteLine("降序排序后的数组为:");
            bool isUp = false;
            for(int m = 0; m < arr2.Length; m++)
            {
                isUp = false;
                for (int n = 0; n < arr2.Length - 1 - m; n++)
                {
                    if (arr2[n] < arr2[n + 1])
                    {
                        isUp = true;
                        int temp = arr2[n];
                        arr2[n] = arr2[n + 1];
                        arr2[n + 1] = temp;
                    }
                }
                if (!isUp)
                {
                    break;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            #endregion


            #region 2
            //写一个函数，实现一个数组的排序，并返回结果，可以根据参数决定是升序还是降序
            //true升序、false降序
            Console.WriteLine("请输入数组的长度") ;
            int a = 0;
            int b = 0;
            a = int.Parse(Console.ReadKey(true).KeyChar.ToString());
            int[]arr3 = new int[a];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = r.Next(0,101);
            }
            Console.WriteLine("升序排序1 or 降序排序0");
            b = int.Parse(Console.ReadKey(true).KeyChar.ToString()) ;
            bool bo = b == 1 ? true : false;
            UpDown(arr3,bo);

            #endregion



        }
    }
}
