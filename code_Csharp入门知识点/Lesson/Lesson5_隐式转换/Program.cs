namespace Lesson5_隐式转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //什么是类型转换
            //就是不同变量类型之间的相互转换
            //基本规则：不同类型之间的自动转换
            //          大范围装小范围(前大后小)


            #region 知识点一 相同大类型之间的转换

            //有符号：  sbyte--->short--->int--->long
            sbyte sb = 1;
            short s = 1;
            int i = 1;
            long l = 1;

            l = i;//int隐式转换成了long
                  //大范围可装小范围(前大后小)
                  //i = l;    会报错，因为小范围不能装大范围
                  //更多可行隐式转换——
            l = s;
            l = sb;
            i= s;
            i = sb;
            s = sb;


            //无符号：  byte--->ushort--->uint--->ulong
            //规则同上


            //浮点型：  float      double      decimal
            float f = 1.1f;
            double d  = 1.0;
            decimal de = 1.3m;
            //特殊：decimal没法用隐式转换的方式储存double和float
                        //de = d;   报错
                        //de = f;   报错
            d = f;
            //f = d;    error


            //特殊型：  bool       string      char
            //它们之间不存在隐式转换，各自为政，彼此之间没什么关系。

            #endregion


            #region 知识点二 不同大类型之间的转换

            #region 无符号和有符号之间
            //无符号
            byte by2 = 1;
            ushort us2 = 2;
            uint ui2 = 3;
            ulong ul2 = 3;
            //有符号
            sbyte sb2 = 1;
            short s2 = 1;
            int i2 = 1;
            long l2 = 1;

            //无符号装有符号   装不了，因为不能装负数，即不能隐式转换。
            //by2 = sb2;    报错

            //有符号装无符号   可以装，前提是无符号的变量在有符号的变量范围内。
            //i2 = ui2；    报错
            i2 = by2;       //不报错，因为byte的范围比int小，能被int包含。


            //综上所述
            //byte--->ushort--->uint--->ulong
            //sbyte--->short--->int--->long

            #endregion

            #region 浮点数和整数（有、无符号）之间
            float f2 = 1.1f;
            double d2 = 1.0;
            decimal de2 = 1.3m;

            //浮点数装整数
            //所有整数型--->float--->double
            //所有整数型--->decimal

            //f2 = d2;      error
            //浮点数可以装任何类型的整数型    EX——
            f2 = ul2;
            f2 = i2;
            f2 = s2;
            f2 = sb2;

            f2 = 100000000000000000;
            Console.WriteLine(f2);      //输出结果为1E+17，即1*10的17次方。
                                        //在超过float能表示的范围时，会用科学计数法来表示。
            d2 = us2;
            //decimal虽然不能装float、double，但是可以装整数型。
            de2 = ui2;



            //整数装浮点数
            //整数型不能表示小数，所以不能隐式存储浮点型。


            #endregion

            #region 特殊类型和其他类型之间
            bool bo2 = true;
            char c2 = 'A';
            string str2 = "uasg";

            //bool
            //bool无法和其他类型相互隐式转换
            ////bo2 = i2;       error
            ////bo2 = f2;       error
            //i2 = bo2;         error
            //f2 = bo2;         error
            //bo2 = c2;         error
            //bo2 = str2;       error
            //c2 = bo2;         error
            //str2 = bo2;       error


            //char
            //char无法隐式存储其他类型的变量
            //c2 = i2;          error
            //c2 = f2;          error
            //c2 = str2;        error

            //char可以隐式转换为部分整形和全部浮点型（转为ASSCII码）
            //char隐式转为整型时转为了int类型，然后再以int形式转换为其他类型
            //s2 = c2;          error       因为无法隐式存储int，所以也无法存储char


            //char隐式转换成数值类型，对应的数字是一个ASCII码
            //ASCII码：将字符、中文、英文、标点符号转换为计算机里的数字
            //一个字符对应一个数字，ASCII码就是一种对应关系
            i2 = c2;
            Console.WriteLine(i2);      //65
            f2 = c2;
            Console.WriteLine(f2);      //65
            ui2 = c2;
            Console.WriteLine(ui2);     //65
            de2 = c2;
            Console.WriteLine(de2);     //65

            //str2 = c2;


            //string        无法和其他类型进行隐式转换
            //i2 = str2;    error
            //str2 = i2;    error
            //f2 = str2;    error
            //str2 = f2;    error
            //c2 = str2;    error
            //str2 = c2;    error

            #endregion

            #endregion


            //总结 隐式转换
            //高精度（大范围）装低精度（小范围）
            //存储关系
            //double--->float--->整数型（有、无符号）--->char
            //decimal--->整数型（有、无符号）--->char
            //string 和 bool不参与隐式转换规则

            Console.WriteLine("************************************");


            #region 作业
            /*
             1.什么情况下会出现数据类型的隐式转换，请举例说明。
                *高精度（大范围）存储低精度（小范围）时。
                double--->float--->整数型（有、无符号）--->char
                decimal--->整数型（有、无符号）--->char
                long--->int--->short--->sbyte
                ulong--->uint--->ushort--->byte
                无符号无法隐式转换为有符号
                有符号可以根据*规则存储无符号     EX.long--->uint--->ushort--->byte
                                                     int--->ushort--->byte
                                                     short--->byte
                bool和string不参与隐式转换规则


             2.请将自己的名字的每一个字符转换成数字并打印出来。
                chengsiqi
             */
            char a1 = 'c', a2 = 'h', a3 = 'e', a4 = 'n', a5 = 'g',a6 = 's', a7 = 'i', a8 = 'q', 
                 a9 = '程', a10 = '思',a11 = '琦';
            int ii;
            ii = a1;
            Console.WriteLine(ii);
            ii = a2;
            Console.WriteLine(ii);
            ii = a3;
            Console.WriteLine(ii);
            ii = a4;
            Console.WriteLine(ii);
            ii = a5;
            Console.WriteLine(ii);
            ii = a6;
            Console.WriteLine(ii);
            ii = a7;
            Console.WriteLine(ii);
            ii = a8;
            Console.WriteLine(ii);
            int ii1 = a9;
            Console.WriteLine(ii1);
            int ii2 = a10;
            Console.WriteLine(ii2);
            int ii3 = a11;
            Console.WriteLine(ii3);
            Console.WriteLine("我的姓名编号为："+ii1+ii2+ii3);

            #endregion

        }
    }
}
