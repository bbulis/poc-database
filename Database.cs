using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace poc_database {
    public class DatabaseContext : DbContext {
        public DbSet<Tire> Tires {get; set;}
        public DbSet<OrderItem> OrderItems {get; set;}
        public DbSet<Order> Orders {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
    }

    public class Order {
        public string OrderId {get; set;}
        public DateTime? created {get; set;}
        public ICollection<OrderItem> Items {get; set;}
    }

    public class OrderItem {
        public string OrderItemId {get; set;}
        public int Quantity {get; set;}
        public virtual Tire Tire {get; set;}
    }

    public class Tire {
        public string TireId {get; set;}
        public string Brand {get; set;}
        public int Width {get; set;}
        public int Height {get; set;}
        public int RimSize {get; set;}
        public int LoadIndex {get; set;}
        public char SpeedIndex {get; set;}
        public string Description {get; set;}
        public double Price {get; set;}

        public override string ToString()
        {
            return String.Format("{0}; {1} {2}/{3}R{4} {5}{6} {7}; {8}", 
                    this.TireId,
                    this.Brand,
                    this.Width,
                    this.Height,
                    this.RimSize,
                    this.LoadIndex,
                    this.SpeedIndex,
                    this.Description,
                    this.Price);
        }

    }

}