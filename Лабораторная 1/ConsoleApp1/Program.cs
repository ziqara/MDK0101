using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProductInfo> products = new List<ProductInfo>
            {
                new ProductInfo { ProductName = "Спиннинг Graphiteleader Finezza Nuovo", Category = "Спиннинги", PriceProduct = 2000},
                new ProductInfo { ProductName = "Спиннинг Major Craft SolPara", Category = "Спиннинги", PriceProduct = 1000 },
                new ProductInfo { ProductName = "Крючок Owner Chinu", Category = "Крючки", PriceProduct = 2000},
                new ProductInfo { ProductName = "Крючок Gamakatsu A1 G-Carp Hook", Category = "Крючки", PriceProduct = 8000 },
                new ProductInfo { ProductName = "Воблер Kosadaka Meta XS 65F", Category = "Приманки", PriceProduct = 2000},
                new ProductInfo { ProductName = "Блесна Blue Fox Vibrax", Category = "Приманки", PriceProduct = 1000 }
            };

            Console.Write("Введите название категории товара: ");
            string categoryInput = Console.ReadLine();
            List<ProductInfo> foundProducts = SearchProductsByCategory(products, categoryInput);
            if (foundProducts.Count > 0)
            {
                Console.WriteLine("Найденные товары:");
                foreach (var product in foundProducts)
                {
                    Console.WriteLine($"Название: {product.ProductName}, Цена: {product.PriceProduct}");
                }
            }
            else
            {
                Console.WriteLine("Товары в данной категории не найдены.");
            }

            List<ProductInfo> Products = products;
            Console.WriteLine("Все товары:");
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.ProductName}, Категория: {product.Category}");
            }


            List<ProductInfo> sortedProducts = SortedProducts(products); 
            Console.WriteLine("Товары, отсортированные по цене (от дешевых к дорогим):");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Название: {product.ProductName}, Категория: {product.Category}, Цена: {product.PriceProduct}");
            }

            Dictionary<string, double> averagePricesByCategory = AveragePricesByCategory(products);
            Console.WriteLine("Средние цены по категориям:");
            foreach (var averagePrices in averagePricesByCategory)
            {
                Console.WriteLine($"Категория: {averagePrices.Key}, Средняя цена: {averagePrices.Value}");
            }

            Console.ReadKey();
        }

        public static List<ProductInfo> SearchProductsByCategory(List<ProductInfo> products, string categoryName)
        {
            return products.Where(p => p.Category == categoryName).ToList();
        }

        private static Dictionary<string, double> AveragePricesByCategory(List<ProductInfo> products)
        {
            var averagePrices = new Dictionary<string, double>(); // Создаем словарь для хранения средних цен по категориям

            Dictionary<string, List<ProductInfo>> groupedProducts = new Dictionary<string, List<ProductInfo>>(); // Группируем товары по категориям
            foreach (var product in products)
            {
                if (!groupedProducts.ContainsKey(product.Category))
                {
                    groupedProducts[product.Category] = new List<ProductInfo>();
                }
                groupedProducts[product.Category].Add(product);
            }



            foreach (var category in groupedProducts.Keys) // Рассчитываем среднюю цену для каждой категории
            {
                double sum = 0;
                List<ProductInfo> productList = groupedProducts[category];
                foreach (var product in productList)
                {
                    sum += product.PriceProduct;
                }

                double average = sum / productList.Count;
                averagePrices[category] = average;
            }

            return averagePrices; // Возвращаем значение в словарь для хранения средних цен по категориям
        }


        public static List<ProductInfo> SortedProducts(List<ProductInfo> products)
        {
            List<ProductInfo> sortedProducts = new List<ProductInfo>(products);

            // Используем алгоритм сортировки пузырьком
            for (int i = 0; i < sortedProducts.Count - 1; i++)
            {
                for (int j = 0; j < sortedProducts.Count - i - 1; j++)
                {
                    if (sortedProducts[j].PriceProduct > sortedProducts[j + 1].PriceProduct)
                    {
                        ProductInfo temp = sortedProducts[j];
                        sortedProducts[j] = sortedProducts[j + 1];
                        sortedProducts[j + 1] = temp;
                    }
                }
            }

            return sortedProducts;
        }
    }
}
