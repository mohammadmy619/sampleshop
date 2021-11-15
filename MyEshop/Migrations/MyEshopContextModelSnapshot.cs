﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyEshop.Data;

namespace MyEshop.Migrations
{
    [DbContext(typeof(MyEshopContext))]
    partial class MyEshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("MyEshop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "سرمایشی",
                            Name = "سرمایشی"
                        },
                        new
                        {
                            Id = 2,
                            Description = "تصویه آب",
                            Name = "تصویه آب"
                        },
                        new
                        {
                            Id = 3,
                            Description = "بخاری",
                            Name = "بخاری"
                        },
                        new
                        {
                            Id = 4,
                            Description = "لوازم منزل",
                            Name = "لوازم منزل"
                        });
                });

            modelBuilder.Entity("MyEshop.Models.CategoryToProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryToProducts");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 1,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 1,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 4
                        });
                });

            modelBuilder.Entity("MyEshop.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Price")
                        .HasColumnType("Money");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 854.0m,
                            QuantityInStock = 5
                        },
                        new
                        {
                            Id = 2,
                            Price = 3302.0m,
                            QuantityInStock = 8
                        },
                        new
                        {
                            Id = 3,
                            Price = 2500m,
                            QuantityInStock = 3
                        });
                });

            modelBuilder.Entity("MyEshop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFinaly")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyEshop.Models.OrderDetail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("DetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("MyEshop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "گوشی موبایل «iPhone 13» پرچم‌دار جدید شرکت اپل است که با چند ویژگی جدید و دوربین دوگانه روانه بازار شده است. اپل برای ویژگی‌ها و طراحی کلی این گوشی از همان فرمول چند سال اخیرش استفاده کرده است. نمایشگر آیفون 13 به پنل Super Retina مجهز ‌شده است تا تصاویر بسیار مطلوبی را به کاربر عرضه کند. این نمایشگر رزولوشن بسیار بالایی دارد؛ به‌طوری‌که در اندازه­‌ی 6.1 اینچی‌اش، حدود 460 پیکسل را در هر اینچ جا داده است. امکان شارژ بی‌‌سیم باتری در این گوشی وجود دارد. روکش سرامیکی صفحه‌نمایش این گوشی می‌تواند انقلابی در محافظت به‌پا کند. این گوشی ضدآب و ضد گردوخاک است. بدنه­ زیبا iPhone 13 در مقابل خط‌‌وخش مقاومت زیادی دارد؛ پس خیالتان از این بابت که آب و گردوغبار به‌‌راحتی روی آیفون 13 تأثیر نمی‌‌گذارد، راحت باشد. علاوه‌براین لکه و چربی هم روی این صفحه‌نمایش باکیفیت تأثیر چندانی ندارند. تشخیص چهره با استفاده از دوربین جلو دیگر ویژگی است که در آیفون جدید اپل به کار گرفته شده است. قابلیت اتصال به شبکه­‌های 4G و 5G، بلوتوث نسخه‌ 5، نسخه­‌ 15 از iOS دیگر ویژگی‌های این گوشی هستند. ازنظر سخت‌‌افزاری هم این گوشی از تراشه­‌ی جدید A15 بهره می‌برد که دارای 15 میلیارد ترانزیستور است که دارای کنترل گرمای مطلوبی بوده که تا بتواند علاوه بر کارهای معمول، از قابلیت‌های جدید واقعیت مجازی که اپل این روزها روی آن تمرکز خاصی دارد، پشتیبانی کند. به گفته خود شرکت اپل این گوشی دارای سرعتی 50 برابر نسخه 12 خود است. پردازنده دارای ماژولار جدیدی است که مصرف باتری را بسیار پایین‌تر آورده است و شما دارای حفظ باتری بالاتری هستید. کیفیت نمایش شما در iPhone 13 دارای 120 هرتز است و کسفیت بالایی را شاهد خواهید بود. اپل در این سری از گوشی‌های iPhone خود پردازنده گرافیکی‌ای را قرار داده که از سری 12 گوشی‌های خود 30 درصد سریع‌تر است و این نویدبخش آن است که شما می‌توانید بازی‌هایی را با گرافیک و MAP سنگین تر و بزرگ‌تر اجرا کنید. یکی از ویژگی‌هایی که در iPhone 13 شاهد هستیم سیستم فیلمبرداری ProRes سینمایی آن است که می تواند انقلابی در فیلمبرداری گوشی‌های موبایل به‌راه انداخته باشد. این قابلیت می‌تواند نسبت به صورت روبرو بین افراد و یا بین فرد و اشیا فوکوس و بِلار داشته باشد.",
                            ItemId = 1,
                            Name = "آیفون 13"
                        },
                        new
                        {
                            Id = 2,
                            Description = "چادر 8 نفره آی تی تنت این مشخصات را همگی در کنار هم جای داده و به شما عرضه می‌کند. این چادر در حالت بسته بودن ابعادی معادل 15 × 16 × 68 سانتی‌متر را اشغال می‌کند که به سادگی می‌تواند در کوله‌پشتی یا صندوق خودروی شما جای‌گیرد. چادر 8 نفره آی تی تنت سه پنجره دارد و از ستون بندی سبک و مقاوم فایبرگلاس بهره می‌برد. بدنه‌ی این چادر در برابر آب باران مقاومت خوبی از خود نشان می‌‌دهد و شما را در برابر ریزش باران طبیعت مصون خواهد کرد. خرید و استفاده از این چادر مناسب برای تمام کسانی است که به سفرهای کمپینگ و شب را در زیر آسمان سپری کردن علاقه‌مند هستند ",
                            ItemId = 2,
                            Name = "چادر مسافرتی"
                        },
                        new
                        {
                            Id = 3,
                            Description = "اگر می‌خواهید دندان‌هایی سالم، دهانی خوش‌بو و در نتیجه لبخندی زیبا و دل‌نشین داشته باشید، بهتر است که بهداشت دهان و دندانتان را جدی‌تر بگیرید. استفاده از دهان‌شویه در کنار مسواک‌زدن دندان‌ها تاثیر بهتری در سلامت و محافظت از دندان‌ها و به‌خصوص سلامت و تازگی محیط دهان خواهد داشت. برند بهداشتی «وی وان» (Vi-One) برای این منظور دهان‌شویه‌ای با طعم نعناع تازه (Feresh Mint) تولید و ارائه کرده است. این محصول دارای فرمولاسیونی برای مقابله با باکتری‌های دهانی و جلوگیری از التهاب لثه است. استفاده از این شوینده‌ی دهانی برای افرادی که دارای پوسیدگی دندان هستند، همچنین برای متوقف‌کردن پوسیدگی اولیه و ترمیم آن بسیار مفید خواهد بود. همین‌طور ریزکف‌های موجود در آن با نفوذ به پلاک دندان موجب لغزنده‌شدن آن و در نهایت تسهیل مسواک‌زدن",
                            ItemId = 3,
                            Name = "بهداشتی"
                        });
                });

            modelBuilder.Entity("MyEshop.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyEshop.Models.CategoryToProduct", b =>
                {
                    b.HasOne("MyEshop.Models.Category", "Category")
                        .WithMany("CategoryToProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyEshop.Models.Product", "Product")
                        .WithMany("CategoryToProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MyEshop.Models.Order", b =>
                {
                    b.HasOne("MyEshop.Models.Users", "Users")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("MyEshop.Models.OrderDetail", b =>
                {
                    b.HasOne("MyEshop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyEshop.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MyEshop.Models.Product", b =>
                {
                    b.HasOne("MyEshop.Models.Item", "Item")
                        .WithOne("Product")
                        .HasForeignKey("MyEshop.Models.Product", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("MyEshop.Models.Category", b =>
                {
                    b.Navigation("CategoryToProducts");
                });

            modelBuilder.Entity("MyEshop.Models.Item", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("MyEshop.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("MyEshop.Models.Product", b =>
                {
                    b.Navigation("CategoryToProducts");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("MyEshop.Models.Users", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
