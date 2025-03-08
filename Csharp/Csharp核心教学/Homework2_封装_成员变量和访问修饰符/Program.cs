using System.Security.Cryptography.X509Certificates;

namespace Homework2_封装_成员变量和访问修饰符
{
    #region 1
    //3p是什么
    //public        共有的 对内外
    //private       私有的 仅对内
    //protected     保护的 对内对子类
    #endregion


    #region 2
    //定义一个人类Person，有姓名、身高、年龄、家庭住址等特征
    //用人创建若干个对象p
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
    }


    #endregion


    #region 3
    //定义一个学生类Student，有姓名、学号、年龄、同桌等特征。
    //用学生类创建若干个学生s
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

    #endregion


    #region 4
    //定义一个班级类Clas，有专业名称，教室容量，学生等
    //创建一个班级对象clas
    class Class
    {
        //专业名称
        public string majorName;
        //教室容量
        public int capecity;
        //学生
        public Student[] students;
    }

    #endregion

    internal class Program
    {



        static void Main(string[] args)
        {
            //2.创建若干个对象p
            Person p1 = new Person();
            p1.age = 21;
            p1.name = "ROU";
            p1.height = 163.5f;
            p1.homeAdress = "安徽淮南田家庵区";
            Person p2 = new Person();
            p2.age = 22;
            p2.name = "MAO";
            p2.height = 157.5f;
            p2.homeAdress = "安徽亳州利辛";

            //class里包裹的内容都被包含在堆内存里
            #region 5
            /*
             Person p1 = new Person();             
             p1.age = 10;
             Person p2 = new Person();
             p2.age = 20;
             请问p1.age为多少？
             
            //为10
             */
            #endregion
            #region 6
            /*
             Person p1 = new Person();             
             p1.age = 10;
             Person p2 = p;
             p2.age = 20;
             请问p1.age为多少？
             
            //为20
             */
            #endregion


            //3.创建若干个学生s
            Student s1 = new Student();
            s1.age = 21;
            s1.name = "ROU";
            s1.num = 5;
            Student s2 = new Student();
            s2.age = 22;
            s2.name = "MAO";
            s2.deskmate = s2;
            s2.num = 7;
            //二人互为同桌
            s1.deskmate = s2;
            s2.deskmate = s1;
            #region 7
            /*
             Student s1 = new Student();             
             s1.age = 10;                   //class类中的变量 具体内容存在堆中
             int age = s1.age;              //申明值类型age 具体内容存在栈中
             age = 20;
             请问s1.age为多少？
             
            //为10
             */
            #endregion
            #region 8
            /*
             Student s1 = new Student();        //s1
             s.deskmate = new Student();        //s3
             s.deskmate.age = 10;               //s3.age = 10
             Student s2 = s.deskmate;           //s2 = s3
             s2.age = 20;                       //s2.age = 20
             请问s.deskmate.age为多少？          //s3 = ？
             
            //为20
             */
            #endregion

            //4.创建一个班级对象c
            Class c = new Class();
            c.students = new Student[] { s1, s2 };      //学生类里实例化的对象s1、s2
            c.capecity = 40;
            c.majorName = "Unity";



        }
    }
}
