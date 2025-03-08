namespace Homework4_封装_构造函数和析构函数
{

    #region 1
    //基于成员方法练习题
    //对人类的构造函数进行重载，用人类创建若干个对象
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

        public Person(string name, float height, int age, string homeAdress)
        {
            this.name = name;
            this.height = height;
            this.age = age;
            this.homeAdress = homeAdress;
        }
        public Person(string name, float height, int age)
        {
            this.name = name;
            this.height = height;
            this.age = age;
        }

    }
    #endregion


    #region 2
    //基于成员变量练习题
    //对班级类的构造函数进行重载，用班级类创建若干个对象
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
    }
    class Class
    {
        //专业名称
        public string majorName;
        //教室容量
        public int capecity;
        //学生
        public Student[] students;

        public Class(string majorName, int capecity)
        {
            this .majorName = majorName;
            this .capecity = capecity;
        }
        public Class(Student[] students)
        {
            this.students = students;
        }
        public Class(string majorName, int capecity, Student[] students):this(majorName, capecity)
        {
            this.students = students;
        }
    }
    #endregion


    #region 3
    /*
     写一个Ticket类，有一个距离变量（在构造对象时赋值，不能为负数），
     有一个价格特征，有一个方法GetPrice可以读取到价格，并且根据距离distance计算价格price（1元/公里）
     0~100公里 不打折
     101~200公里 打9.5折
     201~300公里 打9折
     300公里以上 打8折
     有一个显示方法可以显示这张票的信息
     例如：100公里100块钱
     */
    class Ticket
    {
        public float price;
        public float distance;

        public Ticket(float distance)
        {
            this.distance = distance;
            price = GetPrice();
        }

        private float GetPrice()
        {
            if (distance >= 0 && distance <= 100)
            {
                return distance;
            }
            else if (distance > 100 && distance <= 200)
            {
                return distance * 0.95f;
            }
            else if (distance > 200 && distance <= 300)
            {
                return distance * 0.9f;
            }
            else if(distance > 300)
            {
                return distance * 0.8f;
            }
            return 0;
        }
        public void display()
        {
            Console.WriteLine("{0}公里{1}块钱", distance, price);
        }



    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket t = new Ticket(52);
            Ticket t2 = new Ticket(134);
            Ticket t3 = new Ticket(265);
            Ticket t4 = new Ticket(752);
            t.display();
            t2.display();
            t3.display();
            t4.display();
        }
    }
}
