using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyEshop.Models;

namespace MyEshop.Data
{
    public class MyEshopContext : DbContext
    {
        public MyEshopContext(DbContextOptions<MyEshopContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryToProduct> CategoryToProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryToProduct>()
                .HasKey(t => new { t.ProductId, t.CategoryId });

            //modelBuilder.Entity<Product>(
            //    p =>
            //    {
            //        p.HasKey(w => w.Id);
            //        p.OwnsOne<Item>(w => w.Item);
            //        p.HasOne<Item>(w => w.Item)
            //            .WithOne(w => w.Product)
            //            .HasForeignKey<Item>(w => w.Id);
            //    }
            //);

            modelBuilder.Entity<Item>(i =>
            {
                i.Property(w => w.Price).HasColumnType("Money");
                i.HasKey(w => w.Id);
            });

            #region Seed Data Category

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                Name = "سرمایشی",
                Description = "سرمایشی"
            },
                new Category()
                {
                    Id = 2,
                    Name = "تصویه آب",
                    Description = "تصویه آب"
                },
                new Category()
                {
                    Id = 3,
                    Name = "بخاری",
                    Description = "بخاری"
                },
                new Category()
                {
                    Id = 4,
                    Name = "لوازم منزل",
                    Description = "لوازم منزل"
                }
            );

            modelBuilder.Entity<Item>().HasData(
                new Item()
                {
                    Id = 1,
                    Price = 854.0M,
                    QuantityInStock = 5
                },
            new Item()
            {
                Id = 2,
                Price = 3302.0M,
                QuantityInStock = 8
            },
            new Item()
            {
                Id = 3,
                Price = 2500,
                QuantityInStock = 3
            });

