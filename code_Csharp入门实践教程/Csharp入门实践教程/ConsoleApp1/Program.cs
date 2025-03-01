namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int ID = 1;
            int i = 1;
            while (true) 
            {
                switch (ID)
                {
                    case 1:
                        Console.WriteLine("jsadhj");
                        ID = 2;
                        break;

                    case 2:
                        while (i < 4)
                        {
                            Console.WriteLine("dsadsad");
                            i++;
                            if (i == 3)
                            {
                                Console.WriteLine("dfdsfssd");
                                break;
                            }
                        }

                        break;

                    case 3:

                        break;

                }
            }

        }
    }
}
