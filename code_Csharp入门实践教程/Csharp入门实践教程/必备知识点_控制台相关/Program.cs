namespace 必备知识点_控制台相关
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 复习输入输出
            //输出 
            //Console.WriteLine("123");
            //Console.Write("456");

            ////输入
            //string str = Console.ReadLine();
            //在Console.ReadKey()的括号中加一个true，并不会把输入的内容显示在控制台上
            //char c = Console.ReadKey(true).KeyChar;     //什么也没有

            //Console.WriteLine(c);                       //输出上面输入的东西

            #endregion


            #region 知识点二 控制台其他方法
            //1.清空
            Console.Clear();

            //2.设置控制台大小
            ///窗口大小SetWindowSize()
            //缓冲区大小SetBufferSize()
            //注意：
            //1.先设置窗口大小，再设置缓冲区大小；
            //2.缓冲区的大小不能小于窗口的大小；
            //3.窗口的大小不能大于控制台的最大尺寸（由屏幕分辨率决定）
            //窗口大小
            Console.SetWindowSize(100, 30);     //本电脑可支持范围是（189,49）
            //缓冲区大小（可打印内容区域的宽高）
            Console.SetBufferSize(1000, 80);

            //**3.设置光标的位置SetCursorPosition()
            //控制台左上角为原点（0,0） 右侧是X轴正方向 下侧是Y轴正方向 它是一个平面二维坐标系
            //注意：
            //1.边界问题（在缓冲区的范围内）
            //2.横纵距离单位不同 y=2x （视觉上）y轴变化更明显

            Console.SetCursorPosition(10, 5);
            Console.WriteLine("123132");

            //4.设置颜色相关
            //**文字颜色设置ForegroundColor
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("123132");        //后续所有颜色都会变成红色
            Console.ForegroundColor= ConsoleColor.Green;

            //背景颜色设置BackgroundColor
            //Console.BackgroundColor = ConsoleColor.White;
            ////重置背景颜色之后需要clear一次，才能把整个背景颜色改变
            //Console.Clear();

            //5.光标显影CursorVisible
            Console.CursorVisible = false;

            //6.关闭控制台Environment.Exit()
            Environment.Exit(0);

            #endregion




        }
    }
}
