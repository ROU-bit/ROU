namespace Lesson3_封装_成员方法
{

    #region 知识点一 成员方法申明
    //基本概念
    //成员方法（函数）用来表现对象行为
    // 1.申明在类语句块中
    // 2.用来描述对象的行为
    // 3.规则和函数申明规则相同
    // 4.收到访问修饰符规则影响
    // 5.返回值参数不做限制
    // 6.方法数量不做限制

    //注意
    // 1.成员方法不要加static（静态）关键字
    // 2.成员方法 必须实例化出对象 再通过对象来使用 相当于该对象执行了某个行为
    // 3.成员方法 受到访问修饰符（3p）影响

    class Person
    {
        //成员方法
        /// <summary>
        /// 说话的行为
        /// </summary>
        /// <param name="str">说话的内容</param>
        public void Speak(string str)
        {
            Console.WriteLine("{0}说{1}", name, str);
        }
        /// <summary>
        /// 添加朋友的方法
        /// </summary>
        /// <param name="p">传入新朋友</param>
        public void AddFriend(Person p)
        {
            if (friends == null)
            {
                friends = new Person[] { p };
            }
            else
            {
                //扩容 新建一个房子数组
                Person[] newFriends = new Person[friends.Length + 1];
                //搬家
                for (int i = 0; i < friends.Length; i++)
                {
                    newFriends[i] = friends[i];
                }
                //把新加的朋友放到最后一个
                newFriends[newFriends.Length - 1] = p;
                //地址重定向
                friends = newFriends;
            }
        }

        //成员变量
        public string name;
        public int age;
        //朋友们
        public Person[] friends;

        //二者顺序不重要 c++一般将方法写在变量前面

        //成员方法
        /// <summary>
        /// 判断是否成年
        /// </summary>
        /// <returns></returns>
        public bool isAdult()
        {
            return age > 18;
        }

        

    }


    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点二 成员方法的使用
            // 2.成员方法 必须实例化出对象 再通过对象来使用 相当于该对象执行了某个行为
            Person p = new Person();
            p.name = "ROU";
            p.age = 21;
            p.Speak("我爱你");

            if (p.isAdult())
            {
                p.Speak("我要s猫ke");
            }

            Person p2 = new Person();
            p2.name = "MAO";
            p2.age = 22;

            p.AddFriend(p2);
            
            for(int i = 0;i < p.friends.Length;i++)
            {
                Console.WriteLine(p.friends[i].name);
            }
            #endregion

        }
    }
    //总结
    //成员方法
    //描述行为
    //类中申明
    //任意数量
    //返回值和参数根据需求决定
}
