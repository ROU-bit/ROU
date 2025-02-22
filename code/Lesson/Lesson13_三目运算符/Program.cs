namespace Lesson13_三目运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 基本语法
            //套路： 3个空位 2个符号！！！
            //固定语法：空位    ？空位                ：空位；
            //关键信息：bool类型？bool类型为真返回内容：bool类型为假返回内容
            //第一个空位始终是结果为bool类型的表达式 bool变量 条件表达式 逻辑运算符
            //第二、三个空位是什么表达式都可以 但要保证其结果类型一致
            //三目运算符 会有返回值，这个返回值类型必须一致，并且必须使用！

            #endregion


            #region 知识点二 具体使用

            string str = true ? "条件为真" : "条件为假";
            Console.WriteLine(str);         //条件为真

            int a = 5;
            str = a < 1 ? "a>1" : "a不满足条件";
            Console.WriteLine(str);

            int b = a > 1 ? 123 : 456;
            Console.WriteLine(b);

            bool bo = a > 1 ? a > 6 : false;
            Console.WriteLine(bo); 


            #endregion
        }
    }
}
