namespace Lesson12_位运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //位运算符 主要用数值类型进行计算的
            //将数值转换为2进制 再进行位运算

            #region 知识点一 位与 &
            //规则 连接两个数值进行位计算 将数值转为2进制
            //对位运算 有0则0
            int i = 1;                  //001
            int j = 5;                  //101
            int k = i & j;              //001
            Console.WriteLine(k);       //1

            int i1 = 19;                //10011
            int j1 = 7;                 //  111
            int k1 = i1 & j1;           //00011
            Console.WriteLine(k1);      //3

            //多个数值进行位运算（没有括号时），则从左到右依次计算
            int k2 = i1 & j1 & i & j;
            Console.WriteLine(k2);      //1
            #endregion


            #region 知识点二 位或 |
            //规则 连接两个数值进行位计算 将数值转为2进制
            //对位运算 有一则一


            #endregion


            #region 知识点三 异或 ^
            //规则 连接两个数值进行位计算 将数值转为2进制
            //对位运算 相同为0 不同为1


            #endregion


            #region 知识点四 位取反~
            //规则 写在数值前面 将数值转为2进制
            //对位运算 0变1 1变0
            int n = 5;
            //0000 0000 0000 0000 0000 0000 0000 0101
            //1111 1111 1111 1111 1111 1111 1111 1010
            //反码补码 首位表示符号 0为正 1为负
            int c = ~n;
            Console.WriteLine(c);
            #endregion


            #region 知识点五 左移<< 和 右移>>
            //规则 让一个数的2进制数进行左移和右移
            //左移几位 右侧加几个0
            i = 5;                  //101
            j = i << 5;             //10100000      即160
            Console.WriteLine(j);

            //右移几位 右侧去掉几个数
            j = i >> 2;             //1
            Console.WriteLine(j);

            #endregion


            #region 作业
            //1.请问35 << 4 和 66 >> 1的结果为？
            //    10011     1000010
            //答：100110000  560   ；    100001 33

            //2.请问99 ^ 33和76|85的结果为？
            //1100011 0100001 1001100 1010101
            //答：1000010 66；1011101 93

            #endregion



        }
    }
}
