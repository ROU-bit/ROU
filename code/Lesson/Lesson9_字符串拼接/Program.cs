namespace Lesson9_字符串拼接
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 知识点一 字符串拼接方式1
            //算数运算符只能用来数值类型变量进行数学运算
            //而string不存在算术运算、不能计算，但是可以用+来进行字符串拼接
            //string + 某变量 = 字符串拼接
            string str1 = "123";

            str1 = str1 + "456";
            Console.WriteLine(str1);
            str1 = str1 + 1;
            Console.WriteLine(str1);

            //复合运算符 +=
            str1 = "123";
            str1 += "1" + 4 + true;
            Console.WriteLine(str1);

            //注意下列不同处
            str1="123";
            str1 += 1 + 2 + 3 + 4;
            Console.WriteLine(str1);            //12310
            str1 = "123";
            str1 = str1+ 1 + 2 + 3 + 4;         //1231234
            Console.WriteLine(str1);

            str1 += ""+1 + 2 + 3 + 4;           //123101234
            Console.WriteLine(str1);
                                                //字符串前可计算，字符串后一律视为字符串
            str1 = 1 + 2 + "" + 3 + 4;          //334
            Console.WriteLine(str1);
            str1 = 1 + 2 + "" + (3 + 4);        //37
            Console.WriteLine(str1);


            //字符串拼接只能用+号相连，不能搞花样。
            #endregion


            #region 知识点二 字符串拼接方式2
            //固定语法 string.Format("待拼接的内容"，内容1，内容2......)；
            //拼接内容中的固定规则
            //想要被拼接的内容用占位符替代{数字} 数字0~n 依次往后

            string str2 = string.Format("我是{0}，我今年{1}岁，我想要{2}","ROU",21,"吃饭");
            Console.WriteLine(str2);                                    //我是ROU，我今年21岁，我想要吃饭
            str2 = string.Format("{0},{1},{2}", 0.45, false, 'A');      
            Console.WriteLine(str2);                                    //0.45,False,A
            //可以但是不推荐 Console.WriteLine(string.Format("{0},{1},{2}", 0.45, false, 'A'));

            #endregion


            #region 控制台打印拼接

            Console.WriteLine("{0}A{1}4{2}", 0.45, false, 'A');
            //即 Console.WriteLine(string.Format("{0},{1},{2}", 0.45, false, 'A'));
            Console.Write("{0}A{1}4{2}", 0.45, false, 'A');

            Console.WriteLine("{0}A{1}4{2}", 0.45, false, 'A',5,5);         //0.45AFalse4A  变量多不报错
                                                                            //Console.WriteLine("{0}A{1}4{2}", 0.45);                       //error         变量少报错

            #endregion

            Console.WriteLine("***********************");

            #region 作业
            //1.定义一个变量存储客户的姓名，然后再屏幕上显示：“你好，XXX”,XXX代表客户的姓名。
            Console.WriteLine("请输入你的名字:" );
            string yourName = Console.ReadLine();
            Console.WriteLine("你好，"+yourName);
            //&
            string yourNamee = string.Format("hello,"+yourName);
            Console.WriteLine(yourNamee);


            //2.定义两个变量，一个存储客户的姓名，另一个存储年龄，然后再屏幕上显示：“xxx + yYY岁了”。
            //xxx代表客户的姓名，yy代表年龄。举例（唐老狮18岁了）
            Console.WriteLine("请输入你的名字:");
            string youName = Console.ReadLine();
            Console.WriteLine("请输入你的年龄:");
            int youAge = int.Parse(Console.ReadLine());
            Console.WriteLine(youName + youAge + "岁了。");


            //3.当我们去面试时，前台会要求我们填一张表格，有姓名，年龄，邮箱，家庭住址，期望工资，请把这些信息在控制台输出。
            Console.WriteLine("请输入你的名字:");
            string myName = Console.ReadLine();
            Console.WriteLine("请输入你的年龄:");
            int myAge = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入你的邮箱:");
            string myEmail = Console.ReadLine();
            Console.WriteLine("请输入你的家庭住址:");
            string myAdress = Console.ReadLine();
            Console.WriteLine("请输入你的期望工资:");
            int myBill = int.Parse(Console.ReadLine());

            Console.WriteLine("姓名：{0}\n年龄：{1}\n邮箱：{2}\n家庭住址：{3}\n期望工资：{4}", myName,myAge, myEmail, myAdress, myBill);


            //4.请用户输入用户名、年龄、班级，最后一起用占位符形式打印出来
            Console.WriteLine("请输入你的名字:");
            string Name = Console.ReadLine();
            Console.WriteLine("请输入你的年龄:");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入你的班级:");
            string classs = Console.ReadLine();

            Console.WriteLine("姓名：{0}\n年龄：{1}\n班级：{2}", Name, Age, classs);


            #endregion


        }
    }
}
