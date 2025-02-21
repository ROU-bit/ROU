namespace testunity1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //四个基本的操控台“输入输出”方法

            //输出
            //会自动空行
            Console.WriteLine("Hello, World!");
            //不会自动空行
            Console.Write("HI");
            Console.Write("HI");


            Console.WriteLine("起个名字吧！");//请玩家输入信息的提示


            //输入
            //检测玩家输入的信息
            //可以输入很多信息，直到按回车键结束
            //括号内不需要打双引号
            Console.ReadLine();


            Console.WriteLine("确认的话请随意按一个键。");//确认玩家名称


            //输入
            //只能摁一下按键，按完算结束
            Console.ReadKey();


            Console.WriteLine("起名成功！");
            Console.WriteLine("玩家输入完毕。");


            //总结
            /*
             输入（括号内无双引号）：
                Console.ReadLine();     可输入许多信息，直到回车键结束
                Console.ReadKey();      只可点击一个按键（任意一个按键

             输出：
                Console.WriteLine("");      自动换行
                Console.Write("");          不换行            
             */
        }
    }
}
