namespace Lesson2_一维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点一 基本概念
            //数组是存储一组*相同类型*数据的集合
            //数组分为一维、多维、交错数组
            //一般情况下一维数组简称为数组
            #endregion


            #region 知识点二 数组的申明

            //1.
            //变量类型[] 数组名;       //只是申明了一个数组，并没有在内存中分配，并没有初始化
            //初始化简单来说，就是给某个变量、对象或者数组等设置初始值的过程。
            //变量类型可以是目前学过的、没学过的所有变量类型（常见14种变量类型、枚举...）
            //EX.
            int[] arr1;

            //2.
            //变量类型[] 数组名 = new 变量类型[ 数组的长度 ];
            int[] arr2 = new int[5];            //这种方式相当于开了五个房间，但是房间里面的int值默认为0

            //3.
            //变量类型[] 数组名 = new 变量类型[ 数组的长度 ]{ 内容1,内容2,内容3......};
            //数组的长度有多少，就要填多少内容
            int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
            bool[] arr6 = new bool[] { true, false };

            //4.
            //变量类型[] 数组名 = new 变量类型[]{ 内容1,内容2,内容3......};
            int[] arr4 = new int[] { 1, 2, 3, 4, 5 };   //后面的内容决定了数组的长度(房间数)

            //5.
            //变量类型[] 数组名 = { 内容1,内容2,内容3......};
            int[] arr5 = { 1, 2, 3, 4, 5 };             //后面的内容决定了数组的长度(房间数)

            #endregion


            #region 知识点三 数组的使用

            int[] array = { 1, 2, 3, 4, 5 };

            //1.数组的长度
            //数组变量名.Length
            Console.WriteLine(array.Length);        //5     *此数组长度为5


            //2.获取数组中的元素
            //数组中的下标和索引是从0开始的
            //通过索引下标去获得数组中某一个元素的值时要注意*不能越界*！！！
            //数组的房间号范围时 0 ~ Length - 1
            //即此处array[]中的数只能是 0 ~ 4
            Console.WriteLine(array[0]);            //1     *第一个位置上的数是1


            //3.修改数组中的元素
            array[0] = 99;
            Console.WriteLine(array[0]);            //99    *第一个位置上的数改为99
                                                    //只能改为同一类型的值

            //4.遍历数组
            //通过*for循环*快速获取数组中的每一个元素
            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write(array[i]+" ");        //99 2 3 4 5
            }
            Console.WriteLine();


            //5.增加数组的元素
            //数组初始化以后不能直接增加新元素
            int[] array2 = new int[6];
            //复制到另一个地址里
            for (int i = 0;i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            //将原有数组指新地址
            array = array2;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");     //99 2 3 4 5 0
            }
            Console.WriteLine();
            //添加数组新元素
            array[5] = 999;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");     //99 2 3 4 5 999
            }
            Console.WriteLine();


            //6.删除数组的元素
            //数组初始化以后不能直接删除元素
            int[] array3 = new int[4];
            for (int i = 0;i < array3.Length; i++)
            {
                array3[i] = array[i];
            }
            array = array3;
            for (int i = 0;i < array.Length ; i++)
            {
                Console.Write(array[i] + " ");      //99 2 3 4
            }
            Console.WriteLine();
            //删除中间一个数该如何写


            //7.查找数组中的元素
            //99 2 3 4
            //要查找3这个元素在哪个位置
            //只有通过遍历才能确定数组中是否存储了一个目标元素
            int a = 3;

            for (int i = 0; i < array.Length; i++)
            {
                if( a == array[i])
                {
                    Console.WriteLine("和a相等的元素{0}号位", i);       //和a相等的元素2号位
                    break;
                }
            }

            #endregion


            //总结
            //1.概念：同一变量类型的数据集合
            //2.一定要掌握：数组的申明、遍历、增删查改
            //3.所有的变量类型都可以申明为数组
            //4.它是用来批量存储游戏中同一类型对象的容器        EX.游戏中所有的怪物、所有的玩家


        }
    }
}
