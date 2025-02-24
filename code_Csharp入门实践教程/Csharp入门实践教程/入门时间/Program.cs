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
            int stageHeight = 20;
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
                    //开始场景
                    case 1:
                        Console.Clear();        //切换到其他场景时，先把本场景删除
                        Console.WriteLine("开始场景");
                        break;

                    //游戏场景
                    case 2:
                        Console.Clear();
                        Console.WriteLine("游戏场景");
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
