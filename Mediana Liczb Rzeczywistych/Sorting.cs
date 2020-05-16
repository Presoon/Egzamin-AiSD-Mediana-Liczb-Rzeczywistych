using System;

namespace MLR
{
    public class Sorting : ISorting
    {

        public double[] HeapSort(double[] array)
        {
            int n = array.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                Heap(array, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                double temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                Heap(array, i, 0);
            }

            return array;
        }

        private static void Heap(double[] array, int n, int i)
        {
            while (true)
            {
                int largest = i;
                int left = 2 * i + 1;
                int right = 2 * i + 2;
                if (left < n && array[left] > array[largest]) largest = left;
                if (right < n && array[right] > array[largest]) largest = right;
                if (largest != i)
                {
                    double swap = array[i];
                    array[i] = array[largest];
                    array[largest] = swap;
                    i = largest;
                    continue;
                }
                break;
            }
        }

        public double[] ShellSort(double[] array)
        {
            int n = array.Length;
            var pos = 3;

            while (pos > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    var j = i;
                    var temp = array[i];
                    while ((j >= pos) && (array[j - pos] > temp))
                    {
                        array[j] = array[j - pos];
                        j -= pos;
                    }
                    array[j] = temp;
                }
                if (pos / 2 != 0)
                    pos /= 2;
                else if (pos == 1)
                    pos = 0;
                else
                    pos = 1;
            }

            return array;
        }

        public double[] BubbleSort(double[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] <= array[j + 1]) continue;
                    double temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }

            return array;
        }

    }
}