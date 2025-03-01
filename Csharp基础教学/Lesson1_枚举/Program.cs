namespace Lesson1_枚举
{
    #region 知识点一 基本概念

    #region 1.枚举是什么
    //枚举是一个比较特别的存在
    //它是一个*被命名的整形常量的集合*
    //一般用它来表示状态、类型等等
    #endregion

    #region 2.申明枚举和申明枚举变量的区别
    //注意：申明枚举和申明枚举变量是两个概念
    //申明枚举：相当于是创建一个自定义的枚举类型
    //申明枚举变量：使用申明的自定义枚举类型来创建一个枚举变量
    #endregion

    #region 3.申明枚举语法
    //枚举名以E或者E_开头 是命名规范
    //根据公司要求来
    /*
    enum E_自定义枚举名
    {
      自定义枚举项名字0,      //枚举中包裹的整形常量 第一个默认值是0 下面的依次累加
        自定义枚举项名字1,
        自定义枚举项名字2,
        自定义枚举项名字3,(最后一个逗号可省略)
    }

    enum E_自定义枚举名
    {
        自定义枚举项名字0 = 5,      //第一个枚举项的默认值为5，下面依次累加
        自定义枚举项名字1,          //6
        自定义枚举项名字2 = 100,    //100
        自定义枚举项名字3,          //101       在上一个的基础上进行累加
    }
    */

    #endregion

    #endregion


    #region 知识点二 在哪里申明枚举
    //1.namespace语句块中 （常用）
    //2.class语句块中
    //3.struct语句块中
    //注意：枚举不能在函数语句块中申明！！！

    enum E_MonsterType
    {
        Normal,

        Boss,
    }

    enum E_PlayerType
    {
        Main,

        Other,
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举");

            #region 知识点三 枚举的使用
            //申明枚举变量
            //自定义的枚举类型 变量名 = 默认值;(自定义的枚举类型.枚举项)
            E_PlayerType playerType = E_PlayerType.Main;

            if(playerType == E_PlayerType.Main)
            {
                Console.WriteLine("主玩家逻辑");
            }
            else if(playerType == E_PlayerType.Other)
            {
                Console.WriteLine("其他玩家逻辑");
            }

            //枚举和switch是天生一对
            E_MonsterType monsterType = E_MonsterType.Boss;
            switch (monsterType)
            {
                case E_MonsterType.Normal:
                    Console.WriteLine("普通怪物的逻辑");
                    break;
                case E_MonsterType.Boss:
                    Console.WriteLine("boss怪的逻辑");
                    break;
                default:
                    break;
            }

            #endregion


            #region 知识点四 枚举的类型转换
            //1.枚举和int互转
            int i =(int)playerType;
            Console.WriteLine(i);               //0
            //int转枚举
            playerType = 0;

            //2.枚举和string相互转换
            string str = playerType.ToString(); //打印枚举项的名字
            Console.WriteLine(str);             //Main
            //string转枚举
            //Parse后第一个参数：你要转为哪个枚举类型
                   //第二个参数：用于转换的对应枚举项的字符串
            //转换完毕后是一个通用的类型 我们需要用括号强转成我们想要的目标枚举类型
            playerType = (E_PlayerType)Enum.Parse(typeof(E_PlayerType),"Other");
            Console.WriteLine(playerType);      //other

            #endregion


            #region 知识点五 枚举的作用
            //在游戏开发中，对象很多时候会有许多状态
            //比如玩家有一个动作状态 我们需要用一个变量或者标识来表示当前玩家处于的是哪种状态
            //综合考虑 可能会使用int来表示他的状态
            //1 行走 2 待机 3 跑步 4 跳跃 ......

            //枚举可以帮助我们清晰的分清楚状态的含义

            #endregion


        }
    }
}

