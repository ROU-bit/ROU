using System.Runtime.InteropServices;

namespace Lesson2_变量
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3、
            //名字
            string s1 = "程思琦";
            Console.WriteLine("名字:" + s1);
            //年龄
            int i1 = 21;
            Console.WriteLine("年龄:" + i1);
            //性别
            /*
             用bool表示性别时要定义true和false(顺序有意义！)
             EX : (bo ? "女":"男")        即true=女 false=男
            */
            bool bo1 = true;
            Console.WriteLine("性别:" + (bo1 ? "女" : "男"));
            //身高
            float f1 = 163.4f;
            Console.WriteLine("身高:" + f1 + "cm");
            //体重
            float f2 = 53.4f;
            Console.WriteLine("体重:" + f2 + "kg");
            //家庭住址
            string s2 = "遥远的北方";
            Console.WriteLine("地址:" + s2);

            //Console.WriteLine("{0}，{1}，{2}，{3}，{4}，{5}" , s1,i1, bo1 ? "女" : "男", f1,f2,s2);


            Console.WriteLine();



            //4、
            //也可以用byte（0~255）
            int a = 80, b = 78, c = 98;
            Console.WriteLine("小明的各项考试成绩为：");
            Console.WriteLine("数学：" + a);
            Console.WriteLine("语文：" + b);
            Console.WriteLine("英语：" + c);
        }
    }
}
