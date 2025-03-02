namespace Homework3_二维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            #region 1
            Console.WriteLine("第一题————————————————————————");
            //将1到10000赋值给一个二维数组（100行100列）
            int[,] arr1 = new int[100, 100];
            int con = 1;
            for (int i = 0; i < arr1.GetLength(0); i++)
            { 
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i,j] = con++;
                }
            }
            for (int i = 0;i < 10; i++)
            {
                for(int j = 0;j < 10; j++)
                {
                    Console.Write(arr1[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion


            #region 2
            Console.WriteLine("第二题————————————————————————");
            //将二维数组（4行4列）的右上半部分置零（元素随机1~100）
            int[,]arr2 = new int[4,4];
            for (int i = 0; i < arr2.GetLength(0) ; i++)
            {
                for(int j = 0; j < arr2.GetLength(1); j++)
                {
                    if( i < 2 && j > 1 )
                    {
                        arr2[i, j] = 0;

                    }
                    else
                    {
                        arr2[i, j] = r.Next(1, 101);
                    }
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine() ;
            }
            Console.WriteLine() ;
            #endregion


            #region 3
            Console.WriteLine("第三题————————————————————————");
            //求二维数组（3行3列）的对角线元素的和（元素随机1~10）
            int[,] arr3 = new int[3, 3];
            int sum3 = 0;
            for(int i = 0;i < arr3.GetLength(0) ;i++)
            {
                for(int j = 0; j < arr3.GetLength(1); j++)
                {
                    arr3[i, j] = r.Next(1, 11);

                    if(i == j || i + j == 2)
                    {
                        sum3 += arr3[i,j];
                    }
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("二维数组（3行3列）的对角线元素的和是{0}", sum3);
            Console.WriteLine();
            #endregion


            #region 4
            Console.WriteLine("第四题————————————————————————");
            //求二维数组（5行5列）中最大元素值及其行列号（元素随机1~500）
            int[,]arr4 = new int[5, 5];
            int max4 = 0;
            for(int i = 0; i < arr4.GetLength(0) ; i++ )
            {
                for(int j = 0; j < arr4.GetLength(1) ; j++ )
                {
                    arr4[i, j] = r.Next(1, 501);
                    if( i == 0 && j == 0 )
                    {
                        max4 = arr4[i, j];
                    }
                    if ( max4 < arr4[i,j] )
                    {
                        max4 = arr4[i,j];
                    }
                    Console.Write(arr4[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr4.GetLength(0); i++)
            {
                for (int j = 0; j < arr4.GetLength(1); j++)
                {
                    if (arr4[i, j] == max4)
                    {
                        Console.WriteLine("二维数组（5行5列）中最大元素值为{0}，在{1}行{2}列", max4, i + 1, j + 1);
                    }
                }
            }
            Console.WriteLine();
            #endregion


            #region 5
            Console.WriteLine("第五题————————————————————————");
            //给一个M*N的二维数组，数组元素的值为0或者1，要求转换数组，将含有1的行和列全部置1
            //需要记住的行列太多，就通过打标识的方法来记录
            int m = r.Next(1,10);
            int n = r.Next(1,10);
            bool[] cc = new bool[m];     //行一维数组
            bool[] rr = new bool[n];     //列一维数组
            int[,] arr5 = new int[m,n];
            for(int i = 0;i < arr5.GetLength(0) ; i++)
            {
                for(int j = 0; j < arr5.GetLength(1) ; j++)
                {
                    arr5[i,j] = r.Next(0,2);
                    if(arr5[i, j] == 1)
                    {
                        //记录了当前行列是否要变1的标识
                        //要变1就置true
                        cc[i] = true;
                        rr[j] = true;
                    }
                    Console.Write(arr5[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    //满足行和列的标识为true时执行下列代码
                    if (cc[i] || rr[j])
                    {
                        arr5[i, j] = 1;
                    }
                    Console.Write(arr5[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion


        }
    }
}
