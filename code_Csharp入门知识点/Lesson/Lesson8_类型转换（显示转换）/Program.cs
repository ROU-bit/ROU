using System;

namespace Lesson8_类型转换_显示转换_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换——显示转换");
            //显示转换-->手动处理 强制转换
            //允许强转，但是需要注意范围，否则会出现数据异常、丢失



            #region 知识点一 括号强转
            //作用： 一般情况下，将高精度的类型强制转换为低精度
            //语法： 变量类型 变量名 = （变量类型）变量；
            //注意： 精度问题 范围问题

            //相同大类的整形（注意范围）          
            //有符号整形
            sbyte sb = 1;
            short s = 2;
            int i = 40000;
            long l = 4;

            //s = i;                    error
            s = (short)i;
            Console.WriteLine(s);       //-25536
                                        //虽然可以强转，但是会出现范围问题造成的异常
            //无符号整形（同上）



            //浮点之间（注意精度）
            float f = 5.46f;
            double d = 7.67894651329874651324;
            decimal de = 84.448m;

            de = (decimal)d;
            Console.WriteLine(de);      //7.67894651329875  精度出现问题
            d = (double)de;
            Console.WriteLine(d);       //7.67894651329875  精度出现问题
            f = (float)d;
            Console.WriteLine(f);       //7.6789465         精度出现问题



            //无符号和有符号（注意范围）
            uint ui = 88;
            int ii = 99;
            int jj = -99;
            ui = (uint)ii;
            Console.WriteLine(ui);      //99
            ui = (uint)jj;
            Console.WriteLine(ui);      //4294967197        出现问题（二进制中代表符号的第一位出现异常）


            //浮点和整形
            //浮点数强转为整型时，小数点后的数据会直接丢失，而不是四舍五入
            ii = (int)8.714f;
            Console.WriteLine(ii);      //8                 精度丢失


            //char和数值类型
            sb = (sbyte)'2';
            Console.WriteLine(sb);      //50                转为2对应的ASCII码
            char c = (char)jj;
            Console.WriteLine(c);       //?                 数据异常,因为ASCII码不可直接表示负数


            //bool和string
            //使用括号强转无效果
            bool bo = true;
            string str = "adc";
            //bo = (bool)str;           error
            //str = (string)bo;         error

            #endregion
            //主要把高精度数值转为低精度数值

            Console.WriteLine("****************************");


            #region 知识点二 Parse法
            //作用： 把字符串类型转换为对应的类型
            //语法： 变量类型.Parse("字符串")
            //注意： 字符串必须能够转换成对应类型，否则报错（即注意范围）



            //有符号
            //string str = "123";
            //int iii = int.Parse(str);
            //或者——
            int iii = int.Parse("123");
            Console.WriteLine(iii);
            //或者
            Console.WriteLine(int.Parse("123"));
            //iii = int.Parse("4613.1164");
            //Console.WriteLine(iii);               系统直接报错，因为int内没有小数，所以无法转换

            Console.WriteLine(sbyte.Parse("123"));
            Console.WriteLine(short.Parse("123"));
            Console.WriteLine(long.Parse("123"));



            //无符号
            Console.WriteLine(byte.Parse("1"));
            Console.WriteLine(uint.Parse("1"));
            Console.WriteLine(ushort.Parse("1"));
            Console.WriteLine(ulong.Parse("1"));



            //浮点数
            Console.WriteLine(float.Parse("7.558"));
            Console.WriteLine(double.Parse("7.558"));
            Console.WriteLine(decimal.Parse("7.558"));



            //特殊类型
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(char.Parse("t"));



            #endregion
            //主要把字符串转为其他类型

            Console.WriteLine("****************************");


            #region 知识点三 Convert法
            //作用： 更准确的将各个类型之间进行相互转换
            //语法： Convert.To目标类型（变量或常量）
            //注意： 填写的变量或常量必须正确，否则出错（即注意范围）



            //转字符串
            int a1 = Convert.ToInt32("12");
            Console.WriteLine(a1);                  //12
            //a1 = Convert.ToInt32("59.45");        程序报错
            
            

            //精度更准确
            a1 = Convert.ToInt32(59.85f);
            Console.WriteLine(a1);                  //60    Convert精度更高，可自动四舍五入



            //特殊类型转换
            //bool类型可转为数值类型 true为1 false为0
            a1 = Convert.ToInt32(true);
            Console.WriteLine(a1);                  //1
            a1 = Convert.ToInt32(false);
            Console.WriteLine(a1);                  //0
            //char类型转为对应ASCII码
            a1 = Convert.ToInt32('S');
            Console.WriteLine(a1);                  //83



            //每一个类型都存在对应的Convert中的方法
            //有符号整数
            
            sbyte sb1 = Convert.ToSByte('S');
            Console.WriteLine((sbyte)sb1);                          //83
            //or
            Console.WriteLine(Convert.ToSByte('S'));                //83        sbyte
            Console.WriteLine(Convert.ToInt32("-778"));             //-778      int对应Int32
            Console.WriteLine(Convert.ToInt16("456"));              //456       short对应Int16
            Console.WriteLine(Convert.ToInt64("-777"));             //-777      long对应Int64
            //无符号整数
            Console.WriteLine(Convert.ToByte("77"));                //77        byte
            Console.WriteLine(Convert.ToUInt32("777"));             //777       uint对应Int32
            Console.WriteLine(Convert.ToUInt16("777"));             //777       ushort对应Int16
            Console.WriteLine(Convert.ToUInt64("777"));             //777       ulong对应Int64

            //浮点数
            float f5 = Convert.ToSingle("13.2");                    //注意float对应的是Single
            Console.WriteLine(f5);                                  //13.2      float
            Console.WriteLine(Convert.ToDouble("456.65"));          //456.65    double
            Console.WriteLine(Convert.ToDecimal("456.64"));         //456.64    decimal

            //特殊形
            bool bo5 = Convert.ToBoolean("true");                   //注意bool对应的是Boolean
            Console.WriteLine(bo5);                                 //True      bool
            Console.WriteLine(Convert.ToChar("A"));                 //A         char
            Console.WriteLine(Convert.ToString(452));               //452       string


            #endregion
            //更全面
            //Convert方法可以将string转为其他类型

            Console.WriteLine("****************************");


            #region 知识点四 其他类型转string
            //作用： 拼接打印
            //语法： 变量.ToString();

            string str1 = 1.ToString();
            str1 = true.ToString();
            str1 = 'A'.ToString();
            str1 = 45.45f.ToString();
            //or
            int aa = 78;
            str1 = aa.ToString();

            //进行字符串拼接时会自动调用ToString转为string
            //即        str1 = "456471" + 1 + true;
            //          Console.WriteLine(str1);                    //4564711True
            Console.WriteLine("456471" + 1 + true);                 //4564711True



            #endregion
            //主要把其他类型转为字符串
            //可以更简单的将string转为其他类型

            Console.WriteLine("****************************");





            #region 作业

            /*1.显示类型转换有几种方式？他们分别是什么，请举例说明。
                ①括号强转
                  形式：变量类型 变量1 = （变量类型）变量2
                  目的：将高精度数值转为低精度数值(一定范围内)
                  EX.  
                        float a1 = 54.32f;
                        int a2 = (int)ac2;
                        Console.WriteLine(a2);
                        &
                        int a = (int)54.32f;
                        Console.WriteLine(a);
                        &
                        Console.WriteLine((int)54.65f);

                ②Parse法
                  形式：变量类型 变量 = 变量类型 Parse("字符串")
                  目的：将字符串类型转换为其他类型(一定范围内)
                  EX.
                        int a = int.Parse("6596");
                        Console.WriteLine(a);
                        &
                        Console.WriteLine(int.Parse("6596"));


                ③Convert法
                  形式：变量类型 变量1 = Convert.To变量类型(变量2)
                  目的：可将任何类型互相转换(一定范围内)
                   EX.
                        int a = Convert.ToInt32("546");
                        float b = Convert.ToSingle("785.598");
                        Console.WriteLine(a);                           //546
                        Console.WriteLine(b);                           //785.598
                        &
                        Console.WriteLine(Convert.ToBoolean(true));     //True


                ④ToString法
                  形式：string str = 其他类型变量.ToString()
                  目的：可将任意类型转为字符串（一定范围内）
                  EX.   
                        string a = 10.ToString(),
                        b = 894.464f.ToString(),
                        c = true.ToString();
                        Console.WriteLine("62gd5" + a + b + c);         //62gd510894.464True
                        &
                        int a = 10;
                        string str1 = a.ToString();
                        Console.WriteLine(a);                           //10
            */


            //2.请将24069转成字符并打印
            char strr = (char)24069;
            Console.WriteLine(strr);
            //or
            Console.WriteLine(Convert.ToChar(24069));


            //3.提示用户输入姓名、语文、数学、英语成绩、并将输入的3门成绩用整形变量存储

            Console.WriteLine("请输入您的姓名（输入完毕后按回车键提交）：");

            string strrr =Console.ReadLine();

            Console.WriteLine("请输入您的语文成绩(整数)：");
            int Chinese = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入您的数学成绩(整数)：");
            int Math = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入您的英语成绩(整数)：");
            int English = int.Parse(Console.ReadLine());

            Console.WriteLine("您的语文、数学、英语成绩分别是"+"\n" + Chinese+"\n"+ Math+ "\n" + English + "\n");


            #endregion



        }
    }
}
