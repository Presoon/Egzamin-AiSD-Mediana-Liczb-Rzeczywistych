namespace MLR
{
    public class Mediana
    {
        /// <summary>
        ///     Metoda obliczająca medianę z posortowanej bazy danych.
        /// </summary>
        /// <param name="array">Posortowana baza danych typu double.</param>
        /// <returns>Wartość mediany dla zbioru, typu double</returns>
        public double GetMedian(double[] array)
        {
            double median;
            
            //parzysta liczba elementów
            if (array.Length % 2 == 0)
            {
                int leftMiddle = array.Length / 2 -1;
                int rightMiddle = array.Length / 2 ;

                median = (array[rightMiddle] + array[leftMiddle]) / 2;
            }
            //nieparzysta liczba elementów
            else
            {
                int middle = (array.Length-1) / 2;
                median = array[middle];
            }

            return median;
        }
    }
}