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

            bool bo = a > 1 ? a > 4 : false;
            Console.WriteLine(bo);


            #endregion


            #region 作业

            //1.比较两个数的大小，求出最大的。
            Console.WriteLine("请分别输入两个数字");
            int i1 = int.Parse(Console.ReadLine());
            int i2 = int.Parse(Console.ReadLine());
            str = i1 > i2 ? "较大的数是i1="+i1 : "较大的数是i2="+i2;
            Console.WriteLine(str);

            //2.提示用户输入一个姓名，然后再控制台输出姓名，只要输入的不是帅哥，就显示美女。
            Console.WriteLine("请输入姓名：");
            str = Console.ReadLine();
            string strr = str== "帅哥" ? "帅哥":"美女";
            Console.WriteLine(strr);

            //3.依次输入学生的姓名，C#语言的成绩，Unity的成绩，两门成绩都大于等于90分，才能毕业，请输出最后的结果。
            string str1 = "小明";
            int c = 89;
            int u = 99;
            str = c >= 90 && u >= 90 ? "能毕业" : "不能毕业";
            Console.WriteLine(str1+str);

            //4.要求用户输入一个年份，然后判断是不是闰年？
            /*闰年判断条件：
                年份能被400整除（2000）
                或者
                年份能被4整除、但是不能被100整除（2008）
            */
            Console.WriteLine("请输入一个年份");
            int year = int.Parse(Console.ReadLine());
            str = year % 400 == 0 || year % 4 == 0 && year % 100 != 0 ? "是闰年" : "不是闰年";
            Console.WriteLine(str);

            #endregion


        }
    }
}
