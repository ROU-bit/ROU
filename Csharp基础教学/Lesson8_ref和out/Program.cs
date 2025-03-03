namespace Lesson8_ref和out
{
    internal class Program
    {
        #region 知识点一 学习ref和out的原因
        //学习ref和out的原因
        //它们可以解决在函数内部改变外部传入的内容————里面变了 外面也要变

        static void ChangeValue(int value)
        {
            //里变外不变
            value = 3;
        }

        static void ChangeArrayValue(int[] arr)
        {
            //里变外也变
            arr[0] = 3;
        }

        static void ChangeArray(int[] arr)
        { 
            //重新申明了一个数组
            //这种情况就需要使用到ref和out
            arr = new int[] { 10, 20, 30 };
        }
        #endregion


        #region 知识点二 ref和out的使用
        //函数参数的修饰符
        //当传入的值类型参数在内部修改时 或者引用类型参数在内部重新申明时
        //外部的值会发生变化

        //ref
        static void ChangeValueRef(ref int value)
        {
            value = 3;
        }

        static void ChangeArrayRef(ref int[] arr)
        {
            arr = new int[] { 10, 20, 30 };
        }

        //out
        static void ChangeValueOut(out int value)
        {
            value = 99;
        }
        static void ChangeArrayOut(out int[] arr)
        {
            arr = new int[] { 100, 200, 300 };
        }
        #endregion


        #region 知识点三 ref和out的区别
        //1.ref传入的变量必须初始化 而out不用
        //2.out传入的变量必须在内部赋值 而ref不用

        //ref传入的变量必须初始化 但是在内部可改可不改
        //out传入的变量不用初始化 但是在内部必须修改该值（必须赋值）
        #endregion


        //总结
        //1.ref和out的作用：解决值类型和引用类型在函数内部改值或者重新申明能够影响外部传入的变量 让其也被修改
        //2.使用上：就是在申明参数的时候 前面加上ref和out的关键字即可 使用时同样
        //ref传入的变量必须初始化 但是在内部可改可不改
        //out传入的变量不用初始化 但是在内部必须修改该值（必须赋值）

        static void Main(string[] args)
        {
            //int a;
            //ChangeValueRef(ref a);        //提示错误 因为变量a没有初始化
            int a = 1;
            ChangeValueRef(ref a);
            int b;
            ChangeValueOut(out b);          //out可以允许变量不初始化




            //int a = 1;
            //ChangeValue(a);     //约等于value = a此操作
            //Console.WriteLine(a);       //1
            //                            //没改
            //ChangeValueRef(ref a);
            //Console.WriteLine(a);       //3
            //                            //a被ChangeValueRef函数改了
            //ChangeValueOut(out a);
            //Console.WriteLine(a);       //99
            //                            //a被ChangeValueRef函数改了


            //int[] b = { 1, 2, 3 };   //约等于arr[] = b[]此操作
            //ChangeArrayValue(b);
            //Console.WriteLine(b[0]);    //3
            //                            //改了
            //ChangeArray(b);
            //Console.WriteLine(b[0]);    //3
            //                            //没改
            //ChangeArrayRef(ref b);
            //Console.WriteLine(b[0]);    //10
            //                            //改了
            //ChangeArrayOut(out b);
            //Console.WriteLine(b[0]);    //100
            //                            //改了



        }
    }
}
