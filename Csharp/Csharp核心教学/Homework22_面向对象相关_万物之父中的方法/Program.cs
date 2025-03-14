
namespace Homework22_面向对象相关_万物之父中的方法
{
    #region 1
    //有一个玩家类，有姓名，血量，攻击力，防御力，闪避率等特征
    //请在控制台打印出“玩家XX，血量XX，攻击力XX，防御力XX”XX为具体内容
    class Player
    {
        private string name;
        private int Hp;
        private int Atk;
        private int Dfn;
        private int dodge;

        public Player(string name, int hp, int atk, int dfn, int dodge)
        {
            this.name = name;
            this.Hp = hp;
            this.Atk = atk;
            this.Dfn = dfn;
            this.dodge = dodge;
        }

        public override string ToString()
        {
            return string.Format("玩家{0}、血量{1}、攻击力{2}、防御力{3}、闪避{4}", name, Hp, Atk, Dfn, dodge);
        }
    }
    #endregion

    #region 2
    //一个Monster类的引用对象A，Monster类有 攻击力、防御力、血量、技能ID等属性。
    //我想复制一个和A对象一模一样的B对象。并且改变了B的属性，A不会受到影响。请问如何实现?
    class Monster
    {
        public Monster(int atk, int dfn, int hp, int iD)
        {
            Atk = atk;
            Dfn = dfn;
            Hp = hp;
            ID = iD;
        }

        public int Atk { get; set; }
        public int Dfn { get; set; }
        public int Hp {  get; set; }
        public int ID {  get; set; }

        public Monster Clone()
        {
            return MemberwiseClone() as Monster;
        }
        public override string ToString()
        {
            return string.Format("攻击力{0}、防御力{1}、血量{2}、技能ID{3}", Atk, Dfn, Hp, ID);
        }
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player("ROU", 100, 10, 5, 20);
            Console.WriteLine(p);

            Monster m = new Monster(10, 21, 100, 1);
            Monster m2 = m.Clone();
            m2.Atk = 30;
            m2.ID = 100;
            Console.WriteLine(m);
            Console.WriteLine(m2);


        }
    }
}
