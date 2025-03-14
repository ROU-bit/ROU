namespace Lesson14_继承_继承中的构造函数
{

    #region 知识点一 继承中的构造函数 基本概念
    //特点
    //当申明一个子类对象时
    //先执行父类的构造函数
    //再执行子类的构造函数

    //注意：
    //1.父类的无参构造 很重要
    //2.子类可以通过base关键字 代表父类 调用父类构造
    #endregion


    #region 知识点二 继承中的构造函数的执行顺序
    //父类的父类的构造————>......父类构造————>......————>子类构造
    class GameObject
    {
        public GameObject()
        {
            Console.WriteLine("GameObject的构造函数");
        }
    }

    class Player : GameObject
    {
        public Player()
        {
            Console.WriteLine("Player的构造函数");
        }
    }

    class MainPlayer : Player
    {
        public MainPlayer()
        {
            Console.WriteLine("MainPlayer的构造函数");
        }
    }

    #endregion


    #region 知识点三 父类的无参构造函数很重要
    //子类实例化时默认自动调用父类的无参构造，所以如果父类无参构造被顶掉 就会报错
    class Father
    {
        //public Father()
        //{

        //}
        public Father(int i)
        {
            Console.WriteLine("Father构造");
        }
    }
    class Son : Father
    {
        #region 知识点四 通过base调用指定父类构造
        public Son(int i) : base(i) 
        {

        }

        #endregion
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            MainPlayer mainPlayer = new MainPlayer();
        }
    }

    //总结
    //继承中的构造函数
    //特点
    //执行顺序 是先执行父类的构造函数 再执行子类的 从老祖宗开始依次一代一代向下执行

    //父类中的无参构造函数 很重要
    //如果被顶掉 子类就无法默认调用无参函数
    //解决方法：
    //1.始终保持申明一个无参构造
    //2.通过base关键字 调用指定父类的构造

    //注意
    //区分this和base的区别
}
