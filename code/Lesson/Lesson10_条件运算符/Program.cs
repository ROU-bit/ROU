namespace Lesson10_条件运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 条件运算符
            //用于比较两个变量或常量
            //是否大于 >
            //是否小于 <
            //是否等于 ==               仅仅一个=表示赋值
            //是否不等于 !=
            //是否大于等于 >=
            //是否小于等于 <=

            //条件运算符 一定存在左右两边的内容
            //左边内容 条件运算符 右边内容

            int a = 1;
            int b = 2;

            //比较的结果返回一个bool类型的值
            //true和false 如果条件满足则返回true 不满足则返回false
            //先算右边 后赋值给左边
            //a > b;                            error
            bool result = a > b;
            Console.WriteLine(result);          //False
            result = a < b;
            Console.WriteLine(result);          //True
            //......其他均一样


            #endregion


            #region 知识点二 各种应用写法
            int i = 12;
            int j = 13;

            //*变量和变量比较
            result = i > j;
            Console.WriteLine(result);

            //*变量和数值比较
            result = i > 13;
            Console.WriteLine(result);
            result = j == 12;
            Console.WriteLine(result);

            //数值和数值比较
            result = 78 > 13;
            Console.WriteLine(result);
            result = 78 == 12;
            Console.WriteLine(result);

            //计算结果比较
            //条件运算符比算术运算符优先级低
            result = i * 4 / 2 > j - 56 % 55;

            #endregion


            #region 知识点三 不能进行范围比较

            a = 5;
            //判断是否在某两个值之间
            //result = 1 < a < 6;                 error
            //判断是否在某两个值之间，要运用逻辑运算符的知识点


            #endregion


            #region 知识点四 不同类型之间的比较

            //不同数值类型之间，可以随意进行条件运算符比较
            int z = 6;
            float x = 7.23f;
            double c = 8.34;
            short v = 134;
            //只要是数值，就能够进行条件运算符比较。
            result = z > x;
            result = c > x;
            result = v > x;
            result = z > v;


            //特殊类型string bool 只能同类型进行 == 和 !=比较 不存在大小关系
            string str = "123";
            
            bool bo = true;

            result =  str == "456";
            result = str != "123";
            result = bo == false;
            result = bo == true;

            //char能同类型进行 == 和 !=比较 ， 也可以与数值类型比较
            char ch = 'a';
            result = ch > 123;
            result = ch < 'A';

            #endregion


            #region 作业

            /*1.
            请口答下列表达式的结果
            我的年龄（18）> 你们的年龄（22）                         F
            兔子的速度（3m / s） ＜ 乌龟的速度（0.3m / s）           F
            狗的重量（50kg）< 兔子的重量（5kg）                      F
            我身上的Money（ 10元）== 你身上也有Money（10元）         T
            */


            /*2.
             求打印结果是什么？
                bool b = true;
                Console. WriteLine（b != true );        F
                Console. WriteLine(10==10);             T
                Console. WriteLine(10 > 20);            F
                Console.WriteLine(10<=20);              T
                Console. WriteLine(10<=10);             T
             */


            /*3.
                bool gameOver, startGame;
                int a = 10, b = 15;
                gameOver = a > (b - 5);                 
                startGame = gameOver = = (b > (a + 5));
                Console. WriteLine("startGame = " + startGame);
                请问打印结果是什么？
             
                    startGame =True
             */



            #endregion



        }
    }
}
