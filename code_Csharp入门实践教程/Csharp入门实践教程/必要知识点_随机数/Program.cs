namespace 必要知识点_随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 知识点一 产生随机数对象
            //固定写法
            // Random 随机数变量名 = new Random();
            //Random可以理解为系统定义好的一个自定义变量类型
            Random r = new Random();
            #endregion


            #region 知识点二 生成随机数
            int i = r.Next();           //生成一个非负数的随机数
            Console.WriteLine(i);

            i = r.Next(100);            //生成一个0~99的随机数
            Console.WriteLine(i);
                                        //左包含，右不包含

            i = r.Next(5,100);          //生成一个5~99的随机数
            Console.WriteLine(i);

            #endregion






        }
    }
}
