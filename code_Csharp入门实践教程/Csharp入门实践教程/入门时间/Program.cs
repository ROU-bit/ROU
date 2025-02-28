namespace 入门时间
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1 控制台基础设置

            //隐藏光标
            Console.CursorVisible = false;
            //通过两个变量来存储舞台大小，方便后续的更改操作
            int stageWidth = 50;
            int stageHeight = 30;
            //设置舞台大小
            Console.SetWindowSize(stageWidth, stageHeight);
            Console.SetBufferSize(stageWidth, stageHeight);

            #endregion

            #region 2 多个场景
            //当前所在场景的编号
            int nowSceneID = 1;

            while (true)
            {
                //根据不同的场景ID 进行不同的逻辑处理
                switch (nowSceneID)
                {
                    #region case1 开始场景相关
                    case 1:
                        Console.Clear();        //切换到其他场景时，先把本场景删除

                        Console.SetCursorPosition(stageWidth / 2 - 6, 4);
                        Console.Write("ROUU营救公主");

                        //当前选项的编号
                        int nowSelIndex = 0;

                        //因为要输入 我们可以构造一个开始界面自己的死循环
                        //专门用来处理“开始场景”的相关逻辑
                        while (true)
                        {
                            //用一个标识来处理想要在while循环内部的switch逻辑执行时
                            //希望退出外层while循环的操作 只需改变标识
                            bool isQuitWhile = false;
                            //显示内容
                            Console.SetCursorPosition(stageWidth / 2 - 4, 8);
                            //根据当前选择的编号选择是否变色
                            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("开始游戏");

                            Console.SetCursorPosition(stageWidth / 2 - 4, 10);
                            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            //检测输入
                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelIndex;
                                    if (nowSelIndex < 0)
                                    {
                                        nowSelIndex = 0;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    ++nowSelIndex;
                                    if (nowSelIndex > 1)
                                    {
                                        nowSelIndex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if(nowSelIndex == 0)
                                    {
                                        //改变当前选择的场景ID
                                        nowSceneID = 2;
                                        //退出外层while循环
                                        isQuitWhile = true;
                                    }
                                    else
                                    {
                                        //关闭控制台
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            if (isQuitWhile)
                            {
                                break;
                            }
                        }
                        break;

                    #endregion

                    //游戏场景
                    case 2:
                        Console.Clear();

                        #region 不变的红墙
                        //设置颜色为红色
                        Console.ForegroundColor = ConsoleColor.Red;
                        //数值的范围循环用for
                        
                        for (int i = 0; i < stageWidth ; i+=2)
                        {
                            //画上方墙
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");

                            //画下方墙
                            Console.SetCursorPosition(i, stageHeight - 1);
                            Console.Write("■");

                            //画中间墙
                            Console.SetCursorPosition(i, stageHeight - 6);
                            Console.Write("■");
                        }
                        
                        for (int i = 0; i < stageHeight; i++)
                        {
                            //画左方墙
                            Console.SetCursorPosition(0, i);
                            Console.Write("■");

                            //画右方墙
                            Console.SetCursorPosition(stageWidth - 2, i);
                            Console.Write("■");
                        }

                        #endregion

                        #region boss属性相关
                        //位置
                        int bossX = 25;
                        int bossY = 15;
                        int bossAtkMin = 7;
                        int bossAtkMax = 13;
                        int bossHp = 100;
                        string bossIcon = "■";
                        //申明一个颜色变量
                        ConsoleColor bossColor = ConsoleColor.Green;

                        #endregion

                        #region 玩家属性相关
                        int playerX = 4;
                        int playerY = 5;
                        int playerAtkMin = 8;
                        int playerAtkMax = 12;
                        int playerHp = 100;
                        string playerIcon = "●";
                        ConsoleColor playerColor = ConsoleColor.Yellow;
                        //玩家输入内容 外面申明 节约性能
                        char playerInput;

                        #endregion

                        //游戏场景的死循环 专门用来检测玩家输入相关循环
                        while (true)
                        {
                            #region boss属性相关
                            if (bossHp > 0)
                            {
                                //boss活着时绘制boss图标
                                Console.SetCursorPosition(bossX, bossY);
                                Console.ForegroundColor = bossColor;
                                Console.Write(bossIcon);
                            }
                            #endregion

                            #region 玩家移动相关
                            //画出玩家
                            Console.SetCursorPosition(playerX, playerY);
                            Console.ForegroundColor = playerColor;
                            Console.Write(playerIcon);
                            //得到玩家输入
                            playerInput = Console.ReadKey(true).KeyChar;
                            //擦除
                            Console.SetCursorPosition(playerX, playerY);
                            Console.Write("  ");
                            //该位置
                            switch (playerInput)
                            {
                                case 'W':
                                case 'w':
                                    --playerY;
                                    if (playerY < 1)
                                    {
                                        playerY = 1;
                                    }
                                    //若位置与boss重合，且boss没有死
                                    else if (playerX == bossX && playerY == bossY && bossHp > 0) 
                                    {
                                        //拉回去
                                        ++playerY;
                                    }
                                    break;

                                case 'A':
                                case 'a':
                                    playerX -= 2;
                                    if(playerX < 2)
                                    {
                                        playerX = 2;
                                    }
                                    else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                    {
                                        playerX += 2;
                                    }
                                    break;

                                case 'S':
                                case 's':
                                    ++playerY;
                                    if (playerY > stageHeight - 7)
                                    {
                                        playerY = stageHeight - 7;
                                    }
                                    else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                    {
                                        --playerY;
                                    }
                                    break;

                                case 'D':
                                case 'd':
                                    playerX += 2;
                                    if (playerX > stageWidth - 4)
                                    {
                                        playerX = stageWidth - 4;
                                    }
                                    else if(playerX == bossX && playerY == bossY && bossHp > 0) 
                                    {
                                        playerX -= 2 ;
                                    }
                                    break;

                                case 'J':
                                case 'j':
                                    //开始战斗
                                    if ((playerX == bossX && playerY == bossY - 1 ||
                                        playerX == bossX && playerY == bossY +1 ||
                                        playerX == bossX - 2 && playerY == bossY ||
                                        playerX == bossX + 2 && playerY == bossY ) && bossHp > 0)
                                    {
                                        //可以开始战斗
                                        Console.SetCursorPosition(2, stageHeight - 5);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write("开始和BOSS战斗了，按J键继续");
                                        Console.SetCursorPosition(2, stageHeight - 4);
                                        Console.Write("玩家当前血量为"+ playerHp);
                                        Console.SetCursorPosition(2, stageHeight - 3);
                                        Console.WriteLine("boss当前血量为"+ bossHp);
                                    }
                                    //让玩家不能再移动
                                    //下方能够显示信息
                                    break;

                            }







                            #endregion

                        }






                        //游戏逻辑的死循环

                        break;

                    //结束场景
                    case 3:
                        Console.Clear();
                        Console.WriteLine("结束场景");
                        break;
                }

            }







            #endregion





        }
    }
}
