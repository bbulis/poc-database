// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using poc_database;

#nullable disable

namespace poc_database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("poc_database.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("created")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("poc_database.OrderItem", b =>
                {
                    b.Property<string>("OrderItemId")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TireId")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("TireId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("poc_database.Tire", b =>
                {
                    b.Property<string>("TireId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LoadIndex")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("RimSize")
                        .HasColumnType("INTEGER");

                    b.Property<char>("SpeedIndex")
                        .HasColumnType("TEXT");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("TireId");

                    b.ToTable("Tires");
                });

            modelBuilder.Entity("poc_database.OrderItem", b =>
                {
                    b.HasOne("poc_database.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.HasOne("poc_database.Tire", "Tire")
                        .WithMany()
                        .HasForeignKey("TireId");

                    b.Navigation("Tire");
                });

            modelBuilder.Entity("poc_database.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
