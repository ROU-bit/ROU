using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪食蛇.Lesson1;
using 贪食蛇.Lesson4;
using 贪食蛇.Lesson5;
using 贪食蛇.Lesson6;

namespace 贪食蛇.Lesson2
{
    class GameScene : ISceneUpdate
    {
        Map map;
        Snake snake;
        Food food;
        int updateIndex = 0;

        public GameScene()
        {
            map = new Map();
            snake = new Snake(40,10);
            food = new Food(snake);
        }
        public void Update()
        {
            //让贪食蛇降速
            //等效于让原先每秒循环1次变为每500秒循环一次
            //除以的数越大，循环速度越慢，阈值根据电脑的性能提升
            if (updateIndex % 6000 == 0)
            {
                map.Draw();
                food.Draw();
                snake.Move();
                snake.Draw();

                //检测是否撞墙
                if (snake.CheckEnd(map))
                {
                    //执行结束逻辑
                    Game.ChangeScene(E_SceneType.End);
                }

                snake.CheckEatFood(food);

                updateIndex = 0;
            }
            ++updateIndex;

            //在控制台中检测玩家输入让程序不被卡住
            //判断有没有键盘输入 如果有才为true
            //该代码对性能有影响，会使循环变慢
            if (Console.KeyAvailable)
            {
                //检测输入输出不能在间隔帧中处理，应当每次都检测，这样才准确
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangDir(E_MoveDir.Up);
                        break;
                    case ConsoleKey.A:
                        snake.ChangDir(E_MoveDir.Left);
                        break;
                    case ConsoleKey.S:
                        snake.ChangDir(E_MoveDir.Down);
                        break;
                    case ConsoleKey.D:
                        snake.ChangDir(E_MoveDir.Right);
                        break;
                }
            }
        }

    }
}
