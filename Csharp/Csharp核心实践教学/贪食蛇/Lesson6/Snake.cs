using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪食蛇.Lesson3;
using 贪食蛇.Lesson4;
using 贪食蛇.Lesson5;

namespace 贪食蛇.Lesson6
{
    #region Lesson7 蛇移动
    enum E_MoveDir
    {
        Up,
        Down,
        Left,
        Right,
    }

    #endregion
    /// <summary>
    /// 蛇的移动方向
    /// </summary>

    class Snake : IDraw
    {
        SnakeBody[] bodys;
        //当前蛇的长度
        int nowNum;
        //当前移动的方向
        E_MoveDir dir;
        public Snake(int x, int y)
        {
            //粗暴的申明200个空间 游戏中基本不会出现蛇长度达到200个身体
            bodys = new SnakeBody[200];

            bodys[0] = new SnakeBody(E_SnakeBody_Type.Head, x, y);//?
            //初始化当前有一个身子
            nowNum = 1;
            //初始化移动方向为右
            dir = E_MoveDir.Right;
        }

        public void Draw()
        {
            //画一节一节的身体
            for (int i = 0; i < nowNum; i++)
            {
                bodys[i].Draw();
            }
        }

        #region Lesson7 蛇的移动
        public void Move()
        {
            //移动前
            //擦除最后一个位置
            SnakeBody lastbody = bodys[nowNum - 1];
            Console.SetCursorPosition(lastbody.pos.x, lastbody.pos.y);
            Console.Write("  ");

            //在蛇头移动之前 从蛇尾开始 不停地让后一个位置等于前一个的位置
            for(int i = nowNum - 1; i > 0; i--)
            {
                bodys[i].pos = bodys[i - 1].pos;
            }

            //再动
            switch (dir)
            {
                case E_MoveDir.Up:
                    --bodys[0].pos.y;
                    break;
                case E_MoveDir.Down:
                    ++bodys[0].pos.y;
                    break;
                case E_MoveDir.Left:
                    bodys[0].pos.x -= 2;
                    break;
                case E_MoveDir.Right:
                    bodys[0].pos.x += 2;
                    break;
            }
        }

        #endregion

        #region Lesson8 改变方向
        public void ChangDir(E_MoveDir dir)
        {
            //只有头部的时候可以直接左转右、右转左、上转下、下转上
            //有身体时 这种情况就不能直接转
            if(dir == this.dir || 
                nowNum > 1 && 
                (this.dir == E_MoveDir.Left && dir == E_MoveDir.Right) ||
                 (this.dir == E_MoveDir.Right && dir == E_MoveDir.Left) ||
                 (this.dir == E_MoveDir.Up && dir == E_MoveDir.Down) ||
                 (this.dir == E_MoveDir.Down && dir == E_MoveDir.Up))
            {
                return;
            }
            //只要没有return就记录外面传入的方向，之后就会按照这个方向去移动
            this.dir = dir;
        }
        #endregion

        #region Lesson9 撞墙撞身体结束逻辑
        public bool CheckEnd(Map map)
        {
            //是否和墙体位置重合
            for (int i = 0; i < map.walls.Length; i++)
            {
                if (bodys[0].pos == map.walls[i].pos)
                {
                    //结束游戏
                    return true;
                }
            }
            for (int i = 1; i < nowNum; i++)
            {
                if (bodys[0].pos == bodys[i].pos)
                {
                    //结束游戏
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Lesson10 吃食物相关
        //通过传入一个位置来判断这个位置是不是和蛇重合
        public bool CheckSamePos(Position p)
        {
            for (int i = 0; i < nowNum; i++)
            {
                if(bodys[i].pos == p)
                {
                    return true;
                }
            }
            return false;
        }
        public void CheckEatFood(Food food)
        {
            if (bodys[0].pos== food.pos)
            {
                //吃到了就应该让食物的位置再随机 增加蛇身体的长度
                food.RandomPos(this);       //this 指的是蛇自己
                //长身体
                AddBody();
            }
        }

        #endregion

        #region Lesson11 长身体
        private void AddBody()
        {
            SnakeBody frontBody = bodys[nowNum - 1];
            //先长
            bodys[nowNum] = new SnakeBody(E_SnakeBody_Type.Body, frontBody.pos.x, frontBody.pos.y);
            //再加长度
            ++nowNum;
        }
        #endregion
    }
}