            modelBuilder.Entity<Product>().HasData(new Product()
                {
                    Id = 1,
                    ItemId = 1,
                    Name = "آیفون 13",
                    Description =
                        "گوشی موبایل «iPhone 13» پرچم‌دار جدید شرکت اپل است که با چند ویژگی جدید و دوربین دوگانه روانه بازار شده است. اپل برای ویژگی‌ها و طراحی کلی این گوشی از همان فرمول چند سال اخیرش استفاده کرده است. نمایشگر آیفون 13 به پنل Super Retina مجهز ‌شده است تا تصاویر بسیار مطلوبی را به کاربر عرضه کند. این نمایشگر رزولوشن بسیار بالایی دارد؛ به‌طوری‌که در اندازه­‌ی 6.1 اینچی‌اش، حدود 460 پیکسل را در هر اینچ جا داده است. امکان شارژ بی‌‌سیم باتری در این گوشی وجود دارد. روکش سرامیکی صفحه‌نمایش این گوشی می‌تواند انقلابی در محافظت به‌پا کند. این گوشی ضدآب و ضد گردوخاک است. بدنه­ زیبا iPhone 13 در مقابل خط‌‌وخش مقاومت زیادی دارد؛ پس خیالتان از این بابت که آب و گردوغبار به‌‌راحتی روی آیفون 13 تأثیر نمی‌‌گذارد، راحت باشد. علاوه‌براین لکه و چربی هم روی این صفحه‌نمایش باکیفیت تأثیر چندانی ندارند. تشخیص چهره با استفاده از دوربین جلو دیگر ویژگی است که در آیفون جدید اپل به کار گرفته شده است. قابلیت اتصال به شبکه­‌های 4G و 5G، بلوتوث نسخه‌ 5، نسخه­‌ 15 از iOS دیگر ویژگی‌های این گوشی هستند. ازنظر سخت‌‌افزاری هم این گوشی از تراشه­‌ی جدید A15 بهره می‌برد که دارای 15 میلیارد ترانزیستور است که دارای کنترل گرمای مطلوبی بوده که تا بتواند علاوه بر کارهای معمول، از قابلیت‌های جدید واقعیت مجازی که اپل این روزها روی آن تمرکز خاصی دارد، پشتیبانی کند. به گفته خود شرکت اپل این گوشی دارای سرعتی 50 برابر نسخه 12 خود است. پردازنده دارای ماژولار جدیدی است که مصرف باتری را بسیار پایین‌تر آورده است و شما دارای حفظ باتری بالاتری هستید. کیفیت نمایش شما در iPhone 13 دارای 120 هرتز است و کسفیت بالایی را شاهد خواهید بود. اپل در این سری از گوشی‌های iPhone خود پردازنده گرافیکی‌ای را قرار داده که از سری 12 گوشی‌های خود 30 درصد سریع‌تر است و این نویدبخش آن است که شما می‌توانید بازی‌هایی را با گرافیک و MAP سنگین تر و بزرگ‌تر اجرا کنید. یکی از ویژگی‌هایی که در iPhone 13 شاهد هستیم سیستم فیلمبرداری ProRes سینمایی آن است که می تواند انقلابی در فیلمبرداری گوشی‌های موبایل به‌راه انداخته باشد. این قابلیت می‌تواند نسبت به صورت روبرو بین افراد و یا بین فرد و اشیا فوکوس و بِلار داشته باشد."
            },
                new Product()
                {
                    Id = 2,
                    ItemId = 2,
                    Name = "چادر مسافرتی",
                    Description =
                        "چادر 8 نفره آی تی تنت این مشخصات را همگی در کنار هم جای داده و به شما عرضه می‌کند. این چادر در حالت بسته بودن ابعادی معادل 15 × 16 × 68 سانتی‌متر را اشغال می‌کند که به سادگی می‌تواند در کوله‌پشتی یا صندوق خودروی شما جای‌گیرد. چادر 8 نفره آی تی تنت سه پنجره دارد و از ستون بندی سبک و مقاوم فایبرگلاس بهره می‌برد. بدنه‌ی این چادر در برابر آب باران مقاومت خوبی از خود نشان می‌‌دهد و شما را در برابر ریزش باران طبیعت مصون خواهد کرد. خرید و استفاده از این چادر مناسب برای تمام کسانی است که به سفرهای کمپینگ و شب را در زیر آسمان سپری کردن علاقه‌مند هستند "
                },
                new Product()
                {
                    Id = 3,
                    ItemId = 3,
                    Name = "بهداشتی",
                    Description = "اگر می‌خواهید دندان‌هایی سالم، دهانی خوش‌بو و در نتیجه لبخندی زیبا و دل‌نشین داشته باشید، بهتر است که بهداشت دهان و دندانتان را جدی‌تر بگیرید. استفاده از دهان‌شویه در کنار مسواک‌زدن دندان‌ها تاثیر بهتری در سلامت و محافظت از دندان‌ها و به‌خصوص سلامت و تازگی محیط دهان خواهد داشت. برند بهداشتی «وی وان» (Vi-One) برای این منظور دهان‌شویه‌ای با طعم نعناع تازه (Feresh Mint) تولید و ارائه کرده است. این محصول دارای فرمولاسیونی برای مقابله با باکتری‌های دهانی و جلوگیری از التهاب لثه است. استفاده از این شوینده‌ی دهانی برای افرادی که دارای پوسیدگی دندان هستند، همچنین برای متوقف‌کردن پوسیدگی اولیه و ترمیم آن بسیار مفید خواهد بود. همین‌طور ریزکف‌های موجود در آن با نفوذ به پلاک دندان موجب لغزنده‌شدن آن و در نهایت تسهیل مسواک‌زدن"
                });

            modelBuilder.Entity<CategoryToProduct>().HasData(
                new CategoryToProduct() { CategoryId = 1,ProductId = 1},
                new CategoryToProduct() { CategoryId = 2,ProductId = 1},
                new CategoryToProduct() { CategoryId = 3,ProductId = 1},
                new CategoryToProduct() { CategoryId = 4,ProductId = 1},
                new CategoryToProduct() { CategoryId = 1, ProductId = 2 },
                new CategoryToProduct() { CategoryId = 2, ProductId = 2 },
                new CategoryToProduct() { CategoryId = 3, ProductId = 2 },
                new CategoryToProduct() { CategoryId = 4, ProductId = 2 },
                new CategoryToProduct() { CategoryId = 1, ProductId = 3 },
                new CategoryToProduct() { CategoryId = 2, ProductId = 3 },
                new CategoryToProduct() { CategoryId = 3, ProductId = 3 },
                new CategoryToProduct() { CategoryId = 4, ProductId = 3 }
                );
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
