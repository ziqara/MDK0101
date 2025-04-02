using System.Collections.Generic;
using вторая_л;

public class ReportSales
{
    private List<SalesRecords> salesRecords;

    public ReportSales()
    {
        salesRecords = new List<SalesRecords>();
    }

    public void AddSale(SalesRecords record)
    {
        salesRecords.Add(record);
    }

    public List<string> GetReportAll(out double totalRevenue)
    {
        totalRevenue = 0;
        List<string> reportLines = new List<string>();

        foreach (var record in salesRecords)
        {
            var film = record.GetFilm();
            double revenue = film.GetPrice() * film.GetQuantity();
            reportLines.Add($"День: {record.GetDay()}, Название фильма: {film.GetName()}, Жанр: {film.GetGenre()}, Цена: {film.GetPrice()}, Количество: {film.GetQuantity()}, Выручка с фильма: {revenue}");
            totalRevenue += revenue;
        }

        return reportLines;
    }

    public List<string> GetReportPerGenre(string genreInput, out double totalRevenue)
    {
        totalRevenue = 0;
        List<string> reportLines = new List<string>();

        foreach (var record in salesRecords)
        {
            var film = record.GetFilm();
            if (film.GetGenre().ToString() == genreInput)
            {
                double revenue = film.GetPrice() * film.GetQuantity();
                reportLines.Add($"День: {record.GetDay()}, Название фильма: {film.GetName()}, Жанр: {film.GetGenre()}, Цена: {film.GetPrice()}, Количество: {film.GetQuantity()}, Выручка с фильма: {revenue}");
                totalRevenue += revenue;
            }
        }

        return reportLines;
    }
}
