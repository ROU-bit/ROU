using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪食蛇.Lesson1;

namespace 贪食蛇.Lesson2
{
    class BeginScene : BeginOrEndBaseScene
    {
        public BeginScene() 
        {
            strTitle = " 贪食蛇";
            strOne = "开始游戏";
        }
        public override void EnterJDoSomething()
        {
            //按J键后的逻辑
            if (nowSelIndex == 0)
            {
                Game.ChangeScene(E_SceneType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
