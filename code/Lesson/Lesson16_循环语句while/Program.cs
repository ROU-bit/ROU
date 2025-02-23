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


            #region 作业
            //1.在控制台输出1到100。




            #endregion


        }
    }
}
