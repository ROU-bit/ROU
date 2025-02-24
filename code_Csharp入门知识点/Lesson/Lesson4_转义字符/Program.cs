namespace Lesson4_转义字符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 知识点一 转义字符的使用

            //什么是转义字符？
            //是字符串（string）的一部分，用来表示一些特殊含义的字符
            //EX.在字符串中表现单引号、引号、空行等等
            //string str = "hdb"dbsj";  会报错

            #region 固定写法
            //  \字符
            //  \和不同字符的组合表示不同的含义

            //常用的四个
            //单引号   \'
            string str = "\'哈哈哈\'";
            Console.WriteLine(str);

            //双引号   \"
            str = "\"哈哈哈\"";
            Console.WriteLine(str);

            //换行    \n
            str = "156456451\n458445966";
            Console.WriteLine(str);

            //斜杠    \\                  计算机文件路径需要用到此符号
            str = "哈哈\\哈";
            Console.WriteLine(str);


            //不常用
            //制表符（空一个tab键）  \t
            str = "哈\t哈哈";
            Console.WriteLine(str);

            //光标退格  \b
            str = "154\b7989";
            Console.WriteLine(str);

            //空字符   \0
            str = "154\07989";
            Console.WriteLine(str);

            //警报音   \a  窗口会弹出声音
            str = "\a";
            Console.WriteLine(str);


            //可直接在输出的字符串内添加转义字符
            Console.WriteLine("shd\niabd\anxsn\\ss");

            #endregion

            #endregion

            #region 知识点二 取消转义字符
            //在字符串前加@


            //string str1 = "哈哈哈\哈哈哈";      会报错
            string str1 = @"哈哈哈哈哈\哈哈";
            Console.WriteLine(str1);

            str1 = @"\\b\a\n\";
            Console.WriteLine(str1);

            #endregion

            #region 作业
            /*
             1.请写出至少五种转义字符
                \'、\"、\n、\\、\t、\0、\b、\a。

             2.请至少两种方式在控制台打印出：
                我是小明
                我今年18
                我的爱好是制作游戏
                我要好好学习，天天向上
             */
            Console.WriteLine("**************************");
            //①
            Console.WriteLine("我是小明");
            Console.WriteLine("我今年18");
            Console.WriteLine("我的爱好是制作游戏");
            Console.WriteLine("我要好好学习，天天向上");

            Console.WriteLine("**************************");

            //②
            Console.WriteLine("我是小明\n我今年18\n我的爱好是制作游戏\n我要好好学习，天天向上");


            #endregion


        }
    }
}
