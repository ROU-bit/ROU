namespace Lesson4_交错数组
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点一 基本概念
            //交错数组是数组的数组，每个维度的数量可以不同

            //注意：二维数组的每行的列数相同，交错数组每行的列数可能不同

            #endregion


            #region 知识点二 交错数组的申明
            //1.
            //变量类型[][] 交错数组名;
            int[][] arr1;

            //2.
            //变量类型[][] 交错数组名 = new 变量类型[行数][];          //列数可能不同，所以不能定义列数
            int[][] arr2 = new int[2][];

            //3.
            //变量类型[][] 交错数组名 = new 变量类型[行数][]{一维数组1,一维数组2......};
            int[][] arr3 = new int[2][] { new int[] { 1, 2, 3 },            //列可不同
                                          new int[] { 4, 4, 8, 6} };

            //4.
            //变量类型[][] 交错数组名 = new 变量类型[][]{一维数组1,一维数组2......};
            int[][] arr4 = new int[2][] { new int[] { 1, 2, 3 },            //列可不同
                                          new int[] { 4, 4, 8, 6} };

            //5.
            //变量类型[][] 交错数组名 = {一维数组1,一维数组2......};
            int[][] arr5 = { new int[] { 1, 2, 3 },            //列可不同
                             new int[] { 4, 4, 8, 6} };

            #endregion


            #region 知识点三 交错数组的使用

            int[][] array = {new int[] { 1,2,3},
                             new int[] { 4,5} };

            //1.数组的长度
            //行
            Console.WriteLine(array.GetLength(0));      //2
            //得到某一行的列数
            Console.WriteLine(array[0].Length);         //3


            //2.获取交错数组中的元素
            Console.WriteLine(array[0][1]);             //2


            //3.修改交错数组中的元素
            array[1][1] = 99;
            Console.WriteLine(array[1][1]);             //99


            //4.遍历交错数组
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " " );
                }
                Console.WriteLine();
            }


            //5.增加交错数组的元素
            int[][] array2 = new int[3][];
            for (int i = 0;i < array.GetLength(0); i++)
            {
                array2[i] = new int[array[i].Length]; // 初始化子数组
                for (int j = 0;j < array[i].Length; j++)
                {
                    array2[i][j] = array[i][j];
                }
            }
            array = array2;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] != null) // 确保当前子数组已被初始化
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write(array[i][j] + " ");
                    }
                    Console.WriteLine(); // 每行结束后换行
                }
            }



            //6.删除交错数组的元素


            //7.查找交错数组中的元素

            #endregion


            //总结
            //1.概念：交错数组可以存储同一类型的m行不确定列的数据
            //2.一定要掌握的内容：申明、遍历、增删查改
            //3.所有的变量类型都可以申明为交错数组
            //4.一般交错数组很少使用，了解即可
        }
    }
}
