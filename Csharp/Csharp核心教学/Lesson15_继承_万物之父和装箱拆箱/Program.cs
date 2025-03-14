namespace Lesson15_继承_万物之父和装箱拆箱
{
    //与里氏替换原则息息相关

    #region 知识点一 万物之父
    //万物之父
    //关键字：object
    //概念：
    //object是所有类型的基类，他是一个类（引用类型）
    //作用：
    //1.可以利用里氏替换原则，用object容器装所有对象
    //2.可以用来表示不确定类型，作为函数参数类型
    #endregion

    class Father
    {

    }
    class Son : Father
    { 
        public void Speak()
        {
            Console.WriteLine("子类");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点二 万物之父的使用
            Father f = new Son();
            if( f is Son )
            {
                (f as Son).Speak();
            }

            //引用类型
            object o = new Son();
            o = f;
            //用is as来判断转换即可
            if ( o is Son)
            {
                (o as Son).Speak();
            }
            //值类型
            object o2 = 1f;
            //用强转
            float fl = (float)o2;

            //特殊的string类型
            object str = "213456";
            string str2 = str as string;

            object arr = new int[10];
            int[] arr2 = arr as int[];
            #endregion
             

            #region 知识点三 装箱拆箱
            //发生条件
            //用object存值类型（装箱）
            //再把object转为值类型（拆箱）

            //装箱
            //把值类型用引用类型存储
            //栈内存会迁移到堆内存中

            //拆箱
            //把引用类型存储的值类型取出来
            //堆内存会迁移到栈内存中

            //好处：不确定类型时可以方便参数的存储和传递
            //坏处：存在内存迁移，增加性能消耗
            #endregion
        }
    }
}
