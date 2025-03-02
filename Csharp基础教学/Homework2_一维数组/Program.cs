namespace Homework2_一维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1
            Console.WriteLine("第一题————————————————————————");
            //请创建一个一维数组井赋值，让其值与下标一样，长度为100
            int[] arrA = new int[100];
            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = i;
                Console.Write(arrA[i] + " ");
            }
            Console.WriteLine();
            #endregion



            #region 2
            Console.WriteLine("第二题————————————————————————");
            //创建另一个数组B，让数组A中的每个元素的值乘以2存入到数组B中
            //数组A见题1
            int[] arrB = new int[100];
            for (int i = 0;i < arrB.Length;i++)
            {
                arrB[i] = arrA[i] * 2;
                Console.Write(arrB[i] + " ");
            }
            Console.WriteLine();
            #endregion



            #region 3
            Console.WriteLine("第三题————————————————————————");
            //随机（0~100）生成1个长度为10的整数数组
            Random r = new Random();
            int[] arr2 = new int[10];
            for (int i = 0; i < arr2.Length ; i++)
            {
                arr2[i] = r.Next(0, 101);
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            #endregion



            #region 4
            Console.WriteLine("第四题————————————————————————");
            //从一个整数数组中找出最大值、最小值、总合、平均值（可以使用随机数1~100）
            Random random = new Random();
            int[] arr3 = new int[10];
            int max = 0, 
                min = 0, 
                sum = 0;
            float ave = 0;
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = random.Next(1, 101);
                Console.Write(arr3[i] + " ");
                sum += arr3[i];
                if(i == 0)
                {
                    min = max = arr3[0];
                }
                else
                {
                    //最大值
                    if (max < arr3[i])
                    {
                        max = arr3[i];
                    }
                    //最小值
                    if (min > arr3[i])
                    {
                        min = arr3[i];
                    }
                }

            }
            ave = sum / 10;
            Console.WriteLine();
            Console.WriteLine("该整数数组的最大值为{0}，最小值为{1}，总和为{2}、平均数为{3}", max, min, sum, ave );
            #endregion



            #region 5
            Console.WriteLine("第五题————————————————————————");
            //交换数组中的第一个和最后一个、第二个和倒数第二个，依次类推，把数组进行反转并打印
            int[] arr5 = new int[10];
            Random ran = new Random();
            Console.WriteLine("原数组:");
            for (int i = 0 ; i < arr5.Length ; i++)
            {
                arr5[i] = ran.Next(1, 100);
                Console.Write(arr5[i] + " ");
            }
            //反转数组
            Console.WriteLine();
            Console.WriteLine("反转数组:");
            for (int i = 0 ; i < arr5.Length / 2 ; i++)
            {
                int temp = arr5[i];
                arr5[i] = arr5[arr5.Length - 1 - i];
                arr5[arr5.Length - 1 - i] = temp;
            }
            //打印反转数组
            for(int i = 0; i < arr5.Length ; i++)
            {
                Console.Write(arr5[i] + " ");
            }
            Console.WriteLine();
            #endregion



            #region 6
            Console.WriteLine("第六题————————————————————————");
            /*
             将一个整数数组的每一个元素进行如下的处理：
             如果元素是正数则将这个位置的元素值加1；
             如果元素是负数则将这个位置的元素值减1；
             如果元素是0，则不变。
            */
            int[] arr6 = new int[10];
            Console.WriteLine("该整数数组为：");
            for (int i = 0; i < arr6.Length; i++)
            {
                arr6[i] = random.Next(-100, 100);
                Console.Write(arr6[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("处理后的数组为：");
            for (int i = 0; i < arr6.Length; i++)
            {
                if (arr6[i] > 0)
                {
                    arr6[i] += 1;
                }
                else if (arr6[i] < 0)
                {
                    arr6[i] -= 1;
                }
                else
                {
                    arr6[i] = 0;
                }
                Console.Write(arr6[i] + " ");
            }
            Console.WriteLine();

            #endregion


            #region 7
            /*
            Console.WriteLine("第七题————————————————————————");
            //定义一个有10个元素的数组，使用for循环，输入10名同学的数学成绩，
            //将成绩依次存入数组，然后分别求出最高分和最低分，并且求出10名同学的数学平均成绩
            int[] arr7 = new int[10];
            int ave7 = 0,
                sum7 = 0,
                min7 = 0,
                max7 = 0;
            for (int i = 0; i < arr7.Length; i++)
            {
                Console.WriteLine("请输入第{0}位同学的成绩：", i+1);
                arr7[i] =int.Parse(Console.ReadLine());
                sum7 += arr7[i];

                if(i == 0)
                {
                    min7 = arr7[0];
                    max7 = arr7[0];
                }
                else
                {
                    //第一次赋值后再进行对比
                    if (min7 > arr7[i])
                    {
                        min7 = arr7[i];
                    }
                    if (max7 < arr7[i])
                    {
                        max7 = arr7[i];
                    }
                }
            }
            ave7 = sum7 / arr7.Length;
            Console.WriteLine("十位同学中的最高分为{0}，最低分为{1}，平均成绩为{2}", max7, min7, ave7);
            Console.WriteLine();
            */

            #endregion


            #region 8
            Console.WriteLine("第八题————————————————————————");
            //请声明一个string类型的数组（长度为25）（该数组中存储着符号），
            //通过遍历数组的方式取出其中存储的符号打印出以下效果
            string[] str = new string[25];
            for (int i = 0;i < str.Length ; i++)
            {
                str[i] = i % 2 == 0 ? "■" : "□";
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(str[i]);
            }

            #endregion



        }
    }
}
