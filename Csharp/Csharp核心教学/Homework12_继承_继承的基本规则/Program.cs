namespace Homework12_继承_继承的基本规则
{
    #region 1
    //写一个人类，人类中有姓名，年龄*属性*，有说话行为
    //战士类继承人类，有攻击行为

    class Person
    {
        public string name
        {
            get; 
            set;
        }
        public int age
        { 
            get; 
            set; 
        }

        public void Speak()
        {
            Console.WriteLine("说话行为");
        }
    }
    class Warrior : Person
    {
        public void Attack(Warrior otherWarrior)
        {
            Console.WriteLine("{0}攻击{1}", name, otherWarrior.name);
        }
    }

    #endregion






    internal class Program
    {
        static void Main(string[] args)
        {




        }
    }
}
