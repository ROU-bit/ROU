using System.Drawing;

namespace Lesson18_循环语句for
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点一 基本语法
            /*
            for(初始表达式;条件表达式;增量表达式 )
            {
                //循环代码逻辑;
            }
            //初始表达式：一般用来声明一个临时变量，用于计数；
            //条件表达式：表明进入循环的条件，一般是一个bool类型的结果（bool变量 条件运算符 逻辑运算符 算术运算符）
            //增量表达式：用初始表达式中的变量进行自增减运算
            */


            for (int i = 0; i < 10; i++)        //i是临时变量，不影响该代码块外的后续操作
            //每次进入循环之前都会判断第二个空中的条件，若满足则进入循环逻辑
            {
                Console.WriteLine(i);                /* 0       //第一次进入循环时才会调用第一个空中的代码
             //执行完循环语句块中的逻辑后,            1       
             //最后执行第三个空中的代码               2
                                                    3
                                                    4
                                                    5
                                                    6
                                                    7
                                                    8
                                                    9*/

            }
            for (int i = 20; i > 10; i--)
            {
                Console.WriteLine(i);                     /*20
                                                        19
                                                        18
                                                        17
                                                        16
                                                        15
                                                        14
                                                        13
                                                        12
                                                        11*/
            }

            //每个空位均按照规则进行书写
            //第一个空位申明变量 所以可以连续申明
            //第二个空位 进入条件 只要是bool结果的表达式都可以
            //第三个空位 执行一次循环逻辑后要做的事情 做什么都可以
            /*
            for (int i = 0, j = 0; i < 10 && j < 10; i++, j = j + 1)
            {

            }
            */


            #endregion


            #region 知识点二 支持嵌套
            //for循环语句也可以和其他语句互相嵌套

            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 20; i2++)       //内部代码块不能和外部同时申明一个变量，所以换成i2
                {
                    Console.WriteLine(i + "_" + i2);
                }
            }


            #endregion


            #region 知识点三 特殊写法
            //for循环这三个空可以根据需求去填写，可以都空着
            //for循环可以写死循环
            //EX.
            /*
            for(; ; )
                //这三个位置可填可不填
            {
                Console.WriteLine();
            }
            */

            int l = 0;
            for (; l < 10;)
            {
                l++;
            }

            #endregion


            #region 知识点四 对比while循环

            //for循环 更适用于准确得到一个范围中的所有数
            //经常使用 特别是在数组里

            #endregion


            #region 作业

            //1.输出1到100之间的整数（包括本身）
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }


            //2.求1~100之间所有偶数的和
            int sum = 0;
            for (int i = 0; i <= 100; i += 2)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);     //2550


            //3.找出100~999之间的水仙花数
            //EX.153 = 1*1*1 + 5*5*5 + 3*3*3 这个数就是水仙花数
            for (int i = 100; i <= 999; i++)
            {
                int geWeiShu = i % 10;
                int shiWeiShu = i % 100 / 10;
                int baiWeiShu = i / 100;
                int num = geWeiShu * geWeiShu * geWeiShu + shiWeiShu * shiWeiShu * shiWeiShu + baiWeiShu * baiWeiShu * baiWeiShu;
                if (num == i)
                {
                    Console.WriteLine(num);
                }
            }


            //4.在控制台输出九九乘法表

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "*" + i + "\t");
                }
            Console.WriteLine();
            }


                //5.在控制台输出10*10空心星星方阵
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        // 判断是否在边界上
                        if (i == 0 || i == 9 || j == 0 || j == 9)
                        {
                            Console.Write("*");     //**********
                        }
                        else
                        {
                            Console.Write(" ");     //*        *
                        }
                    }
                    // 换行
                    Console.WriteLine();
                }


                //6.输出10*10的直角三角形
                //涉及行列的题目先写for嵌套，再根据题意表达行列关系

                for(int i = 0; i < 10; i++)
                {
                    for(int j = 0;j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine() ;
                }


            //7.输出10*10的等腰三角形
            //找空格和星号与行数的关系——数列，在范围中与i进行比较来控制分布
            for(int i = 0 ; i < 10 ; i++)
            {
                for (int k = 0; k < 10 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine() ;
                
            }



                #endregion

            }
        }
    }
