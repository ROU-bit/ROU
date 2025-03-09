namespace Lesson9_封装_拓展方法
{
    #region 知识点一 拓展方法基本概念
    //概念
    //*为现有非静态 变量类型 添加新方法*
    //作用
    //1.提升程序拓展性
    //2.不需要在对象中重新写方法
    //3.不需要继承来添加方法
    //4.为别人封装的类型写额外的方法
    //特点
    //1.一定是写在静态类中
    //2.一定是个静态函数
    //3.第一个参考为拓展目标
    //4.第一个参数用this修饰
    #endregion


    #region 知识点二 基本语法
    //访问修饰符 static 返回值 函数名(this 拓展类名 参数名,参数类型 参数名,参数类型 参数名......)
    #endregion


    #region 知识点三 实例
    static class Tools
    {
        //为int拓展了一个成员方法
        //成员方法需要实例化对象后才能使用
        //value代表使用该方法的实例化对象
        public static void SpeakValue(this int value)
        {
            //拓展的方法的逻辑
            Console.WriteLine("ROU为int拓展的方法" + value);
        }

        public static void SpeakStringInfo(this string str ,string str1 ,string str2)
        {
            Console.WriteLine("ROU为string拓展的方法");
            Console.WriteLine("调用方法的对象" + str);
            Console.WriteLine("传的参数" + str1 + str2);
        }

        public static void Fun3(this Test t)
        {
            Console.WriteLine("为test拓展的方法");
        }
    }
    #endregion


    #region 知识点五 为自定义的类型拓展方法
    class Test
    {
        public int i = 10;
        public void Fun1()
        {
            Console.WriteLine("123");
        }
        public void Fun2()
        {
            Console.WriteLine("456");
        }
    }
    #endregion




    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点四 使用
            int i = 10;
            i.SpeakValue();

            string str = "000";
            str.SpeakStringInfo("ROU", "111");

            Test t = new Test();
            t.Fun3();
            #endregion

        }
    }

    //总结
    //概念：为现有的非静态的变量类型添加方法
    //作用：提升程序拓展性、不需要再在对象中重新写方法、不需要继承来添加方法、为别人封装的类型写额外的方法

    //特点：
    //1.静态类中的静态方法
    //2.第一个参数代表拓展的目标
    //3.第一个参数前面一定要加this

    //注意：
    //可以有返回值和n个参数
    //根据需求而定

}
