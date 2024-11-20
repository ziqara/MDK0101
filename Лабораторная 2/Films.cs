using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace вторая_л
{
    public class Film
    {
        private string name_;
        private double price_;
        private int quantity_;
        private Genre genre_;

        public Film(string name, double price, int quantity, Genre genre)
        {
            name_ = name;
            price_ = price;
            quantity_ = quantity;
            genre_ = genre;
        }

        public string GetName()
        {
            return name_;
        }

        public double GetPrice()
        {
            return price_;
        }

        public int GetQuantity()
        {
            return quantity_;
        }

        public Genre GetGenre()
        {
            return genre_;
        }
    }
}



