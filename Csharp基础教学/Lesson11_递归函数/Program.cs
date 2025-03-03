namespace Lesson11_递归函数
{
    internal class Program
    {
        #region 知识点一 基本概念
        //递归函数就是让函数自己调用自己
        //static void Fun()
        //{
        //    if(false)
        //    {
        //        return;
        //    }
        //    Fun();
        //}
        //一个正确的递归函数
        //1.必须有结束调用的条件
        //2.用于条件判断的这个条件必须改变能够达到停止的目的
        #endregion


        #region 知识点二 实例
        //用递归函数打印出0~10
        static void Fun(int a)
        {
            //第四步：结束条件
            if(a > 10)
            {
                return;
            }
            //第二步：完成题目中“打印”的要求
            Console.WriteLine(a);
            //第三步：完成了一个递归的变化 作为我们条件的判断
            ++a;
            //第一步：构造一个递归
            Fun(a);
        }

        #endregion


        static void Main(string[] args)
        {
            Fun(0);
        }
    }
}
