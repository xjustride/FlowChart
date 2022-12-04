using System;

namespace FlowChartv1
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());


            for (int i = 0; x > 0 && y > 0; i++)
            {
                x = x - 1;
                y = y - 1;
                Console.Write("C");
            }
            if (x > 0)
            {
                if (y >= 0 || y < 0)
                {
                    Console.Write("D");
                    if (z > 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("G");
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.Write("E");
                Console.Write("G");

                Console.WriteLine();
            }

        }
    }
}


/*
using System;

namespace FlowChartv1
{
    class Program
    {
        static void Main()
        {
            string[] dane = Console.ReadLine().Split(' ');
            int x = int.Parse(dane[0]);
            int y = int.Parse(dane[1]);
            int z = int.Parse(dane[2]);

        start:
            if (x > 0)
            {
                if (y > 0)
                {
                    x = x - 1;
                    y = y - 1;
                    Console.Write("C");
                    goto start;
                }
                else
                {
                    Console.Write("D");
                }
                if (z > 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("G");
                }

            }
            else
            {
                Console.Write("E");
                Console.Write("G");
                Console.WriteLine();
            }


        }
    }
}
*/
/*
using System;

namespace FlowChartv1
{
    class Program
    {
        static void Main()
        {
            string[] dane = Console.ReadLine().Split(' ');
            int x = int.Parse(dane[0]);
            int y = int.Parse(dane[1]);
            int z = int.Parse(dane[2]);

            while (x > 0 && y > 0)
            {
                x = x - 1;
                y = y - 1;
                Console.Write("C");
            }
            if (x > 0)
            {
                if (y >= 0 || y < 0)
                {
                    Console.Write("D");
                    if (z > 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("G");
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.Write("E");
                Console.Write("G");

                Console.WriteLine();
            }

        }
    }
}
*/