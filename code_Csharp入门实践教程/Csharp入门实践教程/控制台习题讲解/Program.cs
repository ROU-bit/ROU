namespace 控制台习题讲解
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //项目调试
            //1.如何打断点 F9
            //2.如何一步一步看代码逻辑 F10
            //3.继续执行代码 停止一步一步的看 F5
            //4.可以通过左下角监视窗口查看想要得到的变量值


            Console.CursorVisible = false;
            //改变背景颜色
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //改变字体颜色
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            //黄色方块像人一样，有位置信息（x，y）
            int x = 0;
            int y = 0;
            
            //不停地输入wasd键都可以控制它移动（循环）

            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("■");
                char c = Console.ReadKey(true).KeyChar; //不显示输入内容
                Console.SetCursorPosition(x, y);
                Console.Write("  ");
                switch (c)
                {
                    //贯穿
                    case 'w':
                    case 'W':
                        y -= 1;     //位置往上一格
                        //改变位置过后判断新位置是否越界
                        if(y < 0)
                        {
                            y = 0;
                        }
                        break;
                    case 'a':
                    case 'A':
                        x -= 2;     //位置往左一格 中文符号在控制台上占两个位置
                        if (x < 0)
                        {
                            x = 0;
                        }
                        break;
                    case 's':
                    case 'S':
                        y += 1;     //位置往下一格
                        if(y > Console.BufferHeight - 1)
                        {
                            y = Console.BufferHeight - 1;
                        }
                        break;
                    case 'd':
                    case 'D':
                        x += 2;     //位置往右一格
                        if(x > Console.BufferWidth - 2)
                        {
                            x = Console.BufferWidth - 2;
                        }
                        break;
                }
            }
        }
    }
}
