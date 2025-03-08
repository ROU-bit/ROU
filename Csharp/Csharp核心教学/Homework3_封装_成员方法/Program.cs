namespace Homework3_封装_成员方法
{
    #region 1
    //基于成员变量练习题
    //为人类定义说话、走路、吃饭等方法
    class Person
    {
        //对象
        public string name;
        //身高
        public float height;
        //年龄
        public int age;
        //家庭住址
        public string homeAdress;

        public void Speak(string str)
        {
            Console.WriteLine(str);
        }
        public void Walk()
        {

        }
        public void Eat(Food f)
        {
            Console.WriteLine("{0}吃了{1}", name, f.name);
        }

    }
    #endregion


    #region 2
    //基于成员变量练习题
    //为学生类定义学习、吃饭等方法
    class Student
    {
        //姓名
        public string name;
        //学号
        public int num;
        //年龄
        public int age;
        //同桌
        public Student deskmate;

        public void Study()
        { 
        
        }
        public void Eat(Food f)
        {
            Console.WriteLine("{0}吃了{1}", name, f.name);
        }

    }

    #endregion


    #region 3
    //定义一个食物类，有名称、热量等特征
    //思考如何和人类以及学生类联系起来
    class Food
    {
        public string name;
        public int calorie;
    }
    #endregion








    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "ROU";
            Student s = new Student();
            s.name = "MAO";
            Food f = new Food();
            f.name = "汉堡包";

            p.Eat(f);
            s.Eat(f);
        }
    }
}
