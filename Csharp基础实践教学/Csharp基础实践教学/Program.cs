using System.Numerics;

namespace Csharp基础实践教学
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 控制台初始化
            int w = 50;
            int h = 30;
            ConsoleInit(w, h);
            #endregion

            #region 2 场景选择相关
            //申明一个表示场景标识的变量
            E_SceneType nowSenceType = E_SceneType.Begin;
            while (true) 
            {
                switch (nowSenceType)
                {
                    case E_SceneType.Begin:
                        //开始场景逻辑
                        Console.Clear();
                        BeginOrEndSence(w, h, ref nowSenceType);
                        break;

                    case E_SceneType.Game:
                        //游戏场景逻辑
                        Console.Clear();
                        //通过函数来处理游戏场景逻辑内容
                        GameScene(w, h, ref nowSenceType);
                        break;

                    case E_SceneType.End:
                        //结束场景逻辑
                        Console.Clear();
                        BeginOrEndSence(w, h, ref nowSenceType);





                        break;

                    default:
                        break;
                }
            }
            #endregion
        }

        #region 1 控制台初始化(函数)
        static void ConsoleInit(int w, int h)
        {
            //基础设置
            //光标的隐藏
            Console.CursorVisible = false;
            //舞台的大小
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
        }
        #endregion

        #region 3 开始场景逻辑(函数) + 8 结束场景逻辑
        static void BeginOrEndSence(int w, int h, ref E_SceneType nowSenceType)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(nowSenceType == E_SceneType.Begin ? w / 2 - 3 : w / 2 - 4, 8);
            Console.Write(nowSenceType == E_SceneType.Begin ? "飞行棋" : "游戏结束");

            //当前选项的编号
            int nowSelIndex = 0;
            bool isQuitBegin = false;   

            //开始场景逻辑处理循环
            while (true)
            {
                Console.SetCursorPosition(nowSenceType == E_SceneType.Begin ? w / 2 - 4 : w / 2 - 5, 13);
                Console.ForegroundColor = nowSelIndex== 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write(nowSenceType == E_SceneType.Begin ? "开始游戏" : "回到主菜单");
                Console.SetCursorPosition(w / 2 - 4, 15);
                Console.ForegroundColor = nowSelIndex== 1 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("退出游戏");

                //通过ReadKey可以得到一个输入的枚举类型
                switch (Console.ReadKey(true).Key)
                {
                    //既包含W、又包含w
                    case ConsoleKey.W:
                        --nowSelIndex;
                        if (nowSelIndex < 0)
                        {
                            nowSelIndex = 0;
                        }
                        break;
                    case ConsoleKey.S:
                        ++nowSelIndex;
                        if (nowSelIndex > 1)
                        {
                            nowSelIndex = 1;
                        }
                        break;
                    case ConsoleKey.J:
                        if (nowSelIndex == 0)
                        {
                            //进入游戏场景
                            //1 改变当前场景ID
                            nowSenceType = nowSenceType == E_SceneType.Begin ? E_SceneType.Game : E_SceneType.Begin;
                            //2 退出当前循环
                            isQuitBegin = true;
                        }
                        else
                        {
                            //退出游戏
                            Environment.Exit(0);
                        }
                        break;
                }
                //通过标识决定是否跳出开始场景的循环
                if (isQuitBegin)
                {
                    break;
                }
            }
        }
        #endregion

        #region 4 游戏场景逻辑
        static void GameScene(int w, int h, ref E_SceneType nowSenceType )
        {
            //绘制不变的地图
            DrawWall(w, h);

            //绘制地图
            //初始化一张地图
            Map map = new Map(14, 3, 80);
            map.Draw();

            //绘制玩家
            Player player = new Player(0, E_PlayerType.Player);
            Player computer = new Player(0, E_PlayerType.Computer);
            DrawPlayer(player, computer, map);


            bool isGameOver = false;
            //游戏场景循环
            while (true)
            {
                //之后的游戏逻辑

                ////检测玩家输入
                //Console.ReadKey(true);
                ////扔骰子的逻辑
                //isGameOver = RandomMove(w, h, ref player, ref computer, map);
                ////绘制地图
                //map.Draw();
                ////绘制玩家
                //DrawPlayer(player, computer, map);
                ////判断是否要结束游戏
                //if (isGameOver)
                //{
                //    //卡住程序 让玩家摁任意键
                //    Console.ReadKey(true);
                //    //改变场景ID
                //    nowSenceType = E_SceneType.End;
                //    //直接跳出循环
                //    break;
                //}
                
                //玩家扔骰子
                if (PlayerRandomMove(w, h, ref player, ref computer, map, ref nowSenceType))
                {
                    break;
                }
                //人机扔骰子
                if (PlayerRandomMove(w, h, ref computer, ref player, map, ref nowSenceType))
                {
                    break;
                }

                ////检测人机输入
                //Console.ReadKey(true);
                ////扔骰子的逻辑
                //isGameOver = RandomMove(w, h, ref computer, ref player, map);
                ////绘制地图
                //map.Draw();
                ////绘制玩家
                //DrawPlayer(player, computer, map);
                ////判断是否要结束游戏
                //if (isGameOver)
                //{
                //    //卡住程序 让玩家摁任意键
                //    Console.ReadKey(true);
                //    //改变场景ID
                //    nowSenceType = E_SceneType.End;
                //    //直接跳出循环
                //    break;
                //}
            }
        }

        static bool PlayerRandomMove(int w,int h, ref Player p, ref Player otherP, Map map,ref E_SceneType nowSenceType)
        {
            //之后的游戏逻辑

            //检测玩家输入
            Console.ReadKey(true);
            //扔骰子的逻辑
            bool isGameOver = RandomMove(w, h, ref p, ref otherP, map);
            //绘制地图
            map.Draw();
            //绘制玩家
            DrawPlayer(p, otherP, map);
            //判断是否要结束游戏
            if (isGameOver)
            {
                //卡住程序 让玩家摁任意键
                Console.ReadKey(true);
                //改变场景ID
                nowSenceType = E_SceneType.End;
                //直接跳出循环
            }
            return isGameOver;
        }

        #region 4 绘制不变内容(红墙、游戏提示)（函数）
        static void DrawWall(int w, int h)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //画墙
            //横着的墙
            for (int i = 0; i < w; i += 2)
            {
                //最上方的墙
                Console.SetCursorPosition(i, 0);
                Console.Write("■");
                //最下方的墙
                Console.SetCursorPosition(i, h - 1);
                Console.Write("■");
                //中间的墙
                Console.SetCursorPosition(i, h - 6);
                Console.Write("■");
                Console.SetCursorPosition(i, h - 11);
                Console.Write("■");
            }
            //竖着的墙
            for (int i = 0; i < h; i++)
            {
                //最左边的墙
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                //最右边的墙
                Console.SetCursorPosition(w - 2, i);
                Console.Write("■");
            }

            //文字信息
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, h - 10);
            Console.Write("□:普通格子");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(2, h - 9);
            Console.Write("‖:暂停 一回合不动");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(26, h - 9);
            Console.Write("●:炸弹 倒退五格");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(2, h - 8);
            Console.Write("¤:时空隧道 随机倒退、暂停、换位置");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(2, h - 7);
            Console.Write("★:玩家");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(12, h - 7);
            Console.Write("▲:人机");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(22, h - 7);
            Console.Write("◎:玩家和人机重合");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, h - 5);
            Console.Write("按任意键开始扔骰子");
        }
        #endregion

        #region 7 绘制玩家
        static void DrawPlayer(Player player, Player computer, Map map)
        {
            //重合时
            if (player.nowIndex == computer.nowIndex)
            {
                //得到重合的位置
                Grid grid = map.grids[player.nowIndex];
                Console.SetCursorPosition(grid.pos.x, grid.pos.y);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("◎");
            }
            //不重合时
            else
            {
                player.Draw(map);
                computer.Draw(map);
            }
        }
        #endregion

        #region 8 扔骰子函数

        static void CleanInfo(int h)
        {
            //擦除提示的函数
            Console.SetCursorPosition(2, h - 5);
            Console.Write("                                      ");
            Console.SetCursorPosition(2, h - 4);
            Console.Write("                                      ");
            Console.SetCursorPosition(2, h - 3);
            Console.Write("                                      ");
            Console.SetCursorPosition(2, h - 2);
            Console.Write("                                      ");
        }
        /// <summary>
        /// 扔骰子函数
        /// </summary>
        /// <param name="w">窗口的宽</param>
        /// <param name="h">窗口的高</param>
        /// <param name="p">扔骰子的对象</param>
        /// <param name="map">地图信息</param>
        /// <returns>默认返回false 代表没有结束</returns>
        static bool RandomMove(int w, int h, ref Player p, ref Player otherP, Map map)
        {
            //擦之前显示的提示信息
            CleanInfo(h);
            //根据扔骰子的玩家的类型 决定信息的颜色
            Console.ForegroundColor= p.type == E_PlayerType.Player ? ConsoleColor.Cyan : ConsoleColor.Magenta;   

            //扔骰子之前判断玩家是否处于暂停状态
            if (p.isPause)
            {
                Console.SetCursorPosition(2, h - 5);
                Console.Write("处于暂停该点。{0}需要暂停一回合", p.type == E_PlayerType.Player ? "你" : "电脑");
                Console.SetCursorPosition(2, h - 3);
                Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");
                //停止暂停
                p.isPause = false;
                return false;
            }

            //扔骰子的目的是改变玩家或人机的位置 即计算位置的变化

            //扔骰子 随机一个1~6的数 加上去
            Random r = new Random();
            int randomNum = r.Next(1, 7);
            p.nowIndex += randomNum;

            //打印扔的点数
            Console.SetCursorPosition(2, h - 5);
            Console.Write("{0}扔出的点数为：{1}", p.type == E_PlayerType.Player ? "你" : "电脑", randomNum);

            //首先判断是否到达终点
            if (p.nowIndex >= map.grids.Length - 1)
            {
                p.nowIndex = map.grids.Length - 1;
                Console.SetCursorPosition(2, h - 4);
                if (p.type == E_PlayerType.Player)
                {
                    Console.Write("恭喜你，你率先到达了终点！");
                }
                else
                {
                    Console.Write("很遗憾，电脑率先到达了终点。");
                }
                Console.SetCursorPosition(2, h - 3);
                Console.Write("请按任意键结束游戏");
                return true;
            }
            else
            {
                //没有到达终点 则判断当前对象到了一个怎样的格子
                Grid grid = map.grids[p.nowIndex];

                switch (grid.type)
                {
                    case E_GridType.Normal:
                        //普通格子不用处理
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}到达了一个安全位置", p.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");
                        break;
                    case E_GridType.Boom:
                        //炸弹退格
                        p.nowIndex -= 5;
                        //不能比起点坐标小
                        if(p.nowIndex < 0)
                        {
                            p.nowIndex = 0;
                            Console.SetCursorPosition(2, h - 4);
                            Console.Write("{0}踩到了炸弹，退后5格", p.type == E_PlayerType.Player ? "你" : "电脑");
                        }
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");
                        break;
                    case E_GridType.Pause:
                        //暂停一回合
                        //加一个表示暂停的标识来判断是否暂停一回合
                        p.isPause = true;
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}到达了暂停点，需要暂停一回合", p.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");
                        break;
                    case E_GridType.Tunnel:
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}踩到了时空隧道", p.type == E_PlayerType.Player ? "你" : "电脑");
                        //随机
                        randomNum = r.Next(1, 90);
                        //触发倒退
                        if(randomNum < 30 )
                        {
                            p.nowIndex -= 5;
                            if (p.nowIndex < 0)
                            {
                                p.nowIndex = 0;
                            }
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发倒退5格");
                        }
                        //触发暂停
                        else if(randomNum <= 60)
                        {
                            p.isPause = true;
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发暂停1回合");
                        }
                        //触发交换位置
                        else
                        {
                            int temp = p.nowIndex;
                            p.nowIndex = otherP.nowIndex;
                            otherP.nowIndex = temp;
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("双方交换位置");
                        }
                        Console.SetCursorPosition(2, h - 2);
                        Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");
                        break;
                }
            }


            //默认游戏没有结束
            return false;
        }
        #endregion

        #endregion
    }

    #region 2 场景选择相关(枚举变量)
    enum E_SceneType
    {
        //开始场景
        Begin,
        //游戏场景
        Game,
        //结束场景
        End,
    }
    #endregion

    #region 5 格子结构体和格子枚举
    //格子类型枚举
    enum E_GridType
    { 
        //普通格子
        Normal,
        //炸弹
        Boom,
        //暂停
        Pause,
        //时空暂停（随机倒退、暂停、换位置）
        Tunnel,
    }

    //位置信息结构体 包含xy位置
    struct Vector2
    {
        public int x;
        public int y;

        public Vector2(int x, int y)
        { 
            this.x = x;
            this.y = y;
        }

    }
    struct Grid
    {
        //格子的类型
        public E_GridType type;
        //格子的位置
        public Vector2 pos;

        //初始化构造函数
        public Grid(int x, int y, E_GridType type)
        {
            pos.x = x;
            pos.y = y;
            this.type = type;
        }

        public void Draw()
        {
            //下述格子的位置不管如何都要先设置位置再画 所以直接在循环外把位置设置好
            Console.SetCursorPosition(pos.x, pos.y);
            switch (type)
            {
                //普通格子怎么画
                case E_GridType.Normal:
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.Write("□");
                    break;
                //炸弹怎么画
                case E_GridType.Boom:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("●");
                    break;
                //暂停怎么画
                case E_GridType.Pause:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("‖");
                    break;
                //时空隧道怎么画
                case E_GridType.Tunnel:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("¤");
                    break;
            }
        }
    }
    #endregion

    #region 6 地图结构体
    struct Map
    {
        public Grid[] grids;

        //初始化中 初始了各个格子的类型和位置
        public Map(int x, int y, int num)
        {
            grids = new Grid[num];

            //用于位置改变计数的变量
            //表示x变化的次数
            int indexX = 0;
            //表示y变化的次数
            int indexY = 0;
            //x的步长
            int stepNum = 2;

            Random r = new Random();
            int randomNum;
            for (int i = 0; i < grids.Length; i++)
            {
                //初始化格子类型
                randomNum = r.Next(0, 101);

                //设置类型 普通格子
                //首尾两个格子必为普通格子
                //所有格子中有85%的几率是普通格子
                if(randomNum < 85 || i == 0 || i == num - 1)
                {
                    grids[i].type = E_GridType.Normal;
                }
                //有5%的几率是炸弹
                else if(randomNum >= 85 && randomNum < 90)
                {
                    grids[i].type = E_GridType.Boom;
                }
                //有5%的几率是暂停
                else if (randomNum >= 90 && randomNum < 95)
                {
                    grids[i].type = E_GridType.Pause;
                }
                //有5%的几率是时空隧道
                else
                {
                    grids[i].type = E_GridType.Tunnel;
                }

                //位置应该如何设置
                grids[i].pos = new Vector2(x, y);
                //每次循环都需要按一定规则去变化位置

                //加十次
                if (indexX == 10)
                {
                    y += 1;
                    //加一次y记一次数
                    ++indexY;
                    if(indexY == 2)
                    {
                        //y加了两次过后 将x、y加的次数都记0
                        indexX = 0;
                        indexY = 0;
                        //反向步长
                        stepNum = -stepNum;
                    }
                }
                else
                {
                    x += stepNum;
                    //加一次x记一次数
                    ++indexX;
                }
            }
        }
        public void Draw()
        {
            for (int i = 0; i < grids.Length; ++i)
            {
                grids[i].Draw();
            }
        }
    }
    #endregion

    #region 7 玩家枚举和玩家结构体
    //玩家类型枚举
    enum E_PlayerType
    {
        //玩家
        Player,
        //电脑
        Computer,
    }

    struct Player
    {
        //玩家类型
        public E_PlayerType type;
        //当前所在地图哪一个索引的格子
        public int nowIndex;
        //是否暂停的标识
        public bool isPause;
        public Player(int index, E_PlayerType type)
        {
            this.type = type;
            nowIndex = index;
            isPause = false;
        }
        public void Draw(Map mapInfo)
        {
            //必须要先得到地图 再得到玩家在地图上的哪个格子
            //从传入的地图中得到格子信息
            Grid grid = mapInfo.grids[nowIndex];
            //设置位置
            Console.SetCursorPosition(grid.pos.x, grid.pos.y);
            //画 设置颜色 设置图标
            switch (type)
            {
                case E_PlayerType.Player:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("★");
                    break;
                case E_PlayerType.Computer:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("▲");
                    break;
            }
        }
    }
    #endregion
}
