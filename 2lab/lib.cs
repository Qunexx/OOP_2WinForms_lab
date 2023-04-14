using System;
using System.Windows.Forms;

namespace lib
{
    public static class Mylib
    {
        public static double linfunc(double a, double b, double c) //Считает линейную функцию
        {
            double res = ((2 * b * b / 6) + 2 * (c * c) - (a * a));
            return res;
        }

        public static double razn_minmax(double x, double y, double z) //Находит минимальное и максимальное значение
        {
            double min, max;
            if ((x * x) > y) min = y;
            else { min = x * x; }
            if (y > z) max = y;
            else { max = z; }
            double p = (min - max) / 2;
            return p;
        }


        public static double MathF1(double x)  // Считает синус от функции
        {
            double f = Math.Sin(x);
            return f;
        }

        public static double MathF2(double x)
        {
            double S = 1;
            int N = 16;

            for (int n = 1; n <= N; n++)
            {
                double f = Mylib.Fact(n);
                S = S + Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / f;
            }
            return S;
        }

        public static double[] MathF11x(double xn, double xk)
        {
            double x, h, f;
            double[] mas;
            
            mas = new double[10];
            

            h = (xk - xn) / 10;
            for (int i = 0; i <= 9; i++)
            {
                x = xn + i * h;
                f = Math.Sin(x);
                mas[i] = x;
                
            }
            return mas;
        }

        public static double[] MathF11f(double xn, double xk)
        {
            double x, h, f;
            
            double[] mass;
            
            mass = new double[10];

            h = (xk - xn) / 10;
            for (int i = 0; i <= 9; i++)
            {
                x = xn + i * h;
                f = Math.Sin(x);
                
                mass[i] = f;
            }
            return mass;
        }



        public static double Fact(int n)
        {
            double f = 1;
            for (int i = 1; i <= 2 * n + 1; i++) //Вычисление факториала (2*n+1)!
            { f = f * i; }
            return f;
        }




        public static void MassivInput(int m, int[] mas)
        {
            Console.WriteLine("------------------------");

            for (int i = 0; i < m; i++)
            {
                Console.Write("Введите элемент массива mas[{0}] = ", i);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("------------------------");
        }

        public static void MassivOutput(int m, int[] mas)
        {
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Элемент массива mas[{0}] = {1}", i, mas[i]);
            }
            Console.WriteLine("------------------------");
        }

        public static string MassivCheck(int m, int[] mas)
        {
            int k = 0;
            int j = 0;
            int[] mass;
            mass = new int[m];
            string l = "Таких элементов нет";
            for (int i = 0; i < m - 1; i++)
                if (mas[i] > mas[i + 1]) 
                {
                    mass[j] =i;
                    j++;
                }
            
                if (j != 0)
                {
                    l = "";
                for (int i = 0; i < j; i++)
                    l += mass[i].ToString() + " ";
                }

                    return l;
            }

        public static int kolvo(int m, int[] mas)
        {
            int k = 0;
            for (int i = 0; i < m - 1; i++)
            {
                if (mas[i] > mas[i + 1]) k++;
            }

            return k;
        }











    }













}


