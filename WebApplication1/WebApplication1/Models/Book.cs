using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebApplication1.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int CatId { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        

        public Book()
        {

        }

        public Book(int bookId, int catId, string title, int isbn, int year, float price,int quantity, string description, string image)
        {
            BookId = bookId;
            CatId = catId;
            Title = title;
            ISBN = isbn;
            Year = year;
            Price = price;
            Quantity = quantity;
            Description = description;
            Image = image;
        }
    }
}