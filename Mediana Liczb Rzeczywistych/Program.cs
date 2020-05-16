using System;

namespace MLR
{
    internal static class Program
    {
        private static void Main()
        {
            //Inicjalizacja klasy obliczającej medianę
            Mediana md = new Mediana();

            //Inicjalizacja Klasy bazy danych
            DataRepository db = new DataRepository(new Sorting(), @"ExDatabases/database-10000.txt");
            //DataRepository db = new DataRepository(new Sorting(), @"ExDatabases/database-100000.txt");
            //DataRepository db = new DataRepository(new Sorting());


            //Wykorzystanie algorytmów sortujących w celu
            //przygotowania bazy pod obliczenie mediany
            db.SetDatabase(db.Srt.HeapSort(db.GetDatabase()));
            //db.SetDatabase(db.Srt.ShellSort(db.GetDatabase()));
            //db.SetDatabase(db.Srt.BubbleSort(db.GetDatabase()));


            //Wypisanie bazy danych i wypisanie mediany zbioru
            db.PrintDatabase();
            Console.WriteLine($"\n[#] Mediana zbioru to: {md.GetMedian(db.GetDatabase())}");

            Console.ReadKey();
        }
    }
}
