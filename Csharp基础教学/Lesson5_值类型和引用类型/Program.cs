namespace Lesson5_值类型和引用类型
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点一 变量类型的复习
            /*
            //无符号整形
            byte b = 1;
            ushort us = 1;
            uint ui = 1;
            ulong ul = 1;
            //有符号整形
            sbyte sb = 1;
            short s = 1;
            int i = 1;
            long l = 1;
            //浮点数
            float f = 1.1f;
            double d = 1.1;
            decimal de = 1.1m;
            //特殊类型
            char c = '1';
            string str = "111";
            bool bo = true;
            //复杂数据类型
            //enum 枚举
            //数组（一维、二维、交错）

            //把以上学过的变量类型分成值类型和引用类型
            //引用类型：string,数组,类（未学习）
            //值类型：其他、结构体（未学习）
            */
            #endregion


            #region 知识点二 值类型和引用类型的区别

            //1.使用上的区别
            //值类型
            int a = 10;
            //引用类型
            int[] arr = new int[] { 1, 2, 3, 4 };

            //申明了一个b让其等于之前的a
            int b = a;

            //申明了一个arr2让其等于之前的arr
            int[] arr2 = arr;
            Console.WriteLine("a={0} , b={1}", a, b);                           //10 10
            Console.WriteLine("arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);       //1 1
            Console.WriteLine("******************************");
            b = 20;
            arr2[0] = 5;
            Console.WriteLine("a={0} , b={1}", a, b);                           //10 20
            Console.WriteLine("arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);       //5 5

            //值类型 在相互赋值时把内容拷贝给了对方 他变我不变
            //引用类型的相互赋值是让两者指向同一个值 他变我也变
            //string是一个特殊的引用类型，不遵循他变我也变。


            //*2.为什么会有以上区别
            //值类型和引用类型存储在的内存区域不同，即存储方式不同
            //所以造成了他们在使用上的区别

            //值类型存储在 栈空间 ———— 系统分配，自动回收，小而快
            //引用类型存储在 堆空间 ———— 手动申请和释放，大而慢
            //new了就是开了新房间 和之前的没有什么关系，所以arr不会有任何变化

            #endregion

            #region homework
            //1.结果为10

            //2.结果为20

            //3.结果为123


            #endregion





        }
    }
}
