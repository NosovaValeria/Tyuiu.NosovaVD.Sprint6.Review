using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.NosovaVD.Sprint6.TaskReview.V8.Lib
{
    public class DataService
    {
        public int[,] GetMatrix(int n, int m, int n1, int n2)
        {
            Random rnd = new Random();
            int[,] array = new int[n, m];
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j % 2 == 0)
                    {
                        a = rnd.Next(n1, n2);
                        if (a > 0)
                        {
                            array[i, j] = a;
                        }
                        else
                        {
                            array[i, j] = -1 * a;
                        }
                    }
                    else
                    {
                        a = rnd.Next(n1, n2);
                        if (a > 0)
                        {
                            array[i, j] = -1 * a;
                        }
                        else
                        {
                            array[i, j] = a;
                        }
                    }
                }
            }
            return array;
        }
        public int resultGetMatrix(int[,] array, int c, int k, int l)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int summ = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((i < k && j == c))
                    {
                        summ += array[i, j];
                    }
                    else if ((i > l && j == c))
                    {
                        summ += array[i, j];
                    }
                    else if(j % 2 == 0 && j != c)
                    {
                        summ += array[i, j];
                    }
                }
            }
            return summ;
        }
    } 
}
