namespace Lesson6_索引器
{

    #region 知识点一 索引器基本概念
    //基本概念
    //让对象可以像数组一样通过索引访问其中元素，使程序看起来更直观，更容易编写
    #endregion


    #region 知识点二 索引器语法
    //访问修饰符 返回值 this[参数类型 参数名，参数类型 参数名.....]
    //{
    //      内部写法和规则与索引器相同
    //      get{}
    //      set{}
    //}

    class Person
    {
        private string name;
        private string age;
        private Person[] friends;

        private int[,]array;

        #region 知识点五 索引器可以重载
        //重载的概念是——函数名相同(this) 参数类型、数量、顺序不同
        public int this[int i, int j]
        {
            get
            {
                return array[i, j];
            }
            set
            {
                array[i, j] = value;
            }
        }
        #endregion
        public Person this[int index]
        {
            
            get
            {
                //可以写逻辑 根据需求来处理这里面的内容
                #region 知识点四 索引器中可以写逻辑
                if (friends == null || index > friends.Length - 1)
                {
                    return null;
                }
                #endregion
                return friends[index];
            }
            set
            {
                //value代表传入的值
                //可以写逻辑 根据需求来处理这里面的内容
                if (friends == null)
                {
                    friends = new Person[] { value };
                }
                else if(index > friends.Length - 1)
                {
                    //自定义的规则，如果索引越界，就默认把最后一个朋友顶掉
                    friends[friends.Length - 1] = value;
                }
                friends[index] = value;
            }
        }
    }
    #endregion


    //总结
    //索引器对于我们来说的主要作用
    //可以让我们以中括号的形式访问自定义类中的元素 规则自己定 访问时和数组一样
    //比较适用于在类中有数组变量时使用，可以方便的访问和进行逻辑处理

    //固定写法
    //访问修饰符 返回值 this[参数列表]
    //get 和set语句块
    //可以重载

    //注意：
    //结构体中也支持索引器
   

    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点三 索引器的使用
            Person p = new Person();
            p[0] = new Person();
            Console.WriteLine(p[0]);
            #endregion

        }
    }
}
