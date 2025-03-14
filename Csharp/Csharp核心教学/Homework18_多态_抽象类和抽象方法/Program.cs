namespace Homework18_多态_抽象类和抽象方法
{

    #region 1
    //写一个动物抽象类，写三个子类
    //人叫、狗叫、猫叫

    abstract class Animal
    {
        public abstract void Speak();
    }
    class Person : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("waaaaaaaaaaaaaaa");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("wangwangwangwang");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("miaomiaomiaomiao");
        }
    }
    #endregion


    #region 2
    //创建一个图形类，有求面积和周长两个方法
    //创建矩形类，正方形类，圆形类继承图形类
    //实例化矩形、正方形、圆形对象求面积和周长

    abstract class Shape
    {
        public abstract float S();
        public abstract float C();
        public void Speakk(float s, float c)
        {
            Console.WriteLine("该图形的面积为{0} 周长为{1}",s,c);
        }
    }
    class Rectangle : Shape
    {
        public float X;
        public float Y;
        public Rectangle(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
        public override float S()
        {
            return X * Y;
        }
        public override float C()
        {
            return 2 * (X + Y);
        }
    }
    class Square : Shape
    {
        public float X;
        public Square(float x)
        {
            this.X = x;
        }
        public override float S()
        {
            return X * X;
        }
        public override float C()
        {
            return 4 * X;
        }
    }
    class Circle : Shape
    {
        public float r;
        public Circle(float r)
        {
            this.r = r;
        }
        public override float S()
        {
            return 3.14f * r * r;
        }
        public override float C()
        {
            return 2 * 3.14f * r;
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Person p = new Person();
            p.Speak();
            Dog d = new Dog();
            d.Speak();
            Cat c = new Cat();
            c.Speak();
            #endregion

            #region 2
            Rectangle re = new Rectangle(8, 4);
            re.Speakk(re.S(), re.C());
            Square s = new Square(8);
            s.Speakk(s.S(), s.C());
            Circle ci = new Circle(4);
            ci.Speakk(ci.S(), ci.C());
            #endregion


        }
    }
}
