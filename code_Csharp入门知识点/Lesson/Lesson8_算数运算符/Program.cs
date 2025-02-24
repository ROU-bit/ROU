namespace Lesson8_算数运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点一 赋值符号
            //赋值符号 =
            //关键知识点：先看右侧，再看左侧，把右侧的值赋值给左侧的变量
            //左边往往都是一个变量，不会是式子
            //EX.
                    string myName = "ROU";

            #endregion



            #region 知识点二 算数运算符

            #region 加 +

            #endregion

            #region 减 -

            #endregion

            #region 乘 *

            #endregion

            #region 除 /

            //整形变量做除法会直接取商，扔掉余数
            //一般用浮点数变量做除法运算，记得在数字上添f、d、m，否则默认整数
            float f1 = 1 / 2f;
            Console.WriteLine(f1);

            #endregion

            #region 取余 %

            //做除法直接扔掉商，取余数
            int i2 = 8 % 3;
            Console.WriteLine(i2);

            #endregion


            #endregion


            #region 知识点三 算数运算符的优先级
            //优先级指的是运算顺序
            //乘除取余优先级高于加减 先算乘除取余再算加减
            int i3 = 3 * 3 / 2 + 6 % 5 - 2 / 2;
            Console.WriteLine(i3);

            //括号可以改变优先级，优先计算括号内内容
            //多组括号，先算最里层，依次向外计算


            #endregion


            #region 知识点四 算术运算符的复合运算符
            //固定写法 运算符=
            //+= -+ *= /= %=
            //含义：用于 自己=自己进行加减乘除取余运算

            int i4 = 1, i5 = 1;
            i4 = i4 + 5;
            Console.WriteLine(i4);      //6
            i5+= 5;
            Console.WriteLine(i5);      //6

            //上述i5=6
            i5 *= 8 + 3 % 2;            
            Console.WriteLine(i5);      //54        先看右边后看左边

            //不能写成 i5+-*%/=1 即不能将他们混合使用

            #endregion


            #region 知识点五 算术运算符的自增减

            //自增运算符
            int a1 = 9;
            a1++;//先用再加
            Console.WriteLine(a1);      //10
            ++a1;//先加再用     
            Console.WriteLine(a1);      //11

            int a2 = 1;
            Console.WriteLine(a2++);    //1
            //a2=2
            Console.WriteLine(++a2);    //3

            int a3 = 1;
            Console.WriteLine(++a3);    //2
            Console.WriteLine(a3++);    //2
            //a3=3

            //自减运算符
            int b1 = 9;
            b1--;//先用再减
            Console.WriteLine(b1);      //8
            --b1;//先减再用     
            Console.WriteLine(b1);      //7

            int b2 = 1;
            Console.WriteLine(b2--);    //1
            //a2=0
            Console.WriteLine(--b2);    //-1

            int b3 = 1;
            Console.WriteLine(--b3);    //0
            Console.WriteLine(b3--);    //0
                                        //a3=-1



            #endregion

            Console.WriteLine("**********************************");

            #region 作业
            //1.定义一个变量存储你的年龄，十年后你的年龄是多少？请输出到控制台
            int n1 = 21;
            Console.WriteLine(n1+10);

            //2.计算一个半径为5的圆的面积和周长
            double S, C;
            int r;
            const double PI = 3.1415926;
            r = 5;
            S = PI * r * r;
            C = 2 * PI * r;
            Console.WriteLine("该圆的面积为："+S+" 周长为"+C);

            //3.计算任意三门成绩的总分、平均分打印到控制台。三门成绩均为整数类型
            int MATH = 99,
                CHINESE = 89,
                ENGLISH = 99;
            int All = MATH + CHINESE + ENGLISH;
            float Avg = All / 3f;
            Console.WriteLine("总分是：" + All + "平均分是" + Avg);

            //4.商店T恤的价格为285元/件，裤子的价格为720元/条，小李在该店卖了2件T恤和3条裤子，请计算小李该付多少钱？打3.8折后呢？
            int st = 285,
                tr = 720;
            float M = st * 2 + tr * 3;
            Console.WriteLine("小李该付" + M + "元");
            M = M * 0.38f;
            Console.WriteLine("打3.8折后小李该付" + M + "元");


            /*
             
             5. int a = 10, b= 20；
                int numberl = ++a + b；
                a = 10;
                b = 20;
                int number2 = a + b++；
                a = 10;
                b = 20;
                int number3 = a++ + ++b +a++；
                请说明 number1和number2和number3的结果

                    number1 = 31;
                    number2 = 30;
                    number3 = 42;
            
            */

            //6.有两个数a=99，b=87，请写出两种方法交换他们的值，让a=87，b=99.
            int w1 = 99,
                w2 = 87,
                w3 = w1;
            w1 = w2;
            w2 = w3;
            Console.WriteLine("w1为" + w1);
            Console.WriteLine("w2为" + w2);
            //&
            w1 = 99;
            w2 = 87;
            int ww = w1 + w2;
            w1 = ww - w1;
            w2 = ww - w2;
            Console.WriteLine("w1为" + w1);
            Console.WriteLine("w2为" + w2);


            //7.请把987652秒通过代码转为n天n小时n分钟n秒显示在控制台中.
            int s = 987652;
            int min, hour, day, s1, min1, hour1;

            min = s / 60;
            hour = min / 60;
            day = hour / 24;

            s1 = s - min * 60;
            min1 = min - hour * 60;
            hour1 = hour - day * 24;

            Console.WriteLine(day+"天"+hour1+"小时"+min1+"分"+s1+"秒");

            #endregion


        }
    }
}
