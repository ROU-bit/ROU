namespace Lesson2_封装_成员变量和访问修饰符
{

    #region 知识回顾
    //类和对象
    //申明类
    //class Person
    //{
    //    //*特征——成员变量*
    //    //行为——成员方法
    //    //保护特征——成员属性

    //    //构造函数和析构函数
    //    //索引器
    //    //运算符重载
    //    //静态成员
    //}

    //实例化对象
    // Person 变量名;                      //申明了一个空对象
    // Person 变量名 = null;               //申明了一个空对象
    // Person 变量名 = new Person();       //申明了一个实实在在的对象
    #endregion


    #region 知识点一 成员变量
    //基本规则
    //1.申明在类语句块中
    //2.用来描述对象的特征
    //3.可以是任意变量类型
    //4.数量不做限制
    //5.是否赋值(初始化)根据需求决定


    //性别
    enum E_SexType
    {
        Man,
        Woman,
    }
    struct Positin
    {
        //位置结构体
    }
    class Pet
    {
        //宠物类
    }
    class Person
    {
        //特征——成员变量
        //姓名
        public string name = "ROU";    //可以初始化
        //年龄
        public int age;
        //性别
        public E_SexType sex;          //可以是枚举变量
        //伴侣
        public Person couple;          //在类里可以申明和自己一样的变量类型，但不能实例化（可以等于空，但不能new 会造成内存溢出）
        //朋友
        public Person[] friend;        //可以是数组变量
        //位置
        public Positin place;          //可以是结构体变量
        //宠物
        public Pet pet;                //可以是另一个类

    }
    #endregion


    #region 知识点二 访问修饰符
    // public       —— 公共的 自己（类内部）和别人（外部）都能访问和使用
    // private      —— 私有的 自己（类内部）才能访问和使用 【不写默认为private】
    // protected    —— 保护的 自己（类内部）和子类才能访问和使用
    // 目前决定类内部的成员的访问权限
    #endregion






    internal class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();        //实例化 new之后默认拥有初始值

            #region 知识点三 成员变量的使用和初始值
            //值类型 —— 数字类型默认值均为0 bool类型初始值为false char类型默认为空字符
            //引用类型 —— 初始值均为空null
            //看默认/初始值的小技巧      default(变量类型) 就能得到默认值
            Console.WriteLine(default(int));    //0
            Console.WriteLine(default(bool));   //False
            Console.WriteLine(default(Person)); //              //即null 空

            //使用
            Console.WriteLine(p.age);           //0             //初始值
            p.age = 10;
            Console.WriteLine(p.age);           //10
            #endregion

        }
    }
    //总结
    //成员变量
    //描述特征
    //类中申明
    //赋值随意
    //默认值 值不相同
    //默认值 引用为null
    //任意类型
    //任意数量

    //访问修饰符
    //3p
    //public        公共的 内外
    //private       私有的 内
    //protected     保护的 内和子类

}
