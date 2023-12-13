using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Дано:
N, M Размерность 
n1 n2 - диапазон случайных чисел
числа должны чередоваться Even not_even

Найти:
сумма чётных элементов массива с номерами от K до l в столбце C
Нумерация с нуля
*/
namespace Tyuiu.PetrovNE.Sprint6.TaskReview.V4.Lib
{

    public class DataService
    {
        public int[,] GetMatrix(int N, int M, int n1, int n2)
        {
            if (N > 1 && M > 1 && n2 > n1)
            {
                int[,] array = new int[N, M];
                Random rand = new Random();

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (j % 2 == 0)
                        {
                            do
                            {
                                array[i, j] = rand.Next(n1, n2);
                            }
                            while (array[i, j] % 2 == 0);
                        }
                        else
                        {
                            do
                            {
                                array[i, j] = rand.Next(n1, n2); ;
                            }
                            while (array[i, j] % 2 != 0);
                        }
                    }
                }

                return array;
            }
            else { throw new ArgumentException("Ошибка, введены неверные данные"); }
            
        }
        public int Result(int[,] array, int c, int k, int l) 
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int Summ_Of_Even_Numbers = 0;

            for (int i = 0; i < rows; i++ )
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == c)
                    {
                        if (i >= k && i <= l && array[i, j] % 2 == 0)
                        {
                            Summ_Of_Even_Numbers += array[i, j];
                        }
                    }
                }
            }
            return Summ_Of_Even_Numbers;
        }
    }

}
