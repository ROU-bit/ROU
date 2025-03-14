using System;
using System.Text;

namespace Lesson24_面向对象相关_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringBuilder");

            #region 知识回顾
            //string是特殊的引用
            //每次重新赋值或者拼接时会分配新的内存空间
            //如果一个字符串经常改变会非常浪费空间
            #endregion

            #region 知识点 StringBuilder
            //C#提供的一个用于处理字符串的公共类 
            //主要解决的问题是：
            //修改字符串而不创建新的对象,需要频繁修改和拼接的字符串可以使用它，可以提升性能
            //使用前 需要引用命名空间
            //缺点：灵活性不如string
            //优点：较string产生的内存垃圾少

            #region 初始化 直接指明内容
            //StringBuilder str = new StringBuilder("123123123",100);   //后面的100可以扩容capacity
            StringBuilder str = new StringBuilder("123123123");
            Console.WriteLine(str);         //123123123
            #endregion

            #region 容量
            //StringBuilder存在一个容量的问题，每次往里面增加时 会自动扩容
            //获得容量
            Console.WriteLine(str.Capacity);
            //当前容器里的字符长度
            Console.WriteLine(str.Length);
            #endregion

            #region 增删查改替换
            //增
            //调用StringBuilder中的Append()方法
            str.Append("4444");                         
            Console.WriteLine(str);                     //1231231234444
            Console.WriteLine(str.Length);              //13
            Console.WriteLine(str.Capacity);            //16

            str.AppendFormat("{0}{1}", 100, 999);       
            Console.WriteLine(str);                     //1231231234444100999
            Console.WriteLine(str.Length);              //19
            Console.WriteLine(str.Capacity);            //32        //19超过原先16的capacity 扩容*2
            //插入
            str.Insert(0, "唐老狮");                     //从第一个位置开始插入字符
            Console.WriteLine(str);                     //唐老狮1231231234444100999
            //删
            str.Remove(0, 10);                          //从第一个位置开始删除十个字符
            Console.WriteLine(str);                     //234444100999
            //清空
            //清除str中的所有字符
            //str.Clear();
            //Console.WriteLine(str);                   //
            //查
            Console.WriteLine(str[1]);                  //3
            //改
            str[0] = 'A';                               //将第一个字符改为A
            Console.WriteLine(str);                     //A34444100999
            //替换
            str.Replace("1", "唐");                     //将字符“1”改为“唐”
            Console.WriteLine(str);                     //A34444唐00999

            //重新赋值 StringBuilder
            str.Clear();
            str.Append("123123");
            Console.WriteLine(str);                     //123123
            //判断StringBuilder是否和某一个字符串相等
            if ( str.Equals("123123") )
            {
                Console.WriteLine("相等");              //相等
            }
            if ( str.Equals("12123") )
            {
                Console.WriteLine("相等");              //
            }
            #endregion

            #endregion
        }
    }
}
