using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪食蛇.Lesson1;
using 贪食蛇.Lesson3;
using 贪食蛇.Lesson6;

namespace 贪食蛇.Lesson4
{
    class Food : GameObject
    {
        //传入蛇的坐标
        public Food(Snake snake)
        {
            RandomPos(snake);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("¤");
        }
        //随机位置的行为
        //该行为和蛇的位置有关系
        public void RandomPos(Snake snake )
        {
            //随机位置
            Random r = new Random();
            int x = r.Next(2, Game.w / 2 - 1) * 2;      //让x保持为偶数
            int y = r.Next(2, Game.h - 4);
            pos = new Position(x, y);
            //得到蛇
            //如果重合 就会进if语句
            if (snake.CheckSamePos(pos))
            {
                //重新定义食物位置
                RandomPos(snake);
            }
        }
    }
}
