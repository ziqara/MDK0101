using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace вторая_л
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Film> films = new List<Film>()
            {
                new Film("Побег из шоушенка", Genre.Драма, 150),
                new Film("Суперперцы", Genre.Комедия, 300),
                new Film("Прочь", Genre.Ужасы, 50),
                new Film("Начало", Genre.Фантастика, 200),
                new Film("Индиана Джонс", Genre.Приключения, 400),
                new Film("Побег из шоушенка", Genre.Боевик, 230)
            };

            Dictionary<Genre, (double totalSales, double totalRevenue)> salesRepost = new Dictionary<Genre, (double totalSales, double totalRevenue)>();
            foreach (var genre in Enum.GetValues(typeof(Genre)))
            {
                salesRepost[(Genre)genre] = (0, 0);
            }


            int[,] fixedSales = new int[,]
          {
                { 3, 2, 1 },
                { 2, 3, 2 },
                { 1, 1, 0 },
                { 0, 2, 1 },
                { 1, 1, 1 }
          };

            for (int day = 0; day < 3; day++)
            {
                foreach (var filmss in films)
                {
                    int genreIndex = (int)filmss.Genre;
                    int salesCount = fixedSales[genreIndex, day];

                    var currentSalesData = salesRepost[filmss.Genre];

                    currentSalesData.totalSales += salesCount;
                    currentSalesData.totalRevenue += salesCount * filmss.Price;

                    salesRepost[filmss.Genre] = currentSalesData;
                }
            }

            Console.WriteLine("Отчёт по продажам фильмов по жанрам:");
            foreach (var report in salesRepost)
            {
                Console.WriteLine($"Жанр: {report.Key}");
                Console.WriteLine($"Общее количество продаж: {report.Value.totalSales}");
                Console.WriteLine($"Общая выручка: {report.Value.totalRevenue}");
                Console.WriteLine();
            }
        }
    }
}
