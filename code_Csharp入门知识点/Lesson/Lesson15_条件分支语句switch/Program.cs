namespace Lesson15_条件分支语句switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点一 作用
            //让顺序执行的代码产生分支
            //一般配合枚举使用
            #endregion


            #region 知识点二 基本语法
            /*
            switch(变量1)
            {
                //变量1 ==常量1 时，执行case和break之间的代码
                case 常量1:
                            //满足条件执行的代码逻辑
                    break;
                case 常量2:
                            //满足条件执行的代码逻辑
                    break;
                //...case可以有无数个
                default:
                            //如果上面case的条件都不满足，就会执行default中的代码
                    break;
            }
            //注意常量只能写一个值，不能表示一个范围————EX.条件运算符 逻辑运算符
            //判断范围用if
            //switch 只判断变量是否等于某一个固定值
            */

            int a = 3;
            switch (a)
            {
                //case后一定要是常量，不能是范围、变量，必须是一个不能改变的、写死的数值
                case 1:
                    Console.WriteLine("a = 1");
                    break;
                case 2:
                    Console.WriteLine("a = 2");
                    break;
                case 3:
                    Console.WriteLine("a = 3");
                    break;
                default:
                    Console.WriteLine("什么条件都不满足，执行default中的内容");
                    break;
            }
            //case后可以是任意类型的常量
            float f = 3.87f;
            switch (f)
            {
                //case后一定要是常量，不能是范围、变量，必须是一个不能改变的、写死的数值
                case 1.54f:
                    Console.WriteLine("a = 1");
                    break;
                case 3.87f:
                    Console.WriteLine("a = 3");
                    break;
                default:
                    Console.WriteLine("什么条件都不满足，执行default中的内容");
                    break;
            }

            #endregion


            #region 知识点三 default可省略
            //类似if...else中的else 可省略
            #endregion


            #region 知识点四 可自定义常量
            char c = 'a';
            //常量必须初始化 不能修改
            const char c1 = 'a';
            switch (c)
            {
                case c1:        //c1是常量，所以可以写在这里
                                //若char前未定义const，则c1就是变量，就不能写在case后面
                    break;
                default:
                    break;
            }



            #endregion


            #region 知识点五 贯穿
            //作用 满足某些条件时，做的事情是一样的，就可以使用贯穿。
            //格式如下：
            int i = 4;
            switch (i)
            {
                //不写case后面配对的break就叫做贯穿
                //满足0 1 2 3 4 5其中一个条件就会执行该switch代码块外的代码
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("是个数字");      //所有case输出的内容一致，则可放到最后写。
                    Console.WriteLine("是个数字");
                    Console.WriteLine("是个数字");
                    Console.WriteLine("是个数字");      //case和break之间可以写n个语句
                    if(i < 3)
                    {
                        Console.WriteLine("是个数字");  //可以嵌套使用
                    }
                    break;
                default:
                    break;
            }

            #endregion


            #region 作业
            /*1.
             唐老狮的工资是由基本工资＋绩效决定的绩效说明：
            学生评价 很兴奋，则评定为A级，绩效工资500
            学生评价 很充实，则评定为B级，不加绩效工资
            学生评价 还好吧，则评定为C级，绩效工资扣300
            学生评价 难理解，则评定为D级，绩效工资扣500
            学生评价 枯燥泛味，则评定为E级，绩效工资扣800
            假设唐老狮的工资是4000
            请用户输入王老师的评级，并算出王老师的工资是多少？
             */
            
            Console.WriteLine("请输入A、B、C、D、E其中一个评级：");
            try
            {
                char cha = char.Parse(Console.ReadLine());
                int bill = 4000;
                switch (cha)
                {
                    case 'A':
                        bill = bill + 500;
                        break;
                    case 'B':
                        bill = bill;
                        break;
                    case 'C':
                        bill = bill - 300;
                        break;
                    case 'D':
                        bill = bill - 500;
                        break;
                    case 'E':
                        bill = bill - 800;
                        break;
                    default:
                        Console.WriteLine("FALSE!");
                        break;
                }
                Console.WriteLine("唐老师的工资是" + bill + "元");
            }
            catch
            {
                Console.WriteLine("输入错误，请从A、B、C、D、E其中一个评级选择一项输入！");
            }



            Console.WriteLine();


            /*2.
             小唐带了10元钱去星巴克买咖啡，三种型号选择：
                1=（中杯，¥5）
                2=（大杯，¥7）
                3=（超大杯，¥11）
              请用户输入选择的型号，如果钱够，则购买成功，并算出小王最后还剩多少钱？
              如果钱不够，则提示用户“钱不够，请换其他型号”
             */

            Console.WriteLine("请选择型号（超大杯、大杯、中杯）:");

            try
            {
                string str = Console.ReadLine();
                int money = 10;
                switch (str)
                {
                    case "中杯":
                        money = money - 5;
                        break;
                    case "大杯":
                        money = money - 7;
                        break;
                    case "超大杯":
                        money = money - 11;
                        break;
                    default:
                        money -= 10;
                        break;
                }
                if (money < 0)
                {
                    Console.WriteLine("钱不够，请换其他型号");
                }
                else if (money > 0)
                {
                    Console.WriteLine("购买成功，小王还剩的钱数为：" + money);
                }
                else
                {
                    Console.WriteLine("输入格式错误");
                }
            }
            catch
            {
                Console.WriteLine("输入错误，请从超大杯、大杯、中杯选择一项输入！");
            }

            


            /*3.
            输入学生的考试成绩，如果成绩>=90:A
            90>成绩>=80:B
            80>成绩 >= 70:C
            70> 成绩>= 60:D
            成绩<60:E
            （使用switch语法完成）
            最后输出学生的考试等级。
             */

            try
            { 
            Console.WriteLine("请输入学生的成绩");
            int grade = int.Parse(Console.ReadLine());
            char cc = 'A';
            if (grade >= 90)
            {
                cc = 'A';
            }
            if (grade >= 80 && grade < 90)
            {
                cc = 'B';
            }
            if (grade >= 70 && grade < 80)
            {
                cc = 'C';
            }
            if (grade >= 60 && grade < 70)
            {
                cc = 'D';
            }
            if (grade < 60)
            {
                cc = 'E';
            }

            switch (cc)
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                    Console.WriteLine("学生的考试等级为：" + cc);
                    break;

                default:
                    Console.WriteLine("False!");
                    break;
            }
            }
            catch
            {
                Console.WriteLine("格式错误！");
            }


            //4.在控制台输入一个（0~9）的数并显示为大写。如输入2，则显示二
            try
            { 
            Console.WriteLine("请输入一个整数：");
            char ccc = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (ccc)
            {
                case '0':
                    Console.WriteLine("零");
                    break;
                case '1':
                    Console.WriteLine("一");
                    break;
                case '2':
                    Console.WriteLine("二");
                    break;
                case '3':
                    Console.WriteLine("三");
                    break;
                case '4':
                    Console.WriteLine("四");
                    break;
                case '5':
                    Console.WriteLine("五");
                    break;
                case '6':
                    Console.WriteLine("六");
                    break;
                case '7':
                    Console.WriteLine("七");
                    break;
                case '8':
                    Console.WriteLine("八");
                    break;
                case '9':
                    Console.WriteLine("九");
                    break;
            }
            }
            catch
            {
                Console.WriteLine("格式错误，请输入一个整数。");
            }


            #endregion



        }
    }
}
