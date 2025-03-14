namespace Homework23_面向对象相关_string
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1
            //请写出string中提供的截取和替换对应的函数名
            //截取
            string str1 = "ROU正在学习Csharp";
            str1 = str1.Substring(4);
            Console.WriteLine(str1);          //在学习Csharp
            string str11 = "ROU正在学习Csharp";
            str11 = str11.Substring(2, 4);
            Console.WriteLine(str11);         //U正在学
            //替换
            string str111 = "ROU正在学习Csharp";
            str111 = str111.Replace("ROU", "MAO");
            Console.WriteLine(str111);        //MAO正在学习Csharp
            #endregion


            #region 2
            //请将字符串1 | 2 | 3 | 4 | 5 | 6 | 7 变为 2 | 3 | 4 | 5 | 6 | 7 | 8
            //并输出(使用字符串切割的方法)
            string str = "1 | 2 | 3 | 4 | 5 | 6 | 7 ";
            string[] strs = str.Split('|');
            str = "";
            for(int i = 0; i < strs.Length; i++)
            {
                str += int.Parse(strs[i]) + 1;
                if (i != strs.Length - 1)
                {
                    str += "|";
                }
            }
            Console.WriteLine(str);
            #endregion


            #region 3
            //String和string、Int32和int、Int16和short、Int64和long他们的区别是什么?
            //他们没有区别，后者是前者的别名
            #endregion


            #region 4
            //string str = null;            //在栈中分配地址，但堆中没有东西，即没有分配堆空间
            //str = "123";                  //在堆中添加“123”，即分配了一个堆空间
            //string str2 = str,            //在栈中分配地址，指向str的堆空间，即没有分配新的堆空间
            //str2 = "321";                 //对于特殊的引用类型string来说，只要改了后面的输入内容，就是分配了一个新的堆空间
                                            //即此时分配了一个新的堆空间，内容为“321”
            //str2 += "123";                //同上，内容为“321123”，str2原先指向的堆内存“321”将会被系统回收
            //请问，上面这段代码，分配了多少个新的堆空间
            //3个
            #endregion


            #region 5
            //编写一个函数，将输入的字符串反转。不要使用中间商，你必须原地修改输入数组。交换过程中不使用额外空间
            //比如：输入{‘h’，‘e’，‘l’，‘l’，‘o’}    输出  {‘o’，‘l’，‘l’，‘e’，‘h’}
            Console.WriteLine("请输入字符串,用逗号分隔");
            string strr = Console.ReadLine();
            //字符串本质上就是字符数组，可以直接遍历
            char[] chars = strr.ToCharArray();
            for (int i = 0; i < chars.Length / 2; i++)
            {
                //交换
                chars[i] = (char)(chars[i] + chars[chars.Length - 1 - i]);
                chars[chars.Length - 1 - i] = (char)(chars[i] - chars[chars.Length - 1 - i]);
                chars[i] = (char)(chars[i] - chars[chars.Length - 1 - i]);
            }
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.Write(chars[i]);
            //}

            //把字符数组转为字符串
            strr = new string(chars);
            Console.WriteLine(strr);
            #endregion
        }
    }
}
