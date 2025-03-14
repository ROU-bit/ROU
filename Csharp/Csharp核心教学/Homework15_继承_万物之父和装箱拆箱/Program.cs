using System;

namespace Lesson15_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父和装箱拆箱练习题");
            #region 练习题一
            //请口头描述什么是装箱拆箱
            //发生条件
            //用object存值类型（装箱）
            //在把object里存的这个值类型转为值对象时（拆箱）

            // 装箱
            // 把值类型用引用类型来存储
            // 栈内存迁移到堆内存中

            // 拆箱
            // 把引用存储的值类型取出来放入值对象中
            // 堆内存迁移到了栈内存中

            // 好处：不确定类型时可以使用 object来存储任何类型 方便存储和传递
            // 坏处：存在内存迁移，增加性能消耗
            #endregion

            #region 练习题二
            //请用代码描述装箱拆箱
            //装箱
            int i = 10;
            object obj = i;
            //拆箱
            i = (int)obj;
            #endregion
        }
    }
}
