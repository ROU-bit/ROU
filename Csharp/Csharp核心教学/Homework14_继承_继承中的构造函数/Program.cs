namespace Homework14_继承_继承中的构造函数
{
    #region 1
    //有一个打工人基类，有工种，工作内容两个特征，一个工作方法
    //程序员、策划、美术分别继承打工人
    //请用继承中的构造函数这个知识点
    //实例化3个对象，分别是程序员、策划、美术

    class Worker
    {
        public string workType;
        public string workContent;
        public Worker(string workType, string workContent)
        {
            this.workType = workType;
            this.workContent = workContent;
        }
        public void workWays()
        {
            Console.WriteLine("{0}{1}",workType,workContent);
        }
    }
    class Programmer : Worker
    {
        public Programmer() : base("程序员","编程")
        {

        }
    }
    class Design : Worker
    {
        public Design() : base("策划","设计游戏")
        {

        }
    }
    class Art : Worker
    {
        public Art() : base("美术", "画画")
        {

        }
    }


    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Programmer p = new Programmer();
            p.workWays();

            Design p2 = new Design();
            p2.workWays();

            Art p3 = new Art();
            p3.workWays();

        }
    }
}
