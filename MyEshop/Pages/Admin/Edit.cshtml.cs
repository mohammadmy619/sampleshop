﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyEshop.Data;
using MyEshop.Models;

namespace MyEshop.Pages.Admin
{
    public class EditModel : PageModel
    {
        private MyEshopContext _context;

        public EditModel(MyEshopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AddEditProductViewModel Product { get; set; }

        [BindProperty]
        public List<int> selectedGroups { get; set; }

        public List<int> GoupsProduct { get; set; }
        public void OnGet(int id)
        {
            var product = _context.Products.Include(p => p.Item)
                .Where(p => p.Id == id)
                .Select(s => new AddEditProductViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    QuantityInStock = s.Item.QuantityInStock,
                    Price = s.Item.Price
                }).FirstOrDefault();
            
            
            Product = product;
            product.Categories = _context.Categories.ToList();
            GoupsProduct = _context.CategoryToProducts.Where(c => c.ProductId == id)
                .Select(s => s.CategoryId).ToList();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var product = _context.Products.Find(Product.Id);
            var item = _context.Items.First(p => p.Id == product.ItemId);

            product.Name = Product.Name;
            product.Description = Product.Description;
            item.Price = Product.Price;
            item.QuantityInStock = Product.QuantityInStock;

            _context.SaveChanges();
            if (Product.Picture?.Length > 0)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "images",
                    product.Id + Path.GetExtension(Product.Picture.FileName));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    Product.Picture.CopyTo(stream);
                }
            }

            _context.CategoryToProducts.Where(c=>c.ProductId==Product.Id).ToList()
                .ForEach(g=>_context.CategoryToProducts.Remove(g));

            if (selectedGroups.Any() && selectedGroups.Count > 0)
            {
                foreach (int gr in selectedGroups)
                {
                    _context.CategoryToProducts.Add(new CategoryToProduct()
                    {
                        CategoryId = gr,
                        ProductId = Product.Id
                    });
                }

                _context.SaveChanges();
            }

            return RedirectToPage("Index");
        }
    }
}