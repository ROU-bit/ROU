namespace Homework5_成员属性
{
    /*
     定义一个学生类，有五种属性，分别为姓名、性别、年龄、CSharp成绩、Unity成绩
     有两个方法：
     一个打招呼：介绍自己叫XX，今年几岁了。是男同学还是女同学
     计算自己总分数和平均分并显示的方法
     使用属性完成：“年龄必须是0~150岁之间，成绩必须是0~100
     性别只能是男或女
     实例化两个对象并测试
     */
    class Student
    {
        public string name;
        private bool sex;
        public bool Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if (value != false && value != true)
                {
                    sex = false;
                }
                else
                {
                    sex = value;
                }
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else if (value > 150)
                {
                    age = 150;
                }
                else
                {
                    age = value;
                }
                
            }
        }
        private int Csharp;
        private int Unity;
        public int agg;
        public int CsharpDegree
        {
            get
            {
                return Csharp;
            }
            set
            {
                if (value < 0)
                {
                    Csharp = 0;
                }
                else if (value > 100)
                {
                    Csharp = 100;
                }
                else
                {
                    Csharp = value;
                }

            }
        }public int UnityDegree
        {
            get
            {
                return Unity;
            }
            set
            {
                if (value < 0)
                {
                    Unity = 0;
                }
                else if (value > 100)
                {
                    Unity = 100;
                }
                else
                {
                    Unity = value;
                }

            }
        }

        public Student(string name, int age, bool sex, int Csharp, int Unity)
        {
            this.name = name;
            Age = age;
            this.sex = sex;
            UnityDegree = Unity;
            CsharpDegree = Csharp;
            agg = Calculate();
        }

        private int Calculate()
        {
            return Csharp + Unity;
        }

        public void Speak()
        {
            Console.WriteLine("我叫{0}，是一位{1}同学，我的总分数是{2}，我的平均分是{3}",name ,sex == false ? "女" : "男" ,agg ,agg/2);
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("ROU", 21, false, -86, 99);
            Student s2 = new Student("MAO", 22, true, 876, 84);
            s1.Speak();
            s2.Speak();

        }
    }
}
