using System;

namespace Homework11_选择排序
{
    internal class Program
    {
        static void UpDown(int[]arr,bool Choose)
        {
            int index;
            int temp;
            for (int n = 0; n < arr.Length; n++) 
            {
                index = 0;
                for(int m = 1;m < arr.Length - n;m++)
                {
                    bool boo = Choose ? arr[index] < arr[m] : arr[index] > arr[m];
                    if (boo)
                    {
                        index = m;
                    }
                }
                if(index != arr.Length - 1 - n)
                {
                    temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - n];
                    arr[arr.Length - 1 - n] = temp;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            #region 1
            //定义一个数组，长度为20，每个元素值随机0~100的数
            //使用选择排序进行升序排序并打印
            //使用选择排序进行降序排序并打印
            Random r = new Random();
            int a = 0;
            Console.WriteLine("请输入数组的长度");
            a = int.Parse(Console.ReadLine());

            int[] arr = new int[a];
            Console.WriteLine("原数组为：");
            for (int i = 0;i < arr.Length;i++)
            {
                arr[i] = r.Next(0,101);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("升序1 or 降序0");
            int b = int.Parse(Console.ReadKey(true).KeyChar.ToString());
            bool bo = b == 1 ? true : false;

            Console.WriteLine("更改后的数组为：");
            UpDown(arr,bo);

            #endregion






        }
    }
}
