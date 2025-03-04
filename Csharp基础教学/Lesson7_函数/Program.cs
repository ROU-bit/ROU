namespace Lesson7_函数
{
    internal class Program
    {

        #region 知识点一 基本概念
        //函数（方法）
        //本质是一块具有名称的代码块
        //可以使用函数（方法）的名称来执行该代码块
        //函数（方法）是封装代码进行重复使用的一种机制

        //函数（方法）的主要作用
        //1.封装代码
        //2.提升代码复用率（少写点代码、节约代码量）
        //3.抽象行为
        #endregion


        #region 知识点二 函数写在哪里
        //1.class语句块中
        //2.struct结构体语句块中
        #endregion


        #region 知识点三 基本语法
        /*形式：
            1       2       3                   4
          static 返回类型 函数名(参数类型 参数名1, 参数类型 参数名2,......)
         {
             函数的代码逻辑;
             函数的代码逻辑;
             函数的代码逻辑;
             ......;
                5
             return 返回值;        //如果有返回类型才返回
         }
         
         
         1 关于static  不是必须的 在没有学习类和结构体之前 都是必须要写的
         2 关于返回类型 引出一个新的关键字 void——代表没有返回值
                       可以写任意的变量类型————14种变量类型 + 复杂数据类型（数组、枚举、结构体、类class）
         3 关于函数名   使用帕斯卡命名法（每一个单词首字母都是大写）   EX. MyName
         4 关于参数     不是必须的，可以有0~n个参数 参数的类型也可以是任意变量类型————14种变量类型 + 复杂数据类型（数组、枚举、结构体、类class）
                       多个参数时，需要用逗号隔开
                       在main函数里面使用时需要用户输入的部分
                       使用驼峰命名法（从第二个单词开始大写）  EX.myName
         5 关于返回值   当返回类型不为void时 必须通过新的关键词return返回对应类型的内容
                       注意：即使是void也可以选择性使用return，但是后面不能写其他东西
         */
        #endregion


        #region 知识点四 实际运用
        //1.无参无返回值函数
        // 1    2     3     4
        static void SayHello()
        {
            Console.WriteLine("Hello World!");
            //  5 在没有返回值时 也就是返回值类型是void时 可以省略return
            //return
        }

        //2.有参无返回值函数
        // 1     2      3           4
        static void SayYourName(string name)
        {
            Console.WriteLine("你的名字是：{0}",name);
            //  5 在没有返回值时 也就是返回值类型是void时 可以省略return
            //return
        }

        //3.无参有返回值函数
        // 1     2          3     4
        static string WhatYourName()
        {
            // 5 对应返回值类型的内容 返回出去
            return "ROUMAO";
        }

        //4.有参有返回值函数
        // 1    2    3     4
        static int Sum(int a, int b)
        {
            //int c = a + b;
            //return c;
            // 5 return后可写表达式，只要表达式的结果和返回值类型是一致的就行
            return a + b;
        }

        //5.有参有多返回值函数
        //传入两个数，计算两个数的和，以及他们的平均数，将得出的结果打印出来
        //函数的返回值一定是一个类型只能对应一个内容     //EX. static 'int bool' Calc(int a, int b)就是错的
        // 1    2     3         4
        static int[] Calc(int a, int b)
        {
            int sum = a + b;
            int avg = sum / 2;
            //int[] arr = { sum, avg };
            //return arr;
            // 5
            //如果用数组作为返回值出去 那么前提是使用者知道这个数组的规则
            //缺点：如果不知道可能会在下面的输出越界
            return new int[] { sum, avg };
        }

        #endregion


        #region 知识点五 关于return
        //即使函数没有返回值 也可以使用return
        //return可以直接不执行之后的代码，直接返回到*函数外部*

        static void Speak(string str)
        {
            if(str == "混蛋")
            {
                return;
            }
            Console.WriteLine(str);
        }
        
        #endregion

        //总结
        //1.基本概念
        //2.函数写在哪里 ———— class 或者 struct 中
        //3.基本语法 1 2 3 4 5
        //4.return可以提前结束函数逻辑    //因为程序是线性执行的 从上到下执行


        static void Main(string[] args)
        {
            //1.使用函数 直接写函数名（参数）即可
            SayHello();         //Hello World!


            //2.参数可以是常量、变量、函数
            //  参数一定是传一个能得到对应类型的表达式
            string str1 = "ROU";
            //传入一个string变量
            SayYourName(str1);       //你的名字是：ROU
            //传入一个string常量
            SayYourName("MAO");     //你的名字是：MAO


            //3.有返回值的函数要么直接拿返回值来用、要么拿变量来接收它的结果等后面再使用
            //传入一个返回值时string的函数
            SayYourName(WhatYourName());    //你的名字是：ROUMAO
            //拿变量来接收它的结果等后面再使用
            string str2 = WhatYourName();
            Console.WriteLine(str2);        //ROUMAO
            //直接调用 但是返回值对我们来说就没用了
            //一般不会直接这样使用 除非只想让它执行一遍 但是又不想用它的返回值
            //WhatYourName();


            //4.    
            Console.WriteLine(Sum(2, 5));       //7


            //5.
            int[] arr = Calc(2, 6);
            Console.WriteLine(arr[0] + " " + arr[1]);       //8  4


            //知识点5 关于return
            Speak("混蛋");            //
            Speak("哇塞");            //哇塞

        }
    }
}
