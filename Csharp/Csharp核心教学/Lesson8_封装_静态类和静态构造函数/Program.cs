namespace Lesson8_封装_静态类和静态构造函数
{
    #region 知识点一 静态类
    //概念
    //用static修饰的类

    //特点
    //只能包含静态成员
    //不能被实例化 不能被new

    //作用
    //1.将常用的静态成员写在静态类
    //2.静态类不能被实例化，更能体现工具类的唯一性
    //比如 Console 就是一个静态类

    static class Tools
    {
        //静态成员变量
        public static int testIndex = 0;
        //静态方法
        public static void TestFun()
        {

        }
        //静态属性
        public static int TestIndex
        {
            get;
            set;
        }
    }
    #endregion


    #region 知识点二 静态构造函数
    //概念
    //在构造函数加上 static 修饰

    //特点
    //1.静态类和普通类都可以有
    //2.不能使用访问修饰符
    //3.不能有参数
    //4.只会自动调用一次

    //作用
    //在静态构造函数中初始化 静态变量

    //使用
    //1.静态类中的静态构造函数
    static class StaticClass
    {
        public static int testInt = 100;
        public static int testInt2 = 100;

        static StaticClass()
        {
            Console.WriteLine("静态构造函数");
            testInt = 200;
            testInt2 = 300;
        }
    }
    //2.普通类的静态构造函数
    class Test
    {
        public static int testInt = 200;
        static Test()
        {
            Console.WriteLine("静态构造");
        }
        public Test()
        {
            Console.WriteLine("普通构造函数");
        }
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Test.testInt);

            Console.WriteLine(StaticClass.testInt);
            Console.WriteLine(StaticClass.testInt);
            Console.WriteLine(StaticClass.testInt2);

            Test test = new Test();
            Test test1 = new Test();

        }
    }

    //总结
    //静态类
    //用static 修饰的类
    //特点
    //只能包含静态成员
    //不能实例化
    //作用
    //工具类
    //拓展方法

    //静态构造函数
    //用static修饰的构造函数
    //特点
    //静态类和普通类都可以有静态构造函数
    //不能使用访问修饰符
    //作用
    //初始化静态成员
}
