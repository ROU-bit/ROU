namespace Lesson9_变长参数和参数默认值
{
    internal class Program
    {

        #region 知识点一 函数语法复习
        /*
            1       2       3                   4
         static 返回值类型 函数名(参数类型 参数1, 参数类型 参数2, ......)
         {
                5
            return 返回值;  
         }
         1 静态关键词 可自选要不要写，目前对我们来说必须要写
         2 返回值类型 没有返回值就填void 可以填任意类型的变量
         3 函数名     帕斯卡命名法
         4 参数       可以是0~n个 前面可以加ref或out 用来传递想要在函数内部改变的内容的变量
         5 返回值     如果返回值类型不是void 难么就必须有return对应类型的内容 return可以打断函数语句块中的逻辑 直接停止后面的逻辑 跳出本函数语句块
         */
        #endregion


        #region 知识点二 变长参数关键词
        //举例 函数要计算n个整数的和
        //static int sum{int a, int b,......}

        //变长参数关键字 params
        static int Sum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        //params int[] 意味着可以传入n个int参数 n可以等于0 传入的参数会存在arr数组中
        //注意：
        //1.parmas关键字后面必为数组
        //2.数组的类型可以是任意的类型

        //3.函数参数可以有别的参数和params关键字修饰的参数
        //4.函数参数中只能最多出现一个parmas关键字 并且一定是在最后一组参数 前面可以有n个其它参数
        //下面这种就是错的
        //static void Eat(string name, *params bool[] t*, params string[] things, *int a*)
        //{

        //}
        static void Eat(string name, params string[] things)
        {

        }
        #endregion


        #region 知识点三 参数默认值
        //有参数默认值的参数一般称为可选参数
        //作用 当调用函数时可以不传入参数，不传就会使用默认值作为参数的值
        static void Speak(string str = "我没什么话可说")
        {
            Console.WriteLine(str);
        }

        //注意：
        //1.支持多参数默认值 每个参数都可以有默认值
        //2.如果要混用可选参数 则必须写在普通参数后面
        //下面这种就是错的
        //static void Speak2(string test, string name = "ROU", string str = "MAO", string name2)
        //{

        //}

        static void Speak2(string test, string name = "ROU", string str = "MAO")
        {

        }
        #endregion


        //总结

        //1.变长参数关键字 params
        //作用：可以传入n个同类型参数 n可以是0
        //注意
        //1.params后面必须是数组 意味着只能是同一类型的可变参数
        //2.变长参数只可以有一个
        //3.必须在所有参数最后写变长参数

        //2.参数默认值（可选参数）
        //作用：可以给参数默认值 使用时可以不传参 不传用默认的 传了用传的
        //注意：
        //1.可选参数可以有多个
        //2.正常参数写在可选参数前面，可选参数只能写在所有参数的后面


        static void Main(string[] args)
        {

            Console.WriteLine(Sum(1, 45, 65, 2, 1, 48, 5, 1, 9, 15, 2, 252, 58, 87)) ;  //591

            Speak();            //我没什么话可说
            Speak("我要说话");  //我要说话

        }
    }
}
