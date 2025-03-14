namespace Lesson12_继承_继承的基本规则
{
    #region 知识点一 基本概念
    //一个类A继承一个类B
    //类A将会继承类B中的所有成员
    //A类将拥有B类的所有特征和行为

    //被继承的类
    //成为父类、基类、超类

    //继承的类
    //成为子类、派生类

    //子类可以有自己的特征和行为

    //特点
    //1.单根性 子类只能有一个父类
    //2.传递性 子类可以间接继承父类的父类
    #endregion


    #region 知识点二 基本语法
    //class 类名（子类） : 被继承的类名（父类）
    //{

    //}
    #endregion


    #region 知识点三 实例
    class Teacher
    {
        //姓名
        public string name;
        //职工号
        //希望内部和子类可以使用 但是外部不允许访问
        //protected int number;
        public int number;
        //介绍名字的行为
        public void SpeakName()
        {
            Console.WriteLine(name);
        }
    }
    class TeachingTeacher : Teacher         //只能有一个父类
    {
        //public new string name;           //直接覆盖父类中的同名成员
        //科目
        public string subject;
        //介绍科目的行为
        public void SpeakSubject()
        {
            Console.WriteLine(subject + "老师");
        }
    }
    class ChineseTeacher : TeachingTeacher
    {
        public void Skill()
        {
            Console.WriteLine("一行白鹭上青天。");
        }
    }
    #endregion


    #region 知识点四 访问修饰符的影响
    //public - 公共 内外部访问
    //private - 私有 内部访问
    //protected - 保护 内部和子类访问

    //之后讲命名空间的时候讲
    //internal - 内部的 只有在同一个程序集的文件中，内部类型或者是成员才可以访问
    #endregion

    #region 知识点五 子类和父类的同名成员
    //概念
    //c#中允许子类存在和父类同名的成员
    //但是 极不建议使用
    #endregion




    internal class Program
    {
        static void Main(string[] args)
        {
            TeachingTeacher tt = new TeachingTeacher();
            //直接使用父类中的成员
            tt.name = "ROU";
            tt.number = 1;
            tt.SpeakName();
            //使用自己的成员
            tt.subject = "Unity";
            tt.SpeakSubject();

            ChineseTeacher ct = new ChineseTeacher();
            //使用父类的成员
            ct.subject = "c#";
            ct.SpeakSubject();
            //使用父类的父类中的成员
            ct.name = "MAO";
            ct.number = 2;
            ct.SpeakName();
        }
    }

    //总结
    //继承的基本语法
    //class 类名 : 父类名
    // 1.单根性————只能继承一个父类
    // 2.传递性————子类可以继承父类的父类的....的所有内容
    // 3.访问修饰符对成员的影响    3p

    //4.极其不建议使用在子类中申明和父类同名的成员（以后学习了多态再来解决这个问题）
}
