﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopOnline.Api.Data;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    [DbContext(typeof(ShopOnlineDbContext))]
    [Migration("20240520133450_intToDouble")]
    partial class intToDouble
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopOnline.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            UserId = 5
                        },
                        new
                        {
                            Id = 6,
                            UserId = 6
                        },
                        new
                        {
                            Id = 7,
                            UserId = 7
                        },
                        new
                        {
                            Id = 8,
                            UserId = 8
                        },
                        new
                        {
                            Id = 9,
                            UserId = 9
                        },
                        new
                        {
                            Id = 10,
                            UserId = 10
                        },
                        new
                        {
                            Id = 11,
                            UserId = 11
                        },
                        new
                        {
                            Id = 12,
                            UserId = 12
                        },
                        new
                        {
                            Id = 13,
                            UserId = 13
                        },
                        new
                        {
                            Id = 14,
                            UserId = 14
                        },
                        new
                        {
                            Id = 15,
                            UserId = 15
                        },
                        new
                        {
                            Id = 16,
                            UserId = 16
                        },
                        new
                        {
                            Id = 17,
                            UserId = 17
                        },
                        new
                        {
                            Id = 18,
                            UserId = 18
                        },
                        new
                        {
                            Id = 19,
                            UserId = 19
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Bardzo dobry laptop",
                            CreatedAt = new DateTime(2024, 5, 20, 15, 34, 50, 168, DateTimeKind.Local).AddTicks(3038),
                            ProductId = 1,
                            UserName = "Bob1",
                            Value = 5.0
                        },
                        new
                        {
                            Id = 2,
                            Content = "Słaby laptop",
                            CreatedAt = new DateTime(2024, 5, 20, 15, 34, 50, 168, DateTimeKind.Local).AddTicks(3103),
                            ProductId = 2,
                            UserName = "Adam",
                            Value = 4.5
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Laptop biznesowy Dell Vostro, 8GB RAM, Dysk SSD, Windows 11",
                            ImageURL = "photos/laptopy/dell-1.jpg",
                            Name = "Laptop biznesowy Dell Vostro",
                            Price = 2749m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Laptop biznesowy Lenovo V17 16 GB RAM, Dysk SSD, Windows 11",
                            ImageURL = "photos/laptopy/lenovo-1.jpg",
                            Name = "Laptop biznesowy Lenovo V17",
                            Price = 4790m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Laptop gamingowy Lenovo Legion Slim 5 Procesor Intel Core 13, Nvidia GeForce RTX",
                            ImageURL = "photos/laptopy/gaming-1.jpg",
                            Name = "Laptop gamingowy Lenovo Legion Slim 5",
                            Price = 6799m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Laptop gamingowy Lenovo LOQ 15APH8, AMD Ryzen 7000, NVVIDIA GeForce RTX",
                            ImageURL = "photos/laptopy/gaming-2.jpg",
                            Name = "Laptop gamingowy Lenovo LOQ 15APH8",
                            Price = 4300m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Laptop Apple MacBook Air 2024 13,6,  Czip M3, Bateria 18 godzin",
                            ImageURL = "photos/laptopy/macbook.jpg",
                            Name = "Laptop Apple MacBook Air 2024 13,6",
                            Price = 5599m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Kod aktywacyjny do programu Microsoft Windows 11 Home",
                            ImageURL = "photos/Oprogramowanie/Windows11Home.jpg",
                            Name = "Windows 11 Home",
                            Price = 679m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Kod aktywacyjny do programu Microsoft Windows 11 Pro",
                            ImageURL = "photos/Oprogramowanie/Windows11Pro.jpg",
                            Name = "Program Microsoft Windows 11 Pro",
                            Price = 1419m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Kod aktywacyjny do programu Microsoft Windows 10 Home",
                            ImageURL = "photos/Oprogramowanie/Windows10Home.jpg",
                            Name = "Program Microsoft Windows 10 Home",
                            Price = 299m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "Kod aktywacyjny do programu Microsoft Windows 10 Pro",
                            ImageURL = "photos/Oprogramowanie/Windows10Pro.jpg",
                            Name = "Program Microsoft Windows 10 Pro",
                            Price = 700m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Słuchawki bezprzewodowe - 2,4 GHz, nauszne, zamknięte, PC/laptop, PlayStation 4",
                            ImageURL = "photos/akcesoria/SteelSeries-7.jpg",
                            Name = "Słuchawki bezprzewodowe z mikrofonem SteelSeries Arctis 7",
                            Price = 589m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Myszka bezprzewodowa",
                            ImageURL = "photos/akcesoria/hp-920.jpg",
                            Name = "Myszka HP 920 Ergo Vertical",
                            Price = 249m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Description = "Myszka optyczna przewodowa",
                            ImageURL = "photos/akcesoria/SteelSeries-myszka.jpg",
                            Name = "Myszka gamingowa SteelSeries Rival 3",
                            Price = 149m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = "Myszka laserowa bezprzewodowa",
                            ImageURL = "photos/akcesoria/myszka-mac.jpg",
                            Name = "Myszka Apple Magic Mouse",
                            Price = 333m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "Klawiatura mechaniczna Genesis Thor 303",
                            ImageURL = "photos/akcesoria/klawiatura-genesis.jpg",
                            Name = "Genesis Thor 303",
                            Price = 249m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Description = "Klawiatura membranowa SteelSeries Apex 3",
                            ImageURL = "photos/akcesoria/klawiatura-steelseries.jpg",
                            Name = "SteelSeries Apex 3",
                            Price = 249m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Description = "Klawiatura membranowa Logitech G213 Prodigy",
                            ImageURL = "photos/akcesoria/klawiatura-logitech.jpg",
                            Name = "Logitech G213",
                            Price = 116m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            Description = "Słuchawki bezprzewodowe z mikrofonem Corsair HS55",
                            ImageURL = "photos/akcesoria/sluchawki-logitech.jpg",
                            Name = "Corsair HS55",
                            Price = 309m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            Description = "Słuchawki przewodowe z mikrofonem Trust GXT 408 Cobra",
                            ImageURL = "photos/akcesoria/trust-Gtx.jpg",
                            Name = "Trust GXT",
                            Price = 309m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "Karta graficzna Gigabyte Radeon RX 6600 EAGLE 8GB GDDR6 128bit FSR",
                            ImageURL = "photos/podzespoły/kartyGraficzne-RX6600.jpg",
                            Name = "Gigabyte Radeon RX 6600 EAGLE 8GB",
                            Price = 949m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Karta graficzna Inno3D GeForce RTX 4080 Super X3 OC 16GB GDDR6X 256bit DLSS 3",
                            ImageURL = "photos/podzespoły/kartyGraficzne-Inno3D.jpg",
                            Name = "Inno3D GeForce RTX 4080",
                            Price = 5600m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "Procesor AMD Ryzen 5 5600G BOX",
                            ImageURL = "photos/podzespoły/Procesor-Ryzen5.jpg",
                            Name = "AMD Ryzen 5 5600G",
                            Price = 599m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "Procesor Intel® Core™ i5-12400F BOX",
                            ImageURL = "photos/podzespoły/Procesor-Intel.jpg",
                            Name = "Intel® Core™ i5-12400F",
                            Price = 579m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "Dysk GoodRam CX400 Gen.2 512GB",
                            ImageURL = "photos/podzespoły/Dysk-GoodRam.jpg",
                            Name = "Dysk GoodRam CX400",
                            Price = 149m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 4,
                            Description = "Płyta główna ASUS PRIME B660M-K D4 DDR4",
                            ImageURL = "photos/podzespoły/płytaGłówna-Asus.jpg",
                            Name = "ASUS PRIME B660M-K",
                            Price = 369m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 5,
                            Description = "Monitor Samsung Odyssey OLED G8 S34BG850SU 34\" UWQHD OLED 175Hz 0,03ms Zakrzywiony Gamingowy",
                            ImageURL = "photos/monitory/samsung-Odyssey.jpg",
                            Name = "Monitor Samsung Odyssey OLED",
                            Price = 4339m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 5,
                            Description = "Monitor HP X32c 32\" Full HD VA 165Hz 1ms Zakrzywiony Gamingowy",
                            ImageURL = "photos/monitory/hp-X32c.jpg",
                            Name = "Monitor HP X32c",
                            Price = 799m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 5,
                            Description = "Monitor Philips 272E1GAJ/00 27\" Full HD VA 144Hz 1ms Gamingowy",
                            ImageURL = "photos/monitory/philips-27.jpg",
                            Name = "Monitor Philips 272E1GAJ/00",
                            Price = 679m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 5,
                            Description = "Monitor ASUS ZenScreen MB16AHG 16\" Full HD IPS 144Hz 3ms Przenośny",
                            ImageURL = "photos/monitory/asus-mb.jpg",
                            Name = "Monitor ASUS ZenScreen MB16AHG",
                            Price = 899m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 5,
                            Description = "Monitor ASUS VY249HGE 24\" Full HD IPS 144Hz 1ms Gamingowy",
                            ImageURL = "photos/monitory/asus-vy.jpg",
                            Name = "Monitor ASUS VY249HGE",
                            Price = 1259m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 6,
                            Description = "Komputer gamingowy HP OMEN 40L GT21-0094nw R5 5600G 16GB RAM 1TB Dysk SSD RTX3060 Win11",
                            ImageURL = "photos/zestawy/HP-omen.jpg",
                            Name = "Komputer gamingowy HP OMEN",
                            Price = 4999m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 6,
                            Description = "Komputer Dell Vostro 3710 SFF i5-12400 8GB RAM 512GB Dysk SSD Win11 Pro",
                            ImageURL = "photos/zestawy/Dell-vostro.jpg",
                            Name = "Komputer Dell Vostro 3710",
                            Price = 2369m,
                            Qty = 4300
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 6,
                            Description = "Komputer gamingowy Optimus E-Sport GB660T-CR5 i5-12400F 16GB RAM 1TB Dysk SSD RTX3060 Win11",
                            ImageURL = "photos/zestawy/Optimus.jpg",
                            Name = "Komputer gamingowy Optimus",
                            Price = 2369m,
                            Qty = 4300
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-laptop",
                            Name = "Laptopy"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fa-solid fa-window-restore",
                            Name = "Oprogramowanie"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "fas fa-headphones",
                            Name = "Akcesoria"
                        },
                        new
                        {
                            Id = 4,
                            IconCSS = "fas fa-microchip",
                            Name = "Podzespoły"
                        },
                        new
                        {
                            Id = 5,
                            IconCSS = "fas fa-tv",
                            Name = "Monitory"
                        },
                        new
                        {
                            Id = 6,
                            IconCSS = "fa-solid fa-box-archive",
                            Name = "Zestawy"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Autentykacja")
                        .HasColumnType("bit")
                        .HasColumnName("autentykacja");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Miasto")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("adres_miasto");

                    b.Property<string>("NumerDomu")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("adres_dom");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Ulica")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("adres_ulica");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Autentykacja = false,
                            Email = "Bob@kompik.pl",
                            Miasto = "Kraków",
                            NumerDomu = "15",
                            Password = "1234",
                            Ulica = "Boczna",
                            UserName = "Bob"
                        },
                        new
                        {
                            Id = 2,
                            Autentykacja = false,
                            Email = "Adam@kompik.pl",
                            Miasto = "Kraków",
                            NumerDomu = "5",
                            Password = "1234",
                            Ulica = "Pawia",
                            UserName = "Adam"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.HasOne("ShopOnline.Api.Entities.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
