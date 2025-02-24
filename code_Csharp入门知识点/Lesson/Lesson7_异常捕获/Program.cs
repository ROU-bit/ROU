namespace Lesson7_异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 作用
            //将玩家输入的内容存储string类型的变量（容器）中
            //string str1 = Console.ReadLine();
            //Parse转字符类型时，输入的内容必须合法合规
            //int i1 = int.Parse(str1);
            //上述代码如果输入不合规内容将会报错，会给玩家带来不便

            //通过对异常捕获的学习，可以避免代码报错时造成的程序卡死现象。

            #endregion


            #region 基本语法

            //必备部分
            try
            {
                //希望进行异常捕获的代码块
                //放到try中
                //如果try中的代码报错了，将不会让程序卡死，而是跳入catch
            }
            catch
            {
                //接收来自try中的异常，执行catch中的代码，捕获异常
                //catch(Exception e)  具体报错跟踪，通过e得到try中具体的错误信息
            }
            //可选部分
            finally
            {
                //最后执行的代码，不管有没有出错都会执行其中的代码
            }


            #endregion


            #region 实践

            try
            {
                string str1 = Console.ReadLine();
                int i1 = int.Parse(str1);
                Console.WriteLine(i1);
            }
            catch
            {
                Console.WriteLine("请输入整数！");
            }
            finally
            {
                Console.WriteLine("OVER");
            }

            #endregion

            #region 作业
            //1.请用户输入一个数字，如果输入有误，则提示用户输入错误。
            try
            {
                Console.WriteLine("请输入一个数字");
                string str2 = Console.ReadLine();
                long i = long.Parse(str2);
                Console.WriteLine("您输入的数字为：" + i);
            }
            catch
            {
                Console.WriteLine("输入错误！");
            }
            finally
            {
                Console.WriteLine("执行完毕。");
            }

            //2.提示用户输入姓名、语文、数学、英语成绩、并将输入的3门成绩用整形变量存储。
            //如果输入有误，则提示用户输入错误。
            /*
            //普通解法
            try
            {

                Console.WriteLine("请输入您的姓名：");
                string str3 = Console.ReadLine();
                Console.WriteLine("您的姓名是" + str3);

                Console.WriteLine("请输入您的语文成绩（整数）：");
                int i1 = int.Parse(Console.ReadLine());
                Console.WriteLine("您的姓名是" + i1);

                Console.WriteLine("请输入您的数学成绩（整数）：");
                int i2 = int.Parse(Console.ReadLine());
                Console.WriteLine("您的姓名是" + i2);

                Console.WriteLine("请输入您的英语成绩（整数）：");
                int i3 = int.Parse(Console.ReadLine());
                Console.WriteLine("您的姓名是" + i3);

            }
            catch
            {
                Console.WriteLine("格式错误，请输入整数！");
            }
            finally
            {
                Console.WriteLine("执行完毕。");
            }
            */

            //好一点的解法
            try
            {
                Console.WriteLine("请输入您的姓名：");
                string str3 = Console.ReadLine();
                Console.WriteLine("您的姓名是" + str3);

                Console.WriteLine("请输入您的语文成绩（整数）：");
                int i1 = int.Parse(Console.ReadLine());
                Console.WriteLine("您的姓名是" + i1);
            }
            catch
            {
                Console.WriteLine("格式错误，请输入整数！");
            }
            try
            {
                Console.WriteLine("请输入您的数学成绩（整数）：");
                int i2 = int.Parse(Console.ReadLine());
                Console.WriteLine("您的姓名是" + i2);
            }
            catch
            {
                Console.WriteLine("格式错误，请输入整数！");
            }
            try
            {
                Console.WriteLine("请输入您的英语成绩（整数）：");
                int i3 = int.Parse(Console.ReadLine());
                Console.WriteLine("您的姓名是" + i3);
            }
            catch
            {
                Console.WriteLine("格式错误，请输入整数！");
            }
            finally
            {
                Console.WriteLine("执行完毕。");
            }

            #endregion



        }
    }
}
