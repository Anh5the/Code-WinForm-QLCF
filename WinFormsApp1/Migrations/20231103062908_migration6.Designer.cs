﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLBH;

#nullable disable

namespace QLBH.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20231103062908_migration6")]
    partial class migration6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QLBH.Models.Category", b =>
                {
                    b.Property<long>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("bit");

                    b.Property<int>("Order")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1L,
                            CategoryName = "Laptop",
                            CategoryStatus = true,
                            Order = 1
                        },
                        new
                        {
                            CategoryID = 2L,
                            CategoryName = "Màn hình",
                            CategoryStatus = true,
                            Order = 4
                        },
                        new
                        {
                            CategoryID = 3L,
                            CategoryName = "Chuột",
                            CategoryStatus = true,
                            Order = 2
                        },
                        new
                        {
                            CategoryID = 4L,
                            CategoryName = "Bàn phím",
                            CategoryStatus = true,
                            Order = 3
                        });
                });

            modelBuilder.Entity("QLBH.Models.Customer", b =>
                {
                    b.Property<long>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CustomerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1L,
                            Address = "111/2 Lê Lợi, P5, Q1, TP. Hồ Chí Minh",
                            BirthDay = new DateTime(1990, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "caulyqua@gmail.com",
                            Gender = false,
                            Name = "Lý Qua Cầu",
                            Phone = "0123456789",
                            Status = true
                        },
                        new
                        {
                            CustomerID = 2L,
                            Address = "2/10 Lý Thái Tổ, P1, Q2, TP. Hồ Chí Minh",
                            BirthDay = new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sontranvan@gmail.com",
                            Gender = true,
                            Name = "Trần Văn Sơn",
                            Phone = "0923456789",
                            Status = true
                        },
                        new
                        {
                            CustomerID = 3L,
                            Address = "9/2 Hoàng Diệu, P4, Q5, TP. Hồ Chí Minh",
                            BirthDay = new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mochoangduocthao@gmail.com",
                            Name = "Hoàng Dược Thảo Mộc",
                            Phone = "0723456789",
                            Status = true
                        },
                        new
                        {
                            CustomerID = 4L,
                            Address = "666/3 Nguyễn Trãi, P1, Tân An, Long An",
                            BirthDay = new DateTime(1991, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "trangcaothu@gmail.com",
                            Gender = false,
                            Name = "Cao Thu Trang",
                            Phone = "0623456789",
                            Status = true
                        },
                        new
                        {
                            CustomerID = 5L,
                            Address = "466/3 Nguyễn Du, P6, Gò Dầu, Tây Ninh",
                            BirthDay = new DateTime(1982, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kieunguyen@gmail.com",
                            Gender = false,
                            Name = "Nguyễn Kiểu",
                            Phone = "0823456789",
                            Status = true
                        });
                });

            modelBuilder.Entity("QLBH.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EmployeeID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)");

                    b.Property<long>("RoleID")
                        .HasColumnType("bigint");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("EmployeeID");

                    b.HasIndex("RoleID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1L,
                            Address = "11A Lý Bí, P5, Q1, TP. Hồ Chí Minh",
                            BirthDay = new DateTime(1990, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "talychieu@gmail.com",
                            Gender = false,
                            Name = "Lý Chiều Tà",
                            Password = "111",
                            Phone = "0133456789",
                            RoleID = 1L,
                            Status = true
                        },
                        new
                        {
                            EmployeeID = 2L,
                            Address = "1110 Lê Thái Tổ, P1, Q2, TP. Hồ Chí Minh",
                            BirthDay = new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hatranvan@gmail.com",
                            Gender = true,
                            Name = "Trần Văn Hà",
                            Password = "111",
                            Phone = "0973456789",
                            RoleID = 2L,
                            Status = true
                        },
                        new
                        {
                            EmployeeID = 3L,
                            Address = "91/2A Trần Quốc Toản, P4, Q5, TP. Hồ Chí Minh",
                            BirthDay = new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "suhoangduocy@gmail.com",
                            Name = "Hoàng Dược Y Sư",
                            Password = "111",
                            Phone = "0823456789",
                            RoleID = 3L,
                            Status = true
                        },
                        new
                        {
                            EmployeeID = 4L,
                            Address = "34212 Nguyễn Trãi, P1, Tân An, Long An",
                            BirthDay = new DateTime(1991, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "truccaothu@gmail.com",
                            Gender = false,
                            Name = "Cao Thu Trúc",
                            Password = "111",
                            Phone = "0623456789",
                            RoleID = 3L,
                            Status = true
                        },
                        new
                        {
                            EmployeeID = 5L,
                            Address = "567/81 Nguyễn ĐÌnh Chiểu, P6, Gò Dầu, Tây Ninh",
                            BirthDay = new DateTime(1982, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "annguyenan@gmail.com",
                            Gender = false,
                            Name = "Nguyễn An An",
                            Password = "111",
                            Phone = "0923456789",
                            RoleID = 4L,
                            Status = true
                        },
                        new
                        {
                            EmployeeID = 6L,
                            Address = "154 Đường số 12 Khu đô thị Licogi TP Cà Mau",
                            BirthDay = new DateTime(2003, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "anh@gmail.com",
                            Gender = true,
                            Name = "Hoàng Ngọc Én",
                            Password = "111",
                            Phone = "0706405339",
                            RoleID = 1L,
                            Status = true
                        });
                });

            modelBuilder.Entity("QLBH.Models.Order", b =>
                {
                    b.Property<long?>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("OrderID"));

                    b.Property<long>("CustomerID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("OrderTime")
                        .HasColumnType("time");

                    b.Property<int>("ProgressID")
                        .HasColumnType("int");

                    b.Property<string>("ReceiveAddress")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("ReceiveDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan?>("ReceiveTime")
                        .HasColumnType("time");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProgressID");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderID = 1L,
                            CustomerID = 1L,
                            OrderDate = new DateTime(2016, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderTime = new TimeSpan(0, 16, 18, 30, 0),
                            ProgressID = 7,
                            ReceiveAddress = "1Z Cao Thắng, P1, Q1,TPHCM",
                            ReceiveDate = new DateTime(2016, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReceiveTime = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            OrderID = 2L,
                            CustomerID = 2L,
                            OrderDate = new DateTime(2016, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderTime = new TimeSpan(0, 16, 40, 50, 0),
                            ProgressID = 7,
                            ReceiveAddress = "123N Lê Lai, P7,QPN, TPHCM",
                            ReceiveDate = new DateTime(2016, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReceiveTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            OrderID = 3L,
                            CustomerID = 3L,
                            OrderDate = new DateTime(2016, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderTime = new TimeSpan(0, 17, 19, 12, 0),
                            ProgressID = 6,
                            ReceiveAddress = "345G Lê Lợi, P4, Q1, TP Mỹ Tho, Tiền Giang",
                            ReceiveDate = new DateTime(2016, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReceiveTime = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            OrderID = 4L,
                            CustomerID = 4L,
                            OrderDate = new DateTime(2017, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderTime = new TimeSpan(0, 7, 42, 19, 0),
                            ProgressID = 1,
                            ReceiveAddress = "1B Lý Thái Tổ, P2, TPHCM",
                            ReceiveDate = new DateTime(2017, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReceiveTime = new TimeSpan(0, 10, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("QLBH.Models.OrderDetail", b =>
                {
                    b.Property<long>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<long>("OrderDetailID")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("QLBH.Models.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductID"));

                    b.Property<long>("CategoryID")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ImageFile")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal?>("MarketPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1L,
                            CategoryID = 1L,
                            Description = "Chơi game tốt",
                            ImageFile = "1.png",
                            Name = "Laptop ToBaShi 12N4",
                            Price = 150.50m,
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 2L,
                            CategoryID = 1L,
                            Description = "Xử lý đồ họa tốt",
                            ImageFile = "2.png",
                            Name = "Laptop ShiBaCo N4T0",
                            Price = 250.50m,
                            Quantity = 15,
                            Status = true
                        },
                        new
                        {
                            ProductID = 3L,
                            CategoryID = 1L,
                            Description = "Chơi game tốt",
                            ImageFile = "3.png",
                            Name = "Lapto ToBaShi 12N5",
                            Price = 180.50m,
                            Quantity = 14,
                            Status = true
                        },
                        new
                        {
                            ProductID = 4L,
                            CategoryID = 1L,
                            Description = "Xử lý đồ họa tốt",
                            ImageFile = "4.png",
                            Name = "Laptop ShiBaCo N4T1",
                            Price = 250.50m,
                            Quantity = 13,
                            Status = true
                        },
                        new
                        {
                            ProductID = 5L,
                            CategoryID = 1L,
                            Description = "Chơi game tốt",
                            ImageFile = "5.png",
                            Name = "Laptop ToBaShi 12N6",
                            Price = 350.50m,
                            Quantity = 20,
                            Status = true
                        },
                        new
                        {
                            ProductID = 6L,
                            CategoryID = 1L,
                            Description = "Xử lý đồ họa tốt",
                            ImageFile = "6.png",
                            Name = "Laptop ShiBaCo N4T2",
                            Price = 380.50m,
                            Quantity = 40,
                            Status = true
                        },
                        new
                        {
                            ProductID = 7L,
                            CategoryID = 1L,
                            Description = "Chơi game tốt",
                            ImageFile = "7.png",
                            Name = "Laptop ToBaShi 12N7",
                            Price = 280.50m,
                            Quantity = 29,
                            Status = true
                        },
                        new
                        {
                            ProductID = 8L,
                            CategoryID = 1L,
                            Description = "Xử lý đồ họa tốt",
                            ImageFile = "8.png",
                            Name = "Laptop ShiBaCo N4T3",
                            Price = 450.50m,
                            Quantity = 30,
                            Status = true
                        },
                        new
                        {
                            ProductID = 9L,
                            CategoryID = 1L,
                            Description = "Chơi game tốt",
                            ImageFile = "9.png",
                            Name = "Laptop ToBaShi 12N8",
                            Price = 380.50m,
                            Quantity = 15,
                            Status = true
                        },
                        new
                        {
                            ProductID = 10L,
                            CategoryID = 1L,
                            Description = "Xử lý đồ họa tốt",
                            ImageFile = "10.png",
                            Name = "Laptop ShiBaCo N4T4",
                            Price = 550.50m,
                            Quantity = 50,
                            Status = true
                        },
                        new
                        {
                            ProductID = 11L,
                            CategoryID = 1L,
                            Description = "Chơi game tốt",
                            ImageFile = "11.png",
                            Name = "Laptop ToBaShi 12N9",
                            Price = 450.50m,
                            Quantity = 60,
                            Status = true
                        },
                        new
                        {
                            ProductID = 12L,
                            CategoryID = 1L,
                            Description = "Xử lý đồ họa tốt",
                            ImageFile = "12.png",
                            Name = "Laptop ShiBaCo N4T5",
                            Price = 650.50m,
                            Quantity = 40,
                            Status = true
                        },
                        new
                        {
                            ProductID = 13L,
                            CategoryID = 2L,
                            Description = "Chơi game tốt",
                            ImageFile = "13.png",
                            Name = "Màn hình ToBaShi 12N4",
                            Price = 50.50m,
                            Quantity = 4,
                            Status = true
                        },
                        new
                        {
                            ProductID = 14L,
                            CategoryID = 2L,
                            Description = "Xử lý đồ họa tốt",
                            ImageFile = "14.png",
                            Name = "Màn hình ShiBaCo N4T0",
                            Price = 60.50m,
                            Quantity = 12,
                            Status = true
                        },
                        new
                        {
                            ProductID = 15L,
                            CategoryID = 2L,
                            Description = "Chơi game tốt",
                            ImageFile = "15.png",
                            Name = "Màn hình ToBaShi 12N5",
                            Price = 60.50m,
                            Quantity = 15,
                            Status = true
                        },
                        new
                        {
                            ProductID = 16L,
                            CategoryID = 2L,
                            Description = "Xử lý đồ họa tốt",
                            ImageFile = "16.png",
                            Name = "Màn hình ShiBaCo N4T1",
                            Price = 70.50m,
                            Quantity = 14,
                            Status = true
                        },
                        new
                        {
                            ProductID = 17L,
                            CategoryID = 2L,
                            Description = "Chơi game tốt",
                            ImageFile = "17.png",
                            Name = "Màn hình ToBaShi 12N6",
                            Price = 70.50m,
                            Quantity = 26,
                            Status = true
                        },
                        new
                        {
                            ProductID = 18L,
                            CategoryID = 2L,
                            Description = "Xử lý đồ họa tốt",
                            ImageFile = "18.png",
                            Name = "Màn hình ShiBaCo N4T2",
                            Price = 80.50m,
                            Quantity = 30,
                            Status = true
                        },
                        new
                        {
                            ProductID = 19L,
                            CategoryID = 2L,
                            Description = "Chơi game tốt",
                            ImageFile = "19.png",
                            Name = "Màn hình ToBaShi 12N7",
                            Price = 80.50m,
                            Quantity = 12,
                            Status = true
                        },
                        new
                        {
                            ProductID = 20L,
                            CategoryID = 2L,
                            Description = "Xử lý đồ họa tốt",
                            ImageFile = "20.png",
                            Name = "Màn hình ShiBaCo N4T3",
                            Price = 90.50m,
                            Quantity = 10,
                            Status = true
                        },
                        new
                        {
                            ProductID = 21L,
                            CategoryID = 2L,
                            Description = "Chơi game tốt",
                            ImageFile = "21.png",
                            Name = "Màn hình ToBaShi 12N8",
                            Price = 100.50m,
                            Quantity = 12,
                            Status = true
                        },
                        new
                        {
                            ProductID = 22L,
                            CategoryID = 2L,
                            Description = "Xử lý đồ họa tốt",
                            ImageFile = "22.png",
                            Name = "Màn hình ShiBaCo N4T4",
                            Price = 110.50m,
                            Quantity = 12,
                            Status = true
                        },
                        new
                        {
                            ProductID = 23L,
                            CategoryID = 2L,
                            Description = "Chơi game tốt",
                            ImageFile = "23.png",
                            Name = "Màn hình ToBaShi 12N9",
                            Price = 110.50m,
                            Quantity = 11,
                            Status = true
                        },
                        new
                        {
                            ProductID = 24L,
                            CategoryID = 2L,
                            Description = "Xử lý đồ họa tốt",
                            ImageFile = "24.png",
                            Name = "Màn hình ShiBaCo N4T5",
                            Price = 120.00m,
                            Quantity = 5,
                            Status = true
                        });
                });

            modelBuilder.Entity("QLBH.Models.Progress", b =>
                {
                    b.Property<int>("ProgressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgressID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nchar(15)");

                    b.HasKey("ProgressID");

                    b.ToTable("Progresses");

                    b.HasData(
                        new
                        {
                            ProgressID = 1,
                            Name = "New"
                        },
                        new
                        {
                            ProgressID = 2,
                            Name = "Processing"
                        },
                        new
                        {
                            ProgressID = 3,
                            Name = "Shipping"
                        },
                        new
                        {
                            ProgressID = 4,
                            Name = "Canceled"
                        },
                        new
                        {
                            ProgressID = 5,
                            Name = "Instalment"
                        },
                        new
                        {
                            ProgressID = 6,
                            Name = "Failed"
                        },
                        new
                        {
                            ProgressID = 7,
                            Name = "Completed"
                        });
                });

            modelBuilder.Entity("QLBH.Models.Role", b =>
                {
                    b.Property<long>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RoleID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = 1L,
                            Name = "Tổng quản lý"
                        },
                        new
                        {
                            RoleID = 2L,
                            Name = "Quản lý chuyến bay"
                        },
                        new
                        {
                            RoleID = 3L,
                            Name = "Quản lý phi công"
                        },
                        new
                        {
                            RoleID = 4L,
                            Name = "Quản lý hành khách"
                        },
                        new
                        {
                            RoleID = 5L,
                            Name = "Phi công"
                        });
                });

            modelBuilder.Entity("QLBH.Models.Employee", b =>
                {
                    b.HasOne("QLBH.Models.Role", "Roles")
                        .WithMany("Employees")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("QLBH.Models.Order", b =>
                {
                    b.HasOne("QLBH.Models.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLBH.Models.Progress", "Progress")
                        .WithMany("Orders")
                        .HasForeignKey("ProgressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Progress");
                });

            modelBuilder.Entity("QLBH.Models.OrderDetail", b =>
                {
                    b.HasOne("QLBH.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLBH.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("QLBH.Models.Product", b =>
                {
                    b.HasOne("QLBH.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("QLBH.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("QLBH.Models.Customer", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("QLBH.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("QLBH.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("QLBH.Models.Progress", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("QLBH.Models.Role", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
