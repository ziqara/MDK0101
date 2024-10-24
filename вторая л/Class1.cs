using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace вторая_л
{
    public class Film
    {
        
        public string Name;
        public double Price;
        public Genre Genre;
        

        public Film(string name, Genre genre, double price)
        {
            Price = price;
            Genre = genre;
            Name = name;
        }



    }



}