namespace 必要知识点_随机数习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             唐老狮打小怪兽
             唐老狮攻击力为8~12之间的一个值
             小怪兽防御为10，血量为20
             在控制台中通过打印信息表现唐老狮打小怪兽的过程
             描述小怪兽的掉血情况
             伤書计算公式：攻击力小于防御力时，减血为0，否则减血攻击力和防御力的差值
             */
            Console.CursorVisible = false;
            

            int monsterDef = 10;    //怪兽防御力
            int monsterHp = 20;     //怪兽血量值
            int teacherTangAtk = 0;

            Random r = new Random();
            while (true)
            {
                teacherTangAtk = r.Next(8, 13);
                if (teacherTangAtk > monsterDef)
                {
                    monsterHp -= teacherTangAtk - monsterDef;
                    Console.WriteLine("唐老师本次攻击为{0}，造成{1}点伤害，怪物剩{2}点血", 
                                teacherTangAtk, teacherTangAtk - monsterDef,monsterHp);
                    if(monsterHp <= 0)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("唐老师本次攻击为{0}，不足以造成伤害。", teacherTangAtk);
                }
                Console.WriteLine("请按任意键继续");
                Console.ReadKey(true);
                Console.Clear();
            }
            Console.WriteLine("怪物已死亡。");
        }
    }
}
