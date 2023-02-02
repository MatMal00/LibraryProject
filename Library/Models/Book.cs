﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class Book
    {
        public Book()
        {
            Bestsellers = new HashSet<Bestseller>();
            Orders = new HashSet<Order>();
            RentedBooks = new HashSet<RentedBook>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string BookDescription { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public bool IsRentable { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Bestseller> Bestsellers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<RentedBook> RentedBooks { get; set; }
    }
}