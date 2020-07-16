using System;

namespace SherlockAndTheBeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            double decent = 0;
            int five = 0;
            int temp = 0;

            if (n % 3 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (decent == 0)
                    {
                        decent = 5;
                    }
                    else
                    {
                        decent *= 10;
                        decent += 5;
                    }
                }
            }
            else if (n % 5 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (decent == 0)
                    {
                        decent = 3;
                    }
                    else
                    {
                        decent *= 10;
                        decent += 3;
                    }
                }
            }
            else
            {
                temp = n;
                while (temp > 5)
                {
                    temp -= 5;
                    if (temp % 3 == 0)
                    {
                        five = temp;
                        break;
                    }
                }
                if (five!=0)
                {
                    for (int i = 0; i < five; i++ )
                    {
                        if (decent == 0)
                        {
                            decent = 5;
                        }
                        else
                        {
                            decent *= 10;
                            decent += 5;
                        }
                    }
                    for (int i = five; i < n; i++)
                    {
                        {
                            decent *= 10;
                            decent += 3;
                        }
                    }
                }
                else
                {
                    decent = -1;
                }

            }

            Console.WriteLine(decent);
        }
    }
}
