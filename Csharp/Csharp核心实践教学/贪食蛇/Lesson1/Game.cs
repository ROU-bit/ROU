using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪食蛇.Lesson2;

namespace 贪食蛇.Lesson1
{
    /// <summary>
    /// 场景类型枚举
    /// </summary>
    enum E_SceneType
    {
        /// <summary>
        /// 开始场景
        /// </summary>
        Begin,
        /// <summary>
        /// 游戏场景
        /// </summary>
        Game,
        /// <summary>
        /// 结束场景
        /// </summary>
        End,
    }
    class Game
    {
        //游戏窗口宽高
        public const int w = 80;
        public const int h = 20;
        //当前选中的场景
        public static ISceneUpdate nowScene;

        public Game() 
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);

            //初始化的时候放在开始场景上
            ChangeScene(E_SceneType.Begin);
        }
        //游戏开始的方法
        public void Start()
        {
            //游戏主循环 主要负责 游戏场景逻辑的更新
            while (true)
            {
                //判断当前游戏场景不为空 就更新
                if (nowScene != null)
                {
                    nowScene.Update();
                }
            }
        }

        public static void ChangeScene(E_SceneType type)
        {
            //切场景之前需要擦除上一个绘制的游戏场景内容
            Console.Clear();

            switch (type)
            {
                case E_SceneType.Begin:
                    nowScene = new BeginScene();
                    break;
                case E_SceneType.Game:
                    //静态函数中不能直接使用静态变量
                    nowScene = new GameScene();
                    break;
                case E_SceneType.End:
                    nowScene = new EndScene();
                    break;
            }
        }

    }
}
