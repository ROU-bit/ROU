namespace Homework9_封装_拓展方法
{

    static class ToolsExpand
    {

        #region 1
        //为整形拓展一个求平方的方法
        public static void FindSquare(this int value)
        {
            int i = value * value;
            Console.WriteLine("{0}的平方是{1}", value, i);
        }
        #endregion

        #region 2
        //为该玩家拓展一个自杀的方法
        static public void Suicide(this Player p)
        {
            //自杀
            Console.WriteLine("玩家" + p.playerName +"自杀");
        }
        #endregion
    }

    #region 2
    //写一个玩家类，包含姓名、血量、攻击力、防御力等特征，攻击、移动、受伤等方法
    //为该玩家拓展一个自杀的方法
    class Player
    {
        public string playerName;
        public int playerHp;
        public int playerAtk;
        public int playerDfn;

        public void Attack()
        {
            //攻击
        }
        public void Move()
        {
            //移动
        }
        public void Injured()
        {
            //受伤
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            int i = 98;
            i.FindSquare();
            #endregion

            #region 2
            Player p = new Player();
            p.playerName = "1";
            p.Suicide();
            #endregion
        }
    }
}
