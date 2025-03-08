namespace Homework1_类和对象
{
    #region 1
    //将下面的事物进行分类，可重复
    class Animal
    {
        //人、张阿姨、隔壁老王、猫
    }
    class Flower
    {
        //向日葵、菊花、荷花
    }
    class Machine
    {
        //机器人、机器、汽车、飞机
    }
    class Planet
    {
        //太阳、星星
    }
    #endregion


    #region 2
    //GameObject A = new GameObject();
    //GameObject B = A;                         //指向不同的栈地址，但是指向同一个堆内存空间
    //B = null;                                 //断开了B的指向，并不影响A的堆内存
    //A目前等于多少？
    //  new GameObject();
    #endregion


    #region 3
    //GameObject A = new GameObject();
    //GameObject B = A;                     
    //B = new GameObject();                     //new只改变栈中的地址，并不影响堆
    //A和B有什么关系？
    //  没有关系
    #endregion



    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
