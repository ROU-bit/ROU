namespace Lesson7_封装_静态成员
{

    #region 知识点一 静态成员基本概念
    //静态关键字：static
    //用static修饰的成员变量、方法、属性等
    //成为静态成员

    //静态成员的特点是：直接用类名点出使用
    #endregion


    #region 知识点二 早已出现的静态成员

    #endregion


    #region 知识点三 自定义静态成员
    class Test
    {
        //静态成员变量
        public static float PI = 3.1415926f;
        //常量
        public const float G = 9.8f;
        //成员变量
        public int testInt = 100;

        //静态成员函数
        static public float CalcCircle(float r)
        {
            #region 知识点六 静态函数中不能使用非静态成员
            //与生命周期有关
            //成员变量只能将对象实例化出来后才能点出来使用 不能无中生有
            //所以不能直接使用非静态成员 否则会报错
            Test test = new Test();
            Console.WriteLine(test.testInt);
            #endregion

            //πr²
            return PI * r * r;
        }
        //成员函数
        public void TestFun()
        {
            #region 知识点七 非静态函数可以使用静态成员
            //与生命周期有关
            Console.WriteLine(PI);
            Console.WriteLine(CalcCircle(3));
            #endregion
            Console.WriteLine("123");
        }
    }
    #endregion


    #region 知识点五 为什么可以直接点出来使用
    //记住！
    //程序中是不能无中生有的
    //我们要使用的对象、变量、函数都要在内存中分配内存空间
    //之所以要实例化对象，目的就是分配内存空间，在程序中产生一个抽象的对象

    //静态成员的特点
    //程序开始运行时，会分配内存空间，所以我们就能直接使用。
    //*静态成员和程序同生共死*
    //只要使用了它，直到程序结束时内存空间才会被释放
    //所以一个静态成员就会有自己唯一的一个“内存小空间”
    //这让静态成员就有了唯一性
    //在任何地方都是用的小房间里的内容，改变了它也是改变小房间里的内容
    #endregion


    #region 知识点八 静态成员对于我们的作用
    //静态变量：
    //1.常用唯一变量的申明
    //2.方便别人获取的对象申明
    //静态方法：
    //常用的唯一的方法申明 EX.相同规则的数学计算相关函数
    #endregion


    #region 知识点九 常态和静态变量
    //const（常量）可以理解为特殊的static（静态）
    //相同点
    //他们都可以通过类名点出使用
    //不同点
    //1.const必须初始化，不能修改、static没有这个规则
    //2.const只能修饰变量、static可以修饰很多
    //3.const一定要写在访问修饰符后面、static没有这个要求
    #endregion


    internal class Program
    {

        static void Main(string[] args)
        {
            #region 知识点四 静态成员的使用
            Console.WriteLine(Test.PI);
            Console.WriteLine(Test.CalcCircle(2));
            Console.WriteLine(Test.G);
            #endregion

            //成员的使用
            Test t = new Test();
            Console.WriteLine(t.testInt);
            t.TestFun();
        }
    }

    //总结
    //概念：用static修饰的成员变量、成员方法、成员属性等，就称为静态成员
    //特点：直接用类名点出来使用     *全局性*
    //生命周期：和程序同生共死
    //         程序运行后就会一直存在内存中，直到程序结束后才会释放，因此静态成员具有*唯一性*
    //注意：
    //与生命周期有关
    //1.静态函数中不能直接使用非静态成员
    //2.非静态函数中可以直接使用静态成员

    //常量和静态变量
    //常量是特殊的静态变量
    //相同点
    //它们都可以通过类名点出来使用
    //不同点
    //1.const必须初始化不能被修改 static没有这个规则
    //2.const只能修饰变量，static可以修饰很多
    //3.const不能写在访问修饰符前面，一定是写在变量申明前面，static没有这个规则
}
