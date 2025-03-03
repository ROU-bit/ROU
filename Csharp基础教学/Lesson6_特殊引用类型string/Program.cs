namespace Lesson6_特殊引用类型string
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点一 复习值和引用类型
            //值类型——它变我不变——存储在栈内存
            //无符号整形 有符号整形 浮点数 char bool 结构体（未学习）

            //引用类型——它变我也变——存储在堆内存中
            //数组（一维、二维、交错） string  类（未学习）

            #endregion


            #region 知识点二 string的它变我不变
            string str1 = "123";
            string str2 = str1;
            //因为string是引用类型 按理说应该是它变我也变
            //string非常的特殊 具备值类型的特征“它变我不变”
            str2 = "321";
            Console.WriteLine(str1);        //123
            Console.WriteLine(str2);        //321

            //string虽然方便 但是有一个小缺点————“频繁的改变string，重新赋值，就会产生内存垃圾”
            //类似于new int[]
            //优化替代方案 在c#核心中进行学习

            #endregion

            //通过断点调试 在监视窗口中查看内存信息





        }
    }
}
