namespace Homework7_封装_静态成员
{

    #region 1
    //请说出const和static的区别
    //const必须初始化、不能被修改
    //const必须写在访问修饰符前
    //const只能修饰变量
    //而static没有这些限制
    //二者都可以通过类名点出使用
    #endregion

    #region 2
    //单例模式
    /*
     请用静态成员相关知识实现
     一个类对象，在整个应用程序的生命周期中，有且仅会有一个该对象的存在，
     不能在外部实例化，直接通过该类类名就能够得到唯一的对象
     */
    class Test
    {
        //将Test类通过static附加唯一性   在整个应用程序的生命周期中，有且仅会有一个该对象的存在
        private static Test t = new Test();

        public int testInt = 10;

        //让外部不能更改，只能得到
        public static Test T
        {
            get 
            { 
                return t; 
            }
        }
        //不能在外部实例化
        //直接将默认的构造函数改为私有的
        private Test() 
        {

        }
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test.T.testInt);
        }
    }
}
