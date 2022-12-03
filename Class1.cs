using System;
using System.Text;
using System.Threading;
namespace baseLab13
{
    class Program
    {
        static bool ArrayContains(int[] numbers, int number)
        {
            foreach (var num in numbers) if (number == num) return true;
            return false;
        }
        static int[] UniqueRandomArray(int min, int max, int length, Random? random = null)
        {
            if (min >= max) throw new ArgumentException("Не верно задан диапазон - min >= max");
            if ((max - min) <= length) throw new ArgumentException("Диапазон не позволяет");

            random = random ?? new Random(DateTime.Now.Millisecond);
            var result = new int[length];
            var zeroFirst = true;
            for (var i = 0; i < length; i++)
            {
                var res = 0;
                do
                {
                    res = random.Next(min, max);
                    if (res == 0)
                    {
                        if (zeroFirst)
                        {
                            zeroFirst = false;
                            break;
                        }
                        continue;
                    }
                } while (ArrayContains(result, res));
                result[i] = res;
            }
            return result;
        }

        static string ArrayToString(int[] numbers, bool show = true)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in numbers) sb.Append(item).Append(' ');
            var result = sb.ToString().TrimEnd(' ');
            if (show) Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            var A = UniqueRandomArray(-20, 100, 20);
            ArrayToString(A);
            int indexmax = 0;
            int indexmin = 0;
            int max = A[0];
            int min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    indexmax = i;
                }
                if (A[i] < min)
                {
                    min = A[i];
                    indexmin = i;
                }

            }

            int s = A[indexmin];
            A[indexmin] = A[indexmax];
            A[indexmax] = s;
            ArrayToString(A);
        }
    }
}