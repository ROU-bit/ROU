namespace Homework17_多态_vob
{
    #region 1
    //真的鸭子嘎嘎叫，木头鸭子吱吱叫，橡皮鸭子唧唧叫

    class Duck
    {
        public string sound;
        public Duck(string sound)
        {
            this.sound = sound;
        }
        public virtual void DuckSound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
    class TrueDuck : Duck
    {
        public TrueDuck(string sound) : base(sound)
        {

        }
        public override void DuckSound(string sound)
        {
            Console.Write("真的鸭子");
            base.DuckSound(sound);
        }
    }
    class WoodenDuck : Duck
    {
        public WoodenDuck(string sound) : base(sound)
        {

        }
        public override void DuckSound(string sound)
        {
            Console.Write("木头鸭子");
            base.DuckSound(sound);
        }
    }
    class RubberDuck : Duck
    {
        public RubberDuck(string sound) : base(sound)
        {

        }
        public override void DuckSound(string sound)
        {
            Console.Write("橡皮鸭子");
            base.DuckSound(sound);
        }
    }
    #endregion


    #region 2
    //所有员工9点打卡
    //但经理十一点打卡，程序员不打卡
    class Staff
    {
        public string time;
        public string position;
        public Staff(string time,string position)
        {
            this.time = time;
            this.position = position;
        }
        public virtual void ClockIn()
        {
            Console.WriteLine("{0}{1}打卡", position, time);
        }
    }
    class Manager : Staff
    {
        public Manager(string time, string position) : base(time, position) 
        {
        
        }
    }
    class Progarmmer : Staff
    {
        public Progarmmer(string time, string position) : base(time, position)
        {

        }
        public override void ClockIn()
        {
            Console.WriteLine("{0}不打卡", position);
        }
    }
    #endregion


    #region 3
    //创建一个图形类，有求面积和周长两个方法
    //创建矩形类、正方形类、圆形类继承图形类
    //实例化矩形、正方形、圆形对象求面积和周长

    class Shape
    {
        public virtual float ZhouChang()
        {
            return 0;
        }
        public virtual float MianJi()
        {
            return 0;
        }
        public void Speak(float f,float fl)
        {
            Console.WriteLine("周长为{0}，面积为{1}", f, fl);
        }
    }
    class Rectangle : Shape
    {
        private float x;
        private float y;
        public Rectangle(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public override float ZhouChang()
        {
            return 2*(x + y);
        }
        public override float MianJi()
        {
            return x * y;
        }
    }
    class Square : Shape
    {
        private float x;
        public Square(float x)
        {
            this.x = x;
        }
        public override float ZhouChang()
        {
            return 4 * x;
        }
        public override float MianJi()
        {
            return x * x;
        }
    }
    class Circle : Shape
    {
        private float r;

        public Circle(float r)
        {
            this.r = r;
        }
        public override float ZhouChang()
        {
            return 2 * 3.14f * r;
        }
        public override float MianJi()
        {
            return 3.14f * r * r;
        }
    }


    #endregion

    internal class Program
    {
        

        static void Main(string[] args)
        {
            #region 1
            Duck d1 = new TrueDuck("嘎嘎叫");
            d1.DuckSound("嘎嘎叫");
            Duck d2 = new WoodenDuck("吱吱叫");
            d2.DuckSound("吱吱叫");
            Duck d3 = new RubberDuck("唧唧叫");
            d3.DuckSound("唧唧叫");
            #endregion

            #region 2
            Staff st1 = new Manager("11点", "经理");
            st1.ClockIn();
            Staff st2 = new Progarmmer("", "程序员");
            st2.ClockIn();
            #endregion

            #region 3
            Rectangle re = new Rectangle(8, 4);
            re.Speak(re.ZhouChang(), re.MianJi());
            Square sq = new Square(8);
            sq.Speak(sq.ZhouChang(), sq.MianJi());
            Circle c = new Circle(4);
            c.Speak(c.ZhouChang(), c.MianJi());
            #endregion
        }
    }
}
