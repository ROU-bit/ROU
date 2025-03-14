namespace Homework19_多态_接口
{
    #region 1
    //人、汽车、房子都需要登记，人需要到派出所登记，汽车需要去车管所
    //登记，房子需要去房管局登记
    //使用接口实现登记方法

    interface ICheckIn
    {
        void CheckIn();
    }
    class Person : ICheckIn
    {
        public void CheckIn()
        {
            Console.WriteLine("人要去派出所登记");
        }
    }
    class Car : ICheckIn
    {
        public void CheckIn()
        {
            Console.WriteLine("汽车去车管所登记");
        }
    }
    class House : ICheckIn
    {
        public virtual void CheckIn()
        {
            Console.WriteLine("房子去房管局登记");
        }
    }
    #endregion


    #region 2
    //麻雀、鸵鸟、企鹅、鹦鹉、直升机、天鹅
    //直升机和部分鸟能飞
    //鸵鸟和企鹅不能飞
    //企鹅和天鹅能游泳
    //除直升机，其它都能走
    //请用面向对象相关知识实现
    interface IFly
    {
        void Fly();
    }
    interface ISwim
    {
        void Swim();
    }
    interface IWalk
    {
        void Walk();
    }
    abstract class Birds
    {
        public abstract void Walk();
    }
    class MaQue : Birds, IFly
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public override void Walk()
        {

        }
    }
    class TuoNiao : Birds
    {
        public override void Walk()
        {

        }
    }
    class QiE : Birds
    {
        public override void Walk()
        {

        }
    }
    class YingWu : Birds
    {
        public override void Walk()
        {

        }
    }
    class TianE : Birds
    {
        public override void Walk()
        {

        }
    }
    class Helicopter
    {

    }
    #endregion


    #region 3
    //多态来模拟移动硬盘、U盘、MP3查到电脑上读取数据
    //移动硬盘与U盘都属于存储设备
    //MP3属于播放设备
    //但他们都能插在电脑上传输数据
    //电脑提供了一个USB接口
    //请实现电脑的传输数据的功能
    interface IStroage
    {
        void Stroage();
    }
    interface IBoardCast
    {
        void BoardCast();
    }
    interface IUsb
    {
        void Usb();
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //ICheckIn ic1 = new Person();
            //ICheckIn ic2 = new Car();
            //ICheckIn ic3 = new House();
            ICheckIn[] arr = new ICheckIn[] { new Person(), new Car(), new House() };
            //ic1.CheckIn();
            //ic2.CheckIn();
            //ic3.CheckIn();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].CheckIn();
            }
            #endregion

        }
    }
}
