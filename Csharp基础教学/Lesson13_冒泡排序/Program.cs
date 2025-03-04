namespace Lesson13_冒泡排序
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点一 排序的基本概念
            //排序是计算机内经常进行的一种操作，其目的是将一组“无序”的记录序列调整为“有序”的记录序列
            //常用的排序列子
            //8 7 1 5 4 2 6 3 9
            //把上面的这个无序序列变为有序（升序或降序）序列的过程被称为排序
            //1 2 3 4 5 6 7 8 9（升序）
            //9 8 7 6 5 4 3 2 1 （降序）

            //在程序中 序列一般存储在数组当中
            //所以排序往往是对数组进行排序
            int[] arr = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };
            //把数组里面的内容变为有序的
            #endregion


            #region 知识点二 冒泡排序的基本原理
            //冒泡排序是达成排序目的的一种方法
            //8 7 1 5 4 2 6 3 9
            //两两相邻
            //不停比较
            //不停交换
            //比较n轮
            #endregion


            #region 知识点三 代码实现

            //第一步 如何比较数组中两辆相邻的数
            //8, 7, 1, 5, 4, 2, 6, 3, 9 
            //从头开始
            //将第n个数和第n+1个数进行比较

            //for(int n = 0; n < arr.Length - 1; n++)
            //{
            //    //如果第n个数比n+1个数要大 则两两交换位置
            //    if (arr[n] > arr[n+1])
            //    {
            //        //第二步 交换位置
            //        //中间商不赚差价
            //        int temp = arr[n];
            //        arr[n] = arr[n+1];
            //        arr[n+1] = temp;
            //    }
            //}

            //第三步 如何换m轮
            //有几个数就比较多少轮
            //for (int m = 0; m < arr.Length; m++)
            //{
            //    //进一次循环就要比较一轮
            //    for (int n = 0; n < arr.Length - 1; n++)
            //    {
            //        //如果第n个数比n+1个数要大 则两两交换位置
            //        if (arr[n] > arr[n + 1])
            //        {
            //            //第二步 交换位置
            //            //中间商不赚差价
            //            int temp = arr[n];
            //            arr[n] = arr[n + 1];
            //            arr[n + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.Length ; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //第四步 优化
            //1.确定位置的数字 不用比较了
            // 确认了一轮后 极值（最大或者最小）已经被放到了对应的位置（往后放）
            //所以每完成n轮 后面位置的数就不需要比较了

            //for (int m = 0; m < arr.Length; m++)
            //{
            //    //进一次循环就要比较一轮
            //    for (int n = 0; n < arr.Length - 1 - m; n++)
            //    {
            //        //如果第n个数比n+1个数要大 则两两交换位置
            //        if (arr[n] > arr[n + 1])
            //        {
            //            //第二步 交换位置
            //            //中间商不赚差价
            //            int temp = arr[n];
            //            arr[n] = arr[n + 1];
            //            arr[n + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //2.特殊情况的优化
            //外面申明一个标识 来表示该轮是否进行了交换
            bool isShort = false;
            for (int m = 0; m < arr.Length; m++)
            {
                //每一轮开始都默认没有进行交换
                isShort = false;
                //进一次循环就要比较一轮
                for (int n = 0; n < arr.Length - 1 - m; n++)
                {
                    //如果第n个数比n+1个数要大 则两两交换位置
                    if (arr[n] > arr[n + 1])
                    {
                        //进入此条件就说明本轮进行了交换
                        isShort = true;
                        //第二步 交换位置
                        //中间商不赚差价
                        int temp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = temp;
                    }
                }
                //当一轮结束后 如果isShort这个标识还是false
                //那就意味着已经是最终的序列了 不需要再判断交换
                if (!isShort)
                {
                    //进入此条件说明本轮未进行交换 直接退出外圈for循环
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            #endregion


            //总结
            //基本概念
            //两两比较、不停比较、不停交换、比较m轮

            //套路写法
            //两层循环、外层轮数、内层比较、两值比较、满足交换

            //如何优化
            //比过的不比（-轮次）、加入bool值



        }
    }
}
