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
            //case3场景声明游戏失败与否的文本
            string gameOverInfo = "";

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
                        int playerX = 5;
                        int playerY = 5;
                        int playerAtkMin = 8;
                        int playerAtkMax = 12;
                        int playerHp = 100;
                        string playerIcon = "●";
                        ConsoleColor playerColor = ConsoleColor.Yellow;
                        //玩家输入内容 外面申明 节约性能
                        char playerInput;
                        //判断是否在战斗状态
                        bool isFight = false;
                        //作用是从while循环内部的switch改变标识 用来跳出外层的while循环
                        bool isOver = false;


                        #endregion

                        #region 公主相关
                        int princessX = 23;
                        int princessY = 4;
                        string princessIcon = "★";
                        ConsoleColor princessColor = ConsoleColor.Blue;


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

                            #region 拯救公主相关
                            else
                            {
                                //boss死后绘制公主
                                Console.SetCursorPosition(princessX, princessY);
                                Console.ForegroundColor = princessColor;
                                Console.Write(princessIcon);
                            }
                            #endregion


                            //画出玩家
                            Console.SetCursorPosition(playerX, playerY);
                            Console.ForegroundColor = playerColor;
                            Console.Write(playerIcon);
                            //得到玩家输入
                            playerInput = Console.ReadKey(true).KeyChar;
                            //检测玩家状态
                            //战斗状态
                            if (isFight)
                            {
                                //让玩家不能再移动,即不能运行wasd switch中的代码
                                
                                if (playerInput == 'j' || playerInput == 'J')
                                {
                                    //此处判断战斗回合是否结束
                                    if (playerHp <= 0)
                                    {
                                        //游戏结束
                                        //输了之后直接显示界面3
                                        nowSceneID = 3;
                                        gameOverInfo = "游戏失败";
                                        break;
                                    }
                                    else if(bossHp <= 0)
                                    {
                                        //去营救公主
                                        //boss消失（擦除）
                                        Console.SetCursorPosition(bossX, bossY);
                                        Console.Write("  ");
                                        isFight = false;
                                        //break;               //此处不能break，否则会重新回到最外圈的while循环执行一遍
                                                               //从而使外圈while重新运行switch语句，即再次运行case2

                                    }
                                    //boss和玩家都没死的话执行下面的代码
                                    else
                                    {
                                        //去处理摁J键后的状态

                                        //玩家打怪物
                                        Random r = new Random();
                                        //玩家攻击力取随机数
                                        int atk = r.Next(playerAtkMin, playerAtkMax);
                                        //boss血量
                                        bossHp -= atk;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        //显示新文字之前先擦除此行上次显示的内容
                                        Console.SetCursorPosition(2, stageHeight - 4);
                                        Console.Write("                                           ");
                                        //再显示新信息
                                        Console.SetCursorPosition(2, stageHeight - 4);
                                        Console.WriteLine("你对boss造成了{0}伤害,boss剩余血量为{1}", atk, bossHp);

                                        //怪物打玩家
                                        if (bossHp > 0)
                                        {
                                            //得到随机攻击力
                                            atk = r.Next(bossAtkMin, bossAtkMax);
                                            playerHp -= atk;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            //显示新文字之前先擦除此行上次显示的内容
                                            Console.SetCursorPosition(2, stageHeight - 3);
                                            Console.Write("                                           ");
                                            //再显示新信息


                                            //boss把玩家打死了
                                            if (playerHp <= 0)
                                            {
                                                Console.SetCursorPosition(2, stageHeight - 3);
                                                Console.Write("很遗憾，你战败了。");
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(2, stageHeight - 3);
                                                Console.Write("boss对你造成了{0}伤害,你的剩余血量为{1}", atk, playerHp);
                                            }
                                        }
                                        else
                                        {
                                            //删除玩家对boss造成伤害的语句提示
                                            Console.SetCursorPosition(2, stageHeight - 4);
                                            Console.Write("                                           ");
                                            //删除boss对玩家造成伤害的语句提示
                                            Console.SetCursorPosition(2, stageHeight - 3);
                                            Console.Write("                                           ");
                                            //删除进入战斗的语句提示
                                            Console.SetCursorPosition(2, stageHeight - 5);
                                            Console.Write("                                           ");

                                            Console.SetCursorPosition(2, stageHeight - 4);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("恭喜你，击败boss！快去拯救公主吧~");
                                            Console.SetCursorPosition(2, stageHeight - 3);
                                            Console.Write("前往公主身边按J键继续");
                                        }
                                    }
                                }
                            }
                            //非战斗状态      
                            else
                            {
                                #region 玩家移动相关
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
                                        else if (playerX == princessX && playerY == princessY && bossHp <= 0)
                                        {
                                            //拉回去
                                            ++playerY;
                                        }
                                        break;

                                    case 'A':
                                    case 'a':
                                        playerX -= 2;
                                        if (playerX < 2)
                                        {
                                            playerX = 2;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            playerX += 2;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp <= 0)
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
                                        else if (playerX == princessX && playerY == princessY && bossHp <= 0)
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
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            playerX -= 2;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp <= 0)
                                        {
                                            playerX -= 2;
                                        }
                                        break;

                                    #region 主角和boss战斗
                                    //开始战斗
                                    case 'J':
                                    case 'j':
                                        //玩家图标不可和boss图标重合
                                        if ((playerX == bossX && playerY == bossY - 1 ||
                                            playerX == bossX && playerY == bossY + 1 ||
                                            playerX == bossX - 2 && playerY == bossY ||
                                            playerX == bossX + 2 && playerY == bossY) && bossHp > 0)
                                        {
                                            //可以开始战斗
                                            isFight = true;
                                            Console.SetCursorPosition(2, stageHeight - 5);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("开始和BOSS战斗了，按J键继续");
                                            Console.SetCursorPosition(2, stageHeight - 4);
                                            Console.Write("玩家当前血量为" + playerHp);
                                            Console.SetCursorPosition(2, stageHeight - 3);
                                            Console.WriteLine("boss当前血量为" + bossHp);
                                            //下方能够显示信息
                                        }
                                        //玩家图标不可和princess图标重合
                                        else if((playerX == princessX && playerY == princessY - 1 ||
                                            playerX == princessX && playerY == princessY + 1 ||
                                            playerX == princessX - 2 && playerY == princessY ||
                                            playerX == princessX + 2 && playerY == princessY) && bossHp <= 0)
                                        {
                                            //改变场景ID，跳出游戏界面的while循环，回到主循环
                                            nowSceneID = 3;
                                            gameOverInfo = "游戏通关";
                                            isOver = true;
                                            break;
                                            
                                        }
                                        break;
                                        #endregion
                                }
                                #endregion
                            }

                            //外层while循环逻辑
                            if (isOver)
                            {
                                //与最外层while配对
                                //若isOver为true 退出最外层while循环
                                break;
                            }

                        }
                        //停止玩家输入交互switch
                        break;

                    //结束场景
                    case 3:
                        Console.Clear();

                        #region 结束场景
                        //标题显示
                        Console.SetCursorPosition(stageWidth / 2 - 4, 5);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("GameOver");
                        //根据成功和失败显示不同文本
                        Console.SetCursorPosition(stageWidth / 2 - 4, 7);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(gameOverInfo);

                        int nowSelEndIndex = 0;

                        while (true)
                        {
                            bool isEnd = false;

                            Console.SetCursorPosition(stageWidth / 2 - 6, 9);
                            Console.ForegroundColor = nowSelEndIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("回到开始界面");

                            Console.SetCursorPosition(stageWidth / 2 - 4, 11);
                            Console.ForegroundColor = nowSelEndIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            char input = Console.ReadKey(true).KeyChar;

                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelEndIndex;
                                    if (nowSelEndIndex < 0)
                                    {
                                        nowSelEndIndex = 0;
                                    }
                                    break;

                                case 'S':
                                case 's':
                                    ++nowSelEndIndex;
                                    if (nowSelEndIndex > 1)
                                    {
                                        nowSelEndIndex = 1;
                                    }
                                    break;

                                case 'J':
                                case 'j':
                                    if (nowSelEndIndex == 0)
                                    {
                                        //返回开始界面
                                        nowSceneID = 1;
                                        isEnd = true;
                                    }
                                    else
                                    {
                                        //关闭控制台
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            //与外圈的while配对
                            //为了从switch中跳出外圈的while循环
                            if (isEnd)
                            {
                                break;
                            }
                        }
                        break;
                        #endregion

                }
            }
            #endregion
        }
    }
}

#region 总结
/*
 养成良好的学习习惯：
 1.流程图（树状图
）
 2.断点学习法
 3.练习
 
 */



#endregion
