namespace MLR
{
    public interface ISorting
    {
        /// <summary>
        /// Sortowanie algorytmem HEAPSORT.
        /// </summary>
        /// <param name="array">Tablica danych do posortowania</param>
        /// <returns>Posortowana tablica danych</returns>
        double[] HeapSort(double[] array);

        /// <summary>
        /// Sortowanie algorytmem SHELLSORT.
        /// </summary>
        /// <param name="array">Tablica danych do posortowania</param>
        /// <returns>Posortowana tablica danych</returns>
        double[] ShellSort(double[] array);

        /// <summary>
        /// Sortowanie algorytmem BUBBLESORT.
        /// </summary>
        /// <param name="array">Tablica danych do posortowania</param>
        /// <returns>Posortowana tablica danych</returns>
        double[] BubbleSort(double[] array);
    }
}