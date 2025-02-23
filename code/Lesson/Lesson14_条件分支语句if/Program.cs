using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace Lesson14_条件分支语句if
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点一 作用
            //让顺序执行的代码产生分支
            //if语句是第一个可以让我们的程序产生逻辑变化的语句

            #endregion


            #region 知识点二 if语句
            //作用： 满足条件时多执行一些代码
            /*语法：
                    if(bool类型值)
                        //bool类型相关：bool变量 条件运算符表达式 逻辑运算符表达式
                    {
                        满足条件要执行的代码 写在if代码块中;
                    }
            */
            //注意：
            //1.if语句的语法部分不需要写分号；
            //2.if语句可以嵌套使用。

            if (false)
            {
                Console.WriteLine("进入if语句代码块，执行其中代码逻辑");
            }
            Console.WriteLine("if语句外的代码块");

            int a = 1;
            if (a == 1) //起到一个判断的作用
            {
                Console.WriteLine("满足");
            }

            //嵌套使用（可无限嵌套）
            if (a<=8)
            {
                Console.WriteLine("a<=8");
                if (a>=0) 
                {
                    Console.WriteLine("a>=0");
                }
            }

            #endregion

            Console.WriteLine("**********************");

            #region 知识点三 if...else语句
            //作用 产生两条分支 十字路 满足条件做什么 不满足条件做什么
            /*语法：
                    if(bool类型值)
                    {
                        满足条件执行的代码;
                    }
                    else
                    {
                        不满足条件执行的代码;
                    }
            */
            //注意：
            //1.if...else语句的语法部分不需要写分号；
            //2.if...else语句可以嵌套。

            if (true)
            {
                Console.WriteLine("满足条件执行的代码");
                if (true)
                {
                    Console.WriteLine("满足条件执行的代码");
                }
                else
                {
                    Console.WriteLine("不满足条件执行的代码");
                }
            }
            else
            {
                Console.WriteLine("不满足条件执行的代码");
                if (true)
                {
                    Console.WriteLine("满足条件执行的代码");
                }
                else
                {
                    Console.WriteLine("不满足条件执行的代码");
                }
            }
            //可以无限嵌套


            #endregion

            Console.WriteLine("**********************");

            #region 知识点四 if...else if...else语句
            //作用：产生n条分支 多条道路选择 最先执行满足条件的第一个条件语句
            /*语法：
                    if(bool类型值)
                    {
                        满足条件执行的代码;
                    }
                    else if(bool类型值)
                    {
                        满足条件执行的代码；
                    }
                  //...中间可以有n个else if语句代码块 直到满足条件为止 如果都不满足就跳转到else里执行
                    else
                    {
                        不满足条件执行的代码;
                    }
            */
            //注意：
            //1.不需要写分号；
            //2.可以嵌套；
            //3.else是可以省略的；
            //4.条件判断是从上至下执行的 若第一个满足了则之后的都不会再执行。

            if (a <= -1)
            {
                Console.WriteLine("满足条件执行的代码1");
            }
            else if(a >= 0)
            {
                Console.WriteLine("满足条件执行的代码2");
            }
            else if (a >= 1)
            {
                Console.WriteLine("满足条件执行的代码3");
            }
            else
            {
                Console.WriteLine("不满足条件执行的代码5");
            }

            //else if语句对比
            Console.WriteLine("**********************");

            if (a <= -1)
            {
                Console.WriteLine("满足条件执行的代码1");
            }
            if (a >= 0)
            {
                Console.WriteLine("满足条件执行的代码2");
            }
            if (a >= 1)
            {
                Console.WriteLine("满足条件执行的代码3");
            }
            else
            {
                Console.WriteLine("不满足条件执行的代码5");
            }


            #endregion

            Console.WriteLine("**********************");



            #region 作业

            //1.请用户输入今日看唐老狮视频花了多少分钟，
            //如果大于60分钟，那么在控制台输出“今天看视频花了XX分钟，看来你离成功又进了一步！”
            Console.WriteLine("请输入今日看唐老狮视频花了多少分钟");
            int min = int.Parse(Console.ReadLine());
            if (min > 60)
            {
                Console.WriteLine("今天看视频花了" + min + "分钟，看来你离成功又进了一步！");
            }
            else
            {
                Console.WriteLine("keep going!");
            }


            /*2.
                请输入你的 语文，数学，英语成绩，满足以下任意条件，则输出“非常棒，继续加油”
                语文成绩大于70并且 数学成绩大于80 并且英语成绩大于90
                语文成绩等于100或者数学成绩等于100或者英语成绩等于100
                语文成绩大于90 并且 其它两门中有一门成绩大于70
             */
            Console.WriteLine("请输入你的语文成绩：");
            float Chinese = float.Parse(Console.ReadLine());
            Console.WriteLine("请输入你的数学成绩：");
            float Math = float.Parse(Console.ReadLine());
            Console.WriteLine("请输入你的英语成绩：");
            float English = float.Parse(Console.ReadLine());

            if (Chinese > 70 && Math > 80 && English > 90) 
            {
                Console.WriteLine("非常棒，继续加油");
            }
            else if (Chinese == 100 || Math == 100 || English == 100)
            {
                Console.WriteLine("非常棒，继续加油");
            }
            else if (Chinese > 90 && (Math > 70 || English > 70))
            {
                Console.WriteLine("非常棒，继续加油");
            }
            else
            {
                Console.WriteLine("弱哎");
            }


            //3.定义一个变量，存储小赵的考试成绩
            //如果小赵的考试成绩大于（含）90分，那么爸爸奖励100元钱，否则一个月不能玩游戏。
                Console.WriteLine("请输入小赵的成绩：");
            int grade = int.Parse(Console.ReadLine());
            if (grade >= 90)
            {
                Console.WriteLine("爸爸奖励小赵100元钱");

            }
            else
            {
                Console.WriteLine("小赵一个月不能玩游戏");
            }


            //4.要求用户输入两个数a、b，
            //如果两个数可以整除或者这两个数加起来大于100，则输出a的值，否则输出b的值。
            Console.WriteLine("请输入a：");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入b：");
            int b = int.Parse(Console.ReadLine());
            if (a % b == 0 || b % a == 0 || a + b == 100)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }


            //5.输入一个整数，如果这个数是偶数，则打印 “Your input is even".
            //否则打印 “Your input is odd".
            try
            {
                Console.WriteLine("请输入一个整数：");
                a = int.Parse(Console.ReadLine());

                if(a%2==0)
                {
                    Console.WriteLine("Your input is even");
                }
                else 
                { 
                    Console.WriteLine("Your input is odd"); 
                }
            }

            catch 
            {
                Console.WriteLine("输入格式错误！");
            }


            //6.有3个整形变量，分别存储不同的值，编写代码输出其中最大的整数。
            Console.WriteLine("请输入a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入c:");
            int c = int.Parse(Console.ReadLine());

            int max = a;
            if (c > max)
            {
                max = c;
            }
            if (b > max)
            {
                max = b;
            }

            Console.WriteLine("最大值是" + max);


            //*7.写一个程序接受用户输入的字符，如果输入的字符是0~9数字中的一个，
            //则显示“您输入了一个数字”，否则显示这不是一个数字。
            Console.WriteLine("请输入一个字符：");
            //char类型可以隐式转换成一个数值类型
            //输出按键后立刻转为ASCII码
            int askii = Console.ReadKey().KeyChar;

            Console.WriteLine();

            if (askii >= '0' && askii <= '9')
            {
                Console.WriteLine("您输入了一个数字");
            }
            else
            {
                Console.WriteLine("这不是一个数字");
            }

            /*8.
                提示用户输入用户名，然后再提示输入密码，
                如果用户名是“admin”，并且密码是“8888”，则提示正确，
                否则，如果用户名不是admin则提示用户用户名不存在，如果用户名是admin则提示密码错误。
             */
            Console.WriteLine("请输入您的用户名：");
            string admin = Console.ReadLine();
            Console.WriteLine("请输入您的密码");
            string password = Console.ReadLine();

            if(admin == "admin" && password == "8888")
            {
                Console.WriteLine("正确");
            }
            else if (admin != "admin")
            {
                Console.WriteLine("用户名不存在");
            }
            else if(admin == "admin" && password != "8888")
            {
                Console.WriteLine("密码错误");
            }


            /*9.
                提示用户输入年龄，如果大于等于18，则告知用户可以查看，如果小于13岁，则告知不允许直看，
                如果大于等于13并且小于18，则提示用户是否继续查看（yes、no），
                如果输入的是yes则提示用户请查看，否则提示“退出”。
             */
            Console.WriteLine("请输入您的年龄：");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("可以查看。");
            }
            else if (age < 13)
            {
                Console.WriteLine("不可查看。");
            }
            else if (a >= 13 && a < 18)
            {
                Console.WriteLine("是否继续查看？（yes、no）");
                string str = Console.ReadLine();
                if (str == "yes")
                {
                    Console.WriteLine("请查看。");
                }
                else
                {
                    Console.WriteLine("退出。");
                }
            }


            /*10.
                请说明以下代码的打印结果（不要打一遍代码，请直接通过阅读说出结果）
                int a1 = 5;
                if(a1 > 3)
                { 
                    int b1 = 0;
                    ++b1;
                    b1 += a1;
                    Console.WriteLine(b1);
                }
             
             答：6
             */
            //语句块会影响变量的生命周期
            //函数语句块目前我们学习知识时，是层级更高的语句块
            /*
            int a1 = 5;
            if (a1 > 3)
            {
                int b1 = 0;
                ++b1;
                b1 += a1;
            }
            Console.WriteLine(b1);      //错误的，无法识别b
                                        //因为if函数语句块里定义的b无法放入更高层函数语句块里使用
            */
            #endregion


        }
    }
}
