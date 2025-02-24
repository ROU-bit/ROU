namespace Lesson16_循环语句while
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 知识点一 作用
            //让顺序执行的代码 可以不停地循环执行某一代码块的内容
            //条件分支语句 让代码产生分支
            //循环语句 让代码可以被重复执行
            #endregion


            #region 知识点二 语法相关
            /*
            //bool类型变量 条件运算符 逻辑运算符
            while(bool类型的值)
            {
                //当满足条件时 就会执行while语句块中的内容
                //..............
                //..............
                //当代码逻辑执行完，会回到while循环开头，再次进行条件判断来决定是否要继续循环
            }
            */

            //死循环
            //即不停的执行循环中的逻辑直到“死”为止
            //死循环只有在学习控制台程序会频繁使用
            //进入unity学习后就不会使用了
            //1.可能会因为内存问题造成程序崩溃 闪退
            //2.造成程序卡死
            /*
             死循环如下：
            while(true)
            {
                Console.WriteLine("流明是超大杯~");
            }
            */

            //计算一个为0的整形变量，让他只能累加1，直到10为止。
            int a = 0;
            while (a < 10)
            {
                a++;
            }
            Console.WriteLine(a);

            #endregion


            #region 知识点三 嵌套使用
            //不仅可以嵌套 if switch 还可以嵌套自己while
            //注意变量声明的位置
            a = 0;
            int b = 0;
            while (b < 10)
            {
                b++;
                while (a < 10)
                {
                    a++;
                }
            }
            Console.WriteLine(b);
            Console.WriteLine(a);


            /*
            a = 0;
            while (a < 10)
            {
                b++;
                //此b2并无法通过下述循环改变，
                //因为在while语句块外面的b2相当于被重新赋值
                int b1 = 0;
                while (b1 < 10)
                {
                    b1++;
                }
            }
            Console.WriteLine(a);
            */

            #endregion


            #region 知识点四 流程控制关键词
            //作用 控制循环逻辑的关键词
            //break 跳出循环
            while (true)
            {
                Console.WriteLine("break执行前的代码");
                break;
                Console.WriteLine("break执行后的代码");
            }
            Console.WriteLine("循环外的代码");

            a = 0;
            while(true)
            {
                ++a;
                Console.WriteLine(a);
                if(a == 10)
                {
                    break;      //跳出循环
                                //不只是跳出if 而是跳出整个while
                                //break与while配合使用
                }
            }
            Console.WriteLine(a);


            //continue 回到循环开始 继续执行
            //while (true)
            //{
            //    Console.WriteLine("continue执行前的代码");
            //    continue;
            //    Console.WriteLine("continue执行后的代码");
            //}
            //Console.WriteLine("循环外的代码");

            //打印1到20之间的奇数
            int jiShu = 0;
            while (jiShu <=20 )
            {
                jiShu++;
                if(jiShu % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(jiShu);
            }


            //注意 break和continue主要是和循环配合使用的 和if语句没关系

            //break在switch中的作用和while循环中的作用有异曲同工之妙
            //while (true)
            //{
            //    jiShu = 1;
            //    switch (jiShu)
            //    {
            //        default:
            //            break;          //该break与switch对应 对while无效果
            //    }
            //    Console.WriteLine("11111");
            //}

            #endregion


            Console.WriteLine("HOMEWORK");


            #region 作业
            //1.在控制台输出1到100。
            int i = 0;
            while (i < 100)
            {
                i++;
                Console.WriteLine(i);
            }


            //2.在控制台输出1到100之间所有整数的和。
            i = 0;
            int sum = 0;
            while(i < 100)
            {
                i++;
                sum += i;
            }
            Console.WriteLine(sum);         //5050


            //3.用while和continue实现计算1到100（包含）之间的除了能被7整除之外所有整数的和。
            i = 0;
            sum = 0;
            while (i < 100)
            {
                i++;
                if (i % 7 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine(sum);         //4315


            /*4.
             提示用户输入一个数，判断该数是否是素数并打印。
            （素数/质数：只能被1和这个数字本身整除的数字，1不是质数，最小的质数是2）
             */
            try
            {
                Console.WriteLine("请输入一个数");
                int j = int.Parse(Console.ReadLine());
                int index = 2;
                while(index < j)
                {
                    if(j % index == 0)
                    {
                        break;
                    }
                    ++index;
                }
                if(index != j)
                {
                    Console.WriteLine("不是一个质数！");
                }
                else
                {
                    Console.WriteLine("是质数。");
                }
            }

            catch
            {
                Console.WriteLine("输入格式错误，请输入数字！");
            }
            


            /*5.
             要求输入用户名和密码（admin/8888），用户名或者密码错误，
             则提示“用户名或密码错误”，直到输入正确为止
             */

            while(true)
            {
                Console.WriteLine("请输入用户名：");
                string admin = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                int pw = int.Parse(Console.ReadLine());

                if(admin =="admin" && pw == 8888)
                {
                    Console.WriteLine("输入正确！");
                    break;
                }
                Console.WriteLine("用户名或密码错误，请重新输入！" );
            }
           




            //6.输入班级人数，然后依次输入学员成绩（需提示当前是第几个学员），
            //计算班级学员的平均成绩和总成绩。

            Console.WriteLine("请输入班级人数：");
            int i1 = int.Parse(Console.ReadLine());
            int i3 = i1;
            int summ = 0;
            int i2;
            while (true)
            {
                Console.WriteLine("请输入第" + i3 + "个学员的成绩:");
                int j = int.Parse(Console.ReadLine());
                i2 = i3 - 1;
                summ += j;
                if(i2 == 0)
                {
                    int avgg = summ / i1;
                    Console.WriteLine("该班级学员平均成绩为：" + avgg);
                    Console.WriteLine("该班级学员的总成绩为：" + summ);
                    break;
                }
            }


            /*7.
             定义一个整形变量sum，然后分别把1~100之间的数字依次累加到sum中，
             当sum的值大于500的时候，中断操作，并在控制台输出累加到第几个数字就可以使sum大于500
             */
            int ii = 0;
            int sum1 = 0;
            while (ii <= 100)
            {
                ii++;
                sum1 += ii;
                if(sum1 > 500)
                {
                    Console.WriteLine("输入到第" + ii + "个数字后可以使sum大于500");     //32
                    break;
                }

            }


            /*8.
             假设看唐老狮视频的同学有100人，每个月增长20%，
            请问按此速度增长，经历多少个月看唐老狮视频的同学能达到1000人？
             */
            double stu = 100;
            int month = 1;
            while (true)
            {
                stu += 0.2 * stu;
                month++;
                if(stu>=1000)
                {
                    Console.WriteLine("历经" + month + "个月看唐老狮视频的同学能达到1000人");    //14
                    break;
                }
            }


            //9.求数列 1,1,2,3,5,8,13..的第20位数字是多少？
            int z = 1;
            int x = 1;
            int c = 0;
            int v;
            while (true)
            {
                v = z + c;
                c = z;
                z = v;
                x++;
                if(x==20)
                {
                    Console.WriteLine("第20位数字为：" + c);      //4181
                    break;
                }
            }


            //*10.找出100内所有素数并打印。
            int l = 2;
            while (l < 100)
            {
                int k = 2;
                while(k < l)
                {
                    if( l % k == 0 )
                    {
                        break;
                    }
                ++k;
                
                }
                if (k == l)
                {
                    Console.WriteLine(l + ",");
                }
                l++;
            }

            


            #endregion


        }
    }
}
