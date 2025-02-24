namespace Lesson3_常量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 知识点一 常量的声明
            //关键字 const
            //固定写法：
            //const 变量类型 变量名 = 初始值；

            int i = 10;             //变量
            const int j = 20;       //常量

            #endregion


            #region 知识点二 常量的特点
            //1.必须初始化
            //2.不能被修改

            string name;
            name = "MAO";                      //变量申明可以不初始化，后续可再修改

            const string myName = "ROU";
            //myName = "CY";                   //常量申明必须初始化，后续不可修改，否则会报错


            //作用：申明一些常用不变的变量
            //EX.   PI 3.1415926
            const float PI = 3.1415926f;

            #endregion

            #region 作业

            /*
             
             1.常量有什么特点？
                ①必须申明值；     //必须初始化；
                ②不可修改值。     //不可被修改；
                                   //常量的声明就是在申明变量前加一个const。EX.const int i = 10;
                                   //之后讲解了静态关键字ststic后 会回过头来讲解常量的特点。
             
             2.请简述你觉得在游戏开发中常量会用来做什么？
                用来申明后续操作中不变的值，例如PI、角度转弧度、弧度转角度、重力加速度。
                一些数学定理或者公理性质的变量、用于计算的变量、角色血量特殊固定为某值。

             */

            #endregion
        }
    }
}
