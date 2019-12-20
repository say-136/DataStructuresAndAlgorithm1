using System;
using System.Linq;

namespace Main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int a = 0;


            string[,] str1 = { { "人工智能", "2", "也将", "产生效果" },


                { "智能化","3","超智能","影响"}
            };

            foreach (string b in str1)
            {
                if (b == str)
                {
                   Console.WriteLine("在" + a);
                }
                a++;



                continue;
            }

        }
    }
}
