using System.Globalization;
using System.Threading;

namespace Homework9_结构体
{

    #region 1
    //使用结构体描述学员的信息，姓名，性别，年龄，班级，专业，创建两个学员对象，
    //并对其基本信息进行初始化并打印
    struct Student
    {
        //姓名
        public string name;
        //性别
        public bool sex;
        //年龄
        public int age;
        //班级
        public int classnum;
        //专业
        public string major;

        public Student(string name, bool sex, int age, int classnum, string major)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.classnum = classnum;
            this.major = major;
        }
        public void Output()
        {
            Console.WriteLine("该学员的姓名为{0}，性别为{1}，年龄为{2}，班级为{3}，专业为{4}。", name, sex ? "女" : "男", age, classnum, major);
        }
    }
    #endregion


    #region 2
    //请简要描述private和public两个关键字的区别
    //public变量可在外部调用
    //private变量不可在外部调用 没有说明默认变量为private
    #endregion


    #region 3
    //使用结构体描述矩形的信息，长，宽；创建一个矩形，对其长宽进行初始化，
    //并打印矩形的长、宽、面积、周长等信息。
    struct Rectangle
    {
        public int x;
        public int y;
        public int temp;
        public int C;
        public int S;
        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
            C = 2 * (x + y);
            S = x * y;
        }
        public void RecCale() 
        { 
            if (x > y)
            {
                temp = y;
                y = x;
                x = temp;
            }
            Console.WriteLine("此矩形的长为{0}，宽为{1}，面积为{2}，周长为{3}。", y, x, S, C);
        }
    }
    #endregion


    #region 4
    /*
     请用户输入玩家姓名，选择玩家职业，最后打印玩家的攻击信息
     职业：
     战士（技能：冲锋）
     猎人（技能：假死）
     法师（技能：奥术冲击）
     打印结果：猎人唐老狮释放了假死
     */
    struct Player
    {
        public string playerName;
        public string character;
        public string atkName;
        public char characterCode;


        public Player(string playerName, string character, string atkName, char characterCode )
        {
            this.playerName = playerName;
            this.character = character;
            this.atkName = atkName;
            characterCode = '1';
        }

        public void gamePlayer()
        {
            try
            {
                bool Info = true;
                Console.WriteLine("请输入你的姓名:");
                playerName = Console.ReadLine();

                while (Info)
                {
                    Console.WriteLine("请选择你的职业(战士0，猎人1，法师2):");
                    characterCode = Console.ReadKey(true).KeyChar;
                    if (characterCode == '0')
                    {
                        character = "战士";
                        atkName = "冲锋";
                        Info = false;
                    }
                    else if (characterCode == '1')
                    {
                        character = "猎人";
                        atkName = "假死";
                        Info = false;
                    }
                    else if (characterCode == '2')
                    {
                        character = "法师";
                        atkName = "奥术冲击";
                        Info = false;
                    }
                    else
                    {
                        Console.WriteLine("请按照题意输入！");
                    }
                }
                Console.WriteLine("{0}{1}释放了{2}。", character, playerName, atkName);
            }
            catch
            {
                Console.WriteLine("请输入合法字符！");
            }
        }
    }
    #endregion

    #region 5
    //使用结构体描述小怪兽
    struct Monster
    {
        
        public string monstername;
        public int monsteratk;
        public Monster(string monstername)
        {
            this.monstername = monstername;
            Random random = new Random();
            monsteratk = random.Next(10 ,30);
        }
        public void Atk()
        {
            Console.WriteLine("{0}的攻击力为{1}", monstername, monsteratk);
        }
    }

    
    #endregion


    #region 7
    /*
     应用已学过的知识，实现奥特曼打小怪兽
     提示：
     结构体描述奥特曼与小怪兽
     定义一个方法实现奥特曼攻击小怪兽
     定义一个方法实现小怪兽攻击奥特曼
     */

    struct OutMan
    {
        public string outManName;
        public int outManAtk;
        public int outManDef;
        public int outManHp;

        public OutMan(string outManName, int outManAtk, int outManDef, int outManHp)
        {
            this.outManName = outManName;
            this.outManAtk = outManAtk;
            this.outManDef = outManDef;
            this.outManHp = outManHp;
        }

        public void AtkWay(ref Boss monster)
        {
            //奥特曼打小怪兽
            monster.bossHp -= outManAtk - monster.bossDef;
            Console.WriteLine("{0}攻击了{1}，造成了{2}点伤害，{3}的剩余血量为{4}。", outManName, monster.bossName, outManAtk - monster.bossDef, monster.bossName, monster.bossHp);
        }

    }

    struct Boss
    {
        public string bossName;
        public int bossAtk;
        public int bossDef;
        public int bossHp;

        public Boss(string bossName, int bossAtk, int bossDef, int bossHp)
        {
            this.bossName = bossName;
            this.bossHp = bossHp;
            this.bossAtk = bossAtk;
            this.bossDef = bossDef;
        }
        public void AtkWay(ref OutMan outMan)
        {
            //小怪兽打奥特曼
            outMan.outManHp -= bossAtk - outMan.outManDef;
            Console.WriteLine("{0}攻击了{1}，造成了{2}点伤害，{3}的剩余血量为{4}。", bossName, outMan.outManName, bossAtk - outMan.outManDef, outMan.outManName, outMan.outManHp);
        }
    }
    #endregion








    internal class Program
    {
        static void Main(string[] args)
        {

            #region 6
            //定义一个数组存储10个上面描述的小怪兽，每个小怪兽的名字为（小怪兽+数组下标)
            //举例：小怪兽0，最后打印10个小怪兽的名字+攻击力数值
            Monster[] monsters = new Monster[10];
            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i] = new Monster("小怪兽" + i);
                monsters[i].Atk();
            }
            #endregion


            #region 7
            OutMan outMan = new OutMan("雷欧奥特曼", 10, 5, 100);
            Boss boss = new Boss("哥斯拉", 8, 4, 100);

            while (true)
            {
                outMan.AtkWay(ref boss);
                if (boss.bossHp <= 0)
                {
                    Console.WriteLine("{0}胜利！",outMan.outManName);
                    break;
                }
                boss.AtkWay(ref outMan);
                if (outMan.outManHp <= 0)
                {
                    Console.WriteLine("{0}胜利！", boss.bossName);
                    break;
                }
                Console.WriteLine("按任意键继续");
                Console.ReadKey(true);
            }
            #endregion


            #region 1
            Student s1 = new Student("ROU", true, 21, 7, "数字媒体技术");
            s1.Output();
            Student s2 = new Student("MAO", true, 22, 5, "消防安全管理");
            s2.Output();
            #endregion


            #region 3
            Rectangle rectangle1 = new Rectangle(3, 9);
            rectangle1.RecCale();
            #endregion


            #region 4
            Player player1 = new Player();
            player1.gamePlayer();
            #endregion


           



        }
    }
}
