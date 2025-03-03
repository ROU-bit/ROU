namespace Homework5_ref和out
{
    internal class Program
    {
        /*
         让用户输入用户名和密码，返回给用户一个bool类型的登陆结果，并且还要单独的返回给用户一个登陆信息。
         如果用户名错误，除了返回登陆结果之外，登陆信息为“用户名错误”
         如果密码错误，除了返回登陆结果之外，登陆信息为“密码错误”
         */
        static bool LoginCheck(string admin, string psd, ref string info)
        {
            if (admin == "ROU")
            {
                if(psd == "666")
                {
                    info = "输入正确";
                }
                else
                {
                    info = "密码错误";
                    return false;
                }
            }
            else
            {
                if (psd != "666")
                {
                    info = "用户名和密码都错误";
                    return false;
                }
                else
                {
                    info = "用户名错误";
                    return false;
                }
            }
            return true;
        }


        static void Main(string[] args)
        {
            //1.简要描述ref和out的区别
            //ref必须初始化变量 在函数内部可以不更改
            //out可以不初始化变量 在函数内部必须更改

            Console.WriteLine("请输入你的用户名");
            string admin = Console.ReadLine();
            Console.WriteLine("请输入你的密码");
            string psd = Console.ReadLine();

            string info = "";

            while(!LoginCheck(admin, psd, ref info))
            {
                Console.WriteLine(info);
                Console.WriteLine("请输入你的用户名");
                admin = Console.ReadLine();
                Console.WriteLine("请输入你的密码");
                psd = Console.ReadLine();
            }
            Console.WriteLine(info);
        }
    }
}
