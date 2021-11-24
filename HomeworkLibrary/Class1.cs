using System;

namespace HomeworkLibrary
{
    public class Helper
    {
        public static (double, double) CalculateDivision(double A, double B)
        {
            if(B == 0)
            {
                throw new DivideByZeroException("B is 0");
            }
            double result = A / B;
            double modulu = A % B;

            return (result, modulu);
        }

        public static string Equation(double A, double B, double C)
        {
            double determinanta = B * B - 4 * A * C;
            if(A == 0)
            {
                throw new DivideByZeroException("A is 0");
            }
            if (determinanta < 0)
            {
                return "No intersection";
            }
            else if (determinanta == 0)
            {
                double result = (-1) * B / (2 * A);

                return result.ToString();
            }
            else
            {
                double result1 = ((-1) * B + Math.Sqrt(determinanta)) / (2 * A);
                double result2 = ((-1) * B - Math.Sqrt(determinanta)) / (2 * A);
                return result1.ToString() + "," + result2.ToString();
            }
        }

        public static int AtoPowerB(int A, int B)
        {
            if(B < 0)
            {
                throw new ArgumentException("B cannot be negative");
            }
            int res = 1;
            for (int i = 1; i < B; i++)
            {
                res = res * A;
                if(res*A > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("res * A is out of range");
                }
            }
            return res;
        }

        public static int FindMinimum(int[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentException("array is empty");
            }
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        public static int FindMaximum(int[,] arr)
        {
            if(arr == null)
            {
                throw new ArgumentException("array is empty");
            }
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }
    }
}
