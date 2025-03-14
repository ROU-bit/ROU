using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪食蛇.Lesson1;

namespace 贪食蛇.Lesson2
{
    abstract class BeginOrEndBaseScene : ISceneUpdate
    {
        protected int nowSelIndex = 0;
        protected string strTitle;
        protected string strOne;

        public abstract void EnterJDoSomething();

        public void Update() 
        {
            //开始和结束场景的游戏逻辑
            //选择当前的选项 监听键盘输入WSJ
            Console.ForegroundColor = ConsoleColor.White;
            //显示标题
            Console.SetCursorPosition(Game.w / 2 - strTitle.Length, 5);
            Console.Write(strTitle);
            //显示下方选项
            Console.SetCursorPosition(Game.w / 2 - strOne.Length, 8);
            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(strOne);
            Console.SetCursorPosition(Game.w / 2 - 4, 10);
            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.White : ConsoleColor.Red;
            Console.Write("结束游戏");
            //检测输入
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    --nowSelIndex;
                    if (nowSelIndex < 0)
                    {
                        nowSelIndex = 0;
                    }
                    break;
                case ConsoleKey.S:
                    ++nowSelIndex;
                    if(nowSelIndex > 1)
                    {
                        nowSelIndex = 1;
                    }
                    break;
                case ConsoleKey.J:
                    EnterJDoSomething();
                    break;
            }

        }

    }
}
