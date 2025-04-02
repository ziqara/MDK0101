﻿using System;
using System.Collections.Generic;
using вторая_л;

internal class Program
{
    static void Main(string[] args)
    {
        ReportSales report = new ReportSales();
        report.AddSale(new SalesRecords(1, new Film("Зеленая миля", 1500, 12, Genre.Драма)));
        report.AddSale(new SalesRecords(1, new Film("Работа с автостопом", 1700, 6, Genre.Драма)));

        report.AddSale(new SalesRecords(2, new Film("Суперперцы", 2000, 8, Genre.Комедия)));
        report.AddSale(new SalesRecords(2, new Film("Служебный роман", 1000, 5, Genre.Комедия)));

        report.AddSale(new SalesRecords(3, new Film("Сияние", 350, 13, Genre.Ужасы)));
        report.AddSale(new SalesRecords(3, new Film("Прочь", 500, 9, Genre.Ужасы)));

        report.AddSale(new SalesRecords(4, new Film("Начало", 700, 11, Genre.Фантастика)));
        report.AddSale(new SalesRecords(4, new Film("Матрица", 525, 1, Genre.Фантастика)));

        report.AddSale(new SalesRecords(5, new Film("Индиана Джонс: В поисках утраченного ковчега", 230, 10, Genre.Приключения)));
        report.AddSale(new SalesRecords(5, new Film("Пираты Карибского моря: Проклятие Черной жемчужины", 725, 21, Genre.Приключения)));

        report.AddSale(new SalesRecords(6, new Film("Мстители", 125, 17, Genre.Боевик)));
        report.AddSale(new SalesRecords(6, new Film("Джон Уик", 2300, 41, Genre.Боевик)));

        Console.WriteLine("Выберите вид отчёта (1 - весь, 2 - по жанрам): ");
        if (!int.TryParse(Console.ReadLine(), out int reportType))
        {
            Console.WriteLine("Некорректный ввод");
            return;
        }

        double totalRevenue;
        List<string> reportLines = new List<string>();

        switch (reportType)
        {
            case 1:
                reportLines = report.GetReportAll(out totalRevenue);
                break;

            case 2:
                Console.WriteLine("Введите жанр: ");
                string genreInput = Console.ReadLine();
                reportLines = report.GetReportPerGenre(genreInput, out totalRevenue);
                break;

            default:
                Console.WriteLine("Введено неверное значение");
                return;
        }

        if (reportLines.Count > 0)
        {
            reportLines.ForEach(Console.WriteLine);
            Console.WriteLine($"Общая выручка: {totalRevenue}");
        }
        else
        {
            Console.WriteLine("Выручка по жанру нулевая/Данного жанра не существует");
        }
    }
}
