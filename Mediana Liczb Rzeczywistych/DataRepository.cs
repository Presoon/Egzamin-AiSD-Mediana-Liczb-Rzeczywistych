using System;
using System.IO;

namespace MLR
{
    public class DataRepository
    {
        /// <summary>
        ///     Database jako główny element bazy danych, przechowujący wartości typu double.
        /// </summary>
        private double[] Database { get; set; }
        public readonly ISorting Srt;

        /// <summary>
        ///     Konstruktor bazy danych wykorzystujący domyślną ścieżkę do pliku importu.
        /// </summary>
        /// <param name="srt">Inicjalizacja klasy algorytmów sortujących</param>
        public DataRepository(ISorting srt)
        {
            Srt = srt;
            ReadDatabase();
        }

        /// <summary>
        ///     Konstruktor bazy danych wykorzystujący podaną przez użytkownika ścieżkę do pliku importu.
        /// </summary>
        /// <param name="srt">Inicjalizacja klasy algorytmów sortujących</param>
        public DataRepository(ISorting srt, string path)
        {
            Srt = srt;
            ReadDatabase(path);
        }

        /// <summary>
        ///     Metoda pobierająca bazę danych.
        /// </summary>
        /// <returns>Baza danych</returns>
        public double[] GetDatabase()
        {
            return Database;
        }

        /// <summary>
        ///     Metoda ustawiająca bazę danych.
        /// </summary>
        /// <param name="array">Tablica danych typu double</param>
        public void SetDatabase(double[] array)
        {
            Database = array;
        }

        /// <summary>
        ///     Metoda wypisująca bazę danych.
        /// </summary>
        public void PrintDatabase()
        {
            for (int i = 0; i < Database.Length; i++)
            {
                Console.WriteLine($"[#] {i,5} -> {Database[i]}");
            }
        }

        /// <summary>
        ///     Metoda wczytująca bazę danych z domyślnej ścieżki.
        /// </summary>
        private void ReadDatabase()
        {
            const string path = @"ExDatabases/database-10000.txt";
            FileRead(path);
            Console.WriteLine("[#] Wczytywanie bazy zakończone");
        }

        /// <summary>
        ///     Metoda wczytujaca bazę danych z pliku podanego przez użytkownika.
        /// </summary>
        /// <param name="path">Ścieżka do pliku typu string</param>
        private void ReadDatabase(string path)
        {
            FileRead(path);
        }

        /// <summary>
        ///     Funkcja wczytująca dane bazy z pliku.
        ///     Oczekwiane wartości: double, każda liczba w nowej linii.
        /// </summary>
        /// <param name="path">Ścieżka do pliku z danymi.</param>
        private void FileRead(string path)
        {
            string[] allLines;
            try
            {
                allLines = File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Błąd wczytywania z pliku: " + e);
                throw;
            }

            var database = new double[allLines.Length];

            //dopuszczamy wersje double z kropką oraz z przecinkiem
            for (int i = 0; i < allLines.Length; i++)
            {
                try
                {
                    database[i] = Convert.ToDouble(allLines[i].Replace('.', ','));
                   
                }
                catch (Exception e)
                {
                    
                    try
                    {
                        database[i] = Convert.ToDouble(allLines[i]);
                        Console.WriteLine("Coś sie dzieje");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Mess: " + ex);
                        Console.WriteLine(e);
                        return;
                    }
                }
            }
            
            //zapis zmian
            Database = database;
        }

    }
}