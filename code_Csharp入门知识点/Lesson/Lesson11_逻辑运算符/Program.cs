namespace Lesson11_逻辑运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //对bool类型进行逻辑运算

            #region 知识点一 逻辑与
            //符号 && 并且
            //规则 对两个bool值进行逻辑运算 有假则假 同真为真

            bool result = true && false;
            Console.WriteLine(result);
            result = true && true;
            Console.WriteLine(result);

            //bool相关的类型 bool变量 条件运算符
            //逻辑运算符优先级低于条件运算符
            result = 5 < 8 && 5 > 4;        //4 < 5 < 8
            Console.WriteLine(result);

            //多个逻辑与 组合使用
            //没有括号的情况下 从左到右依次看
            //有括号则先看括号内
            int i1 = 1;
            int i2 = 2;
            result = i1 > i2 && 8 < i1 && i2 > 12;
            Console.WriteLine(result);

            #endregion
            //? && ?
            //?可以是写死的bool变量或者bool值
            //还可以是条件运算符相关
            //? || ?
            #region 知识点二 逻辑或
            //符号 || 或者
            //规则 对两个bool值进行逻辑运算 有真则真 同假为假
            result = true || false;
            Console.WriteLine(result);
            result = false || false;
            Console.WriteLine(result);

            #endregion


            #region 知识点三 逻辑非
            //符号 !
            //规则 对一个bool值进行取反 真变假 假变真

            result = !true;
            Console.WriteLine(result);
            result = !false;
            Console.WriteLine(result);

            result = !!true;
            Console.WriteLine(result);

            //result = !3 > 2;              error
            //逻辑非的优先级较高，并不是对3>2取反，而是对3进行了取反，所以报错
            //需要加括号
            result = !(3 > 2);
            Console.WriteLine(result);

            #endregion


            #region 知识点四 混合使用优先级问题
            ////规则    !（逻辑非）优先级最高
            //          &&（逻辑与）优先级高于||（逻辑或）
            //          逻辑运算符优先级低于算术运算符、条件运算符（逻辑非除外）



            #endregion


            #region 知识点五 逻辑运算符*短路规则
            int i = 1;
            // || 有真则真
            //短路指的是 只要&&或者||左边满足了判断的条件 右边就不会再去理睬了的情况
            //如下题 ++i>=1没有被理睬，所以i的输出值仍是1
            result = i > 0 || ++i >= 1;
            Console.WriteLine(i);           //1
            //如下题 左边并没有满足判断的条件，所以右边被理睬，即i的输出值变为2
            result = i < 0 || ++i >= 1;
            Console.WriteLine(i);           //2


            #endregion



            #region 作业
            /*1.
             求打印结果是什么？
            Console. WriteLine(true || true);       T
            Console. WriteLine(false || true);      T
            Console. WriteLine(true && true);       T
            Console. WriteLine(true && false);      F
            Console. WriteLine(!true);              F
             
             
             */


            /*2.
             求打印结果是什么？
            bool gameOver;
            bool isWin;
            int health = 100;
            gameOver = true；
            isWin = false;
            Console. Write(gameOver || isWin && health > 0);        T
             */






            #endregion






        }
    }
}
