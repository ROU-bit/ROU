namespace Lesson17_循环语句do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点一 基本语法
            //与while循环的区别
            //while循环是先判断条件再执行
            //do while循环是先斩后奏 先至少执行一次循环语句块中的逻辑 再判断是否继续

            /*
            do
            {
                //do while循环语句块
            } 
            while (bool类型的值);     //注意do while语句存在一个重要的分号
            */


            #endregion


            #region 知识点二 实际使用
            //do while 使用较少

            do
            {
                Console.WriteLine("sad");            //sad
            }
            while (false);

            int q = 1;
            do
            {
                Console.WriteLine(q);
            }
            while (q > 2);              //打印一次      1

            #endregion


            #region 知识点三 嵌套使用
            //if
            //switch
            //while
            //do while
            //上述四个可以互相嵌套

            //do while 可以使用break和continue
            do
            {
                Console.WriteLine("111");       //111
                continue;                       //该continue直接返回到下面的while条件中，所以此程序只执行一次
                                                //与while循环有所不同
            }
            while (false);

            do
            {
                Console.WriteLine("222");       //222 只执行了一次，并没有循环
                break;                       
            }
            while (true);


            #endregion


            #region 作业
            //1.要求用户输入用户名和密码，只要不是admin和8888就一直提示用户名或密码错误，请重新输入。
            try
            {
                string admin;
                int pw;
                bool bo = false;

                /*
                do
                {
                    Console.WriteLine("请输入用户名：");
                    admin = Console.ReadLine();
                    Console.WriteLine("请输入密码：");
                    pw = int.Parse(Console.ReadLine());
                    if(admin != "admin" && pw != 8888)
                    {
                        Console.WriteLine("用户名或密码错误，请重新输入！");
                    }
                    else
                    {
                        Console.WriteLine("输入正确");
                        break;
                    }
                }
                while (true);
                */

                do
                {
                    if(bo)
                    {
                        Console.WriteLine("用户名或密码错误，请重新输入！");
                    }
                    Console.WriteLine("请输入用户名：");
                    admin = Console.ReadLine();
                    Console.WriteLine("请输入密码：");
                    pw = int.Parse(Console.ReadLine());
                    bo = true;
                }
                while (admin != "admin" && pw != 8888);
            }
            catch
            {
                Console.WriteLine("输入格式错误，请重新输入！");
            }


            //2.不断提示请输入你的姓名，直到输入q结束。
            char name;
            do 
            {
                Console.WriteLine("\n请输入你的姓名");
                name = Console.ReadKey().KeyChar;
            }
            while (name != 'q');
            


            #endregion


        }
    }
}
