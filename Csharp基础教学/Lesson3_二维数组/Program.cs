namespace Lesson3_二维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点一 基本概念
            //二维数组 是使用两个下标（索引）来确定元素的数组
            //两个下标可以理解为行标和列标
            /*
             比如下列矩阵
             1 2 3
             4 5 6
             就可以使用二维数组int[2,3]表示
             即两行三列的数据集合
            */
            #endregion


            #region 知识点二 二维数组的申明

            //1.
            //变量类型[,] 二维数组变量名;
            int[,] arr;     //申明后会在后面进行初始化

            //2.
            //变量类型[,] 二维数组变量名 = new 变量类型[行,列];
            int[,] arr2 = new int[3, 3];        //默认内容是0

            //3.
            //变量类型[,] 二维数组变量名 = new 变量类型[行,列]{{0行0列内容1,0行1列内容2......},{1行0列内容1,1行1列内容2......}......};
            int[,] arr3 = new int[3, 3] { { 1, 2, 3 }, 
                                          { 4, 5, 6 }, 
                                          { 7, 8, 9 } };

            //4.
            //变量类型[,] 二维数组变量名 = new 变量类型[,]{{0行0列内容1,0行1列内容2......},{1行0列内容1,1行1列内容2......}......};
            int[,] arr4 = new int[,] { { 1, 2, 3 },
                                       { 4, 5, 6 },
                                       { 7, 8, 9 } };

            //5.
            //变量类型[,] 二维数组变量名 = {{0行0列内容1,0行1列内容2......},{1行0列内容1,1行1列内容2......}......};
            int[,] arr5 = { { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 } };

            #endregion


            #region 知识点三 二维数组的使用

            int[,] array = new int[,] { { 1, 2, 3 },
                                        { 4, 5, 6 } };

            //1.二维数组的长度
            //获取行和列各自的长度
            Console.WriteLine(array.GetLength(0));      //0代表获取该数组的行        //2
            Console.WriteLine(array.GetLength(1));      //1代表获取该数组的列        //3


            //2.获取二维数组中的元素
            //注意：第一个元素的索引（下标）是0，最后一个元素的索引是长度-1
            //不能越界
            Console.WriteLine(array[0, 1]);             //2
            Console.WriteLine(array[1, 2]);             //6

            Console.WriteLine("**********************");


            //3.修改二维数组中的元素
            array[0, 0] = 99;
            Console.WriteLine(array[0, 0]);             //99

            Console.WriteLine("**********************");


            //4.遍历二维数组
            for (int i = 0 ; i < array.GetLength(0); i++)        //i行
            {
                for(int j = 0 ; j < array.GetLength(1); j++)    //j列
                {
                    Console.WriteLine(array[i, j]);
                    //0,0 0,1 0,2
                    //1,0 1,1 1,2
                }
            }

            Console.WriteLine("**********************");


            //5.增加数组的元素
            //数组声明初始化后 不能在原有的基础上进行添加或删除
            //增加行
            int[,] array2 = new int[3, 3];
            for (int i = 0; i < array.GetLength(0); i++)        //i行
            {
                for (int j = 0; j < array.GetLength(1); j++)    //j列
                {
                    array2[i,j] = array[i,j];
                }
            }
            array = array2;
            array[2, 0] = 7;
            array[2, 1] = 8;
            array[2, 2] = 9;
            for (int i = 0; i < array.GetLength(0); i++)        //i行
            {
                for (int j = 0; j < array.GetLength(1); j++)    //j列
                {
                    Console.WriteLine(array[i, j]);
                }
            }


            //6.删除数组的元素
            //删除列
            int[,] array3 = new int[3, 2];
            for (int i = 0; i < array.GetLength(0); i++)        //i行
            {
                for (int j = 0; j < array3.GetLength(1); j++)    //j列
                {
                    array3[i, j] = array[i, j];
                }
            }
            array = array3;
            for (int i = 0; i < array.GetLength(0); i++)        //i行
            {
                for (int j = 0; j < array.GetLength(1); j++)    //j列
                {
                    Console.WriteLine(array[i, j]);
                }
            }


            //7.查找数组中的元素
            //通过遍历的方式在数组中查找一个元素是否等于某个值
            int a = 4;
            for(int i = 0;i < array.GetLength(0); i++)
            {
                for(int j = 0;j < array.GetLength(1); j++)
                {
                    if(a == array[i,j])
                    {
                        Console.WriteLine("该元素在{0}行{1}列",i,j);
                    }
                }
            }


            #endregion


            //总结：
            //1.概念：同一变量类型的行列数据集合
            //2.一定要掌握的内容：申明、遍历、增删查改
            //3.所有的变量类型都可以申明为二维数组（枚举，14种常见变量...）
            //4.游戏中一般用来存储矩阵，控制台小游戏中可以用二维数组来表示地图格子


        }
    }
}
