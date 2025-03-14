namespace HomeWork24_面向对象相关_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //面试常问的两道题

            #region 1
            //请描述string和StringBuilder的区别
            /*
             1.string比StringBuilder的灵活性更强，但制造的内存垃圾比StringBuilder多；
             2.string在修改拼接后会产生新的内存空间，更改后原先的内存就会变成垃圾，会频繁触发GC垃圾回收机制，造成游戏卡顿，导致性能变差；
             3.StringBuilder自带容量机制，从16开始，每次超过原容量值后就会进行原容量*2的操作，更改过程中产生的新内存空间变少，
               GC触发频率降低，性能也会被优化；
             4.需要频繁修改拼接的字符串使用StringBuilder；
             5.需要使用string独特的一些方法来处理一些特殊逻辑时就选择string；
             */
            #endregion

            //GC用于释放内存

            #region 2
            //如何优化内存（大多指的是堆内存优化）
            //1.如何尽力降低GC的触发频率（过高会使游戏频繁卡顿）
            //2.如何节约内存（过多会使设备崩溃）

            //少new对象 少产生垃圾
            //合理使用static
            //合理使用string和StringBuilder
            #endregion


        }
    }
}
