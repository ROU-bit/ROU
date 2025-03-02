namespace Homework1_枚举
{
    #region 1 QQ状态
    //定义QQ状态的枚举
    enum E_qqState
    {
        Online,
        Busy,
        Quit,
        Invisible,
    }

    #endregion
    

    #region 2 星巴克买咖啡

    enum E_StarBacks
    {
        middleCup,
        bigCup,
        superBigCup,
    }

    #endregion


    #region 3 RPG
    enum E_HeroSex
    {
        Female,
        Male,
    }
    enum E_HeroJob
    {
        Warrior,
        Hunter,
        Wizard,
    }
    #endregion



    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 QQ状态

            //提示用户选择一个在线状态，我们接受输入的数字，并将其转换成枚举类型
            try
            {
                Console.WriteLine("请于在线状态‘0、1、2、3’中选择一个：");
                E_qqState state = (E_qqState)int.Parse(Console.ReadKey(true).KeyChar.ToString());
                Console.WriteLine(state);
            }
            catch 
            {
                Console.WriteLine("请输入正确数字！");
            }

            #endregion


            #region 2 星巴克买咖啡
            /*
              用户去星巴克买咖啡，分为中杯（35元），大杯（40元），超大杯（43元），
              请用户选择要购买的类型，用户选择后，打印：您购买了
              xxx咖啡，花费了xx元
              例如：你购买了中杯咖啡，花费了35元
            */
            try
            {
                Console.WriteLine("请从'中杯0、大杯1、超大杯2'中选择您要购买的类型：");
                E_StarBacks starBacks = (E_StarBacks)int.Parse(Console.ReadKey(true).KeyChar.ToString());
                int starBackPrice = 0;
                switch (starBacks)
                {
                    case E_StarBacks.middleCup:
                        starBackPrice = 35;
                        break;
                    case E_StarBacks.bigCup:
                        starBackPrice = 40;
                        break;
                    case E_StarBacks.superBigCup:
                        starBackPrice = 43;
                        break;
                    default:
                        Console.WriteLine("请输入0、1、2其中一个");
                        break;
                }
                    Console.WriteLine("您购买了{0}咖啡，花费了{1}元。", starBacks, starBackPrice);
            }
            catch
            {
                Console.WriteLine("请正确输入数字！");
            }

            #endregion


            #region 3 RPG

            try
            {
                Console.WriteLine("请选择英雄性别：女(0)、男(1)");
                E_HeroSex heroSex = (E_HeroSex)int.Parse(Console.ReadKey(true).KeyChar.ToString());
                Console.WriteLine();

                Console.WriteLine("请选择英雄职业：战士(0)、猎人(1)、法师(2)");
                E_HeroJob heroJob = (E_HeroJob)int.Parse(Console.ReadKey(true).KeyChar.ToString());
                Console.WriteLine();

                int atk = 0, def = 0;
                string jobOutput = "";
                string skill = "";

                // 设置基础属性
                switch (heroSex)
                {
                    case E_HeroSex.Male:
                        atk += 50;
                        def += 100;
                        break;
                    case E_HeroSex.Female:
                        atk += 150;
                        def += 20;
                        break;
                }

                // 根据职业调整属性和技能
                switch (heroJob)
                {
                    case E_HeroJob.Warrior:
                        atk += 20;
                        def += 100;
                        jobOutput = "战士";
                        skill = "冲锋";
                        break;
                    case E_HeroJob.Hunter:
                        atk += 120;
                        def += 30;
                        jobOutput = "猎人";
                        skill = "假死";
                        break;
                    case E_HeroJob.Wizard:
                        atk += 200;
                        def += 10;
                        jobOutput = "法师";
                        skill = "奥术冲击";
                        break;
                }

                Console.WriteLine("您选择了“{0}性{1}”，攻击力：{2}，防御力：{3}，职业技能：{4}",
                        heroSex == E_HeroSex.Male ? "男" : "女",
                        jobOutput,
                        atk,
                        def,
                        skill);
            }
            catch
            {
                Console.WriteLine("请正确输入！");
            }

            #endregion








        }
    }
}
