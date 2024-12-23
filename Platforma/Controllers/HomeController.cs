using Microsoft.AspNetCore.Mvc;
using Platforma.Data;
using Platforma.Models;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace Platforma.Controllers

{

    public class HomeViewModel
    {
        public IEnumerable<Listing> Listings { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // ¬ыборка данных дл€ отображени€ на главной странице
            var listings = _context.Listings

       .Include(l => l.Location)
       .OrderByDescending(l => l.PublishedAt)
       .Take(10)
       .ToList();

            return View(listings);
        }
    }
}

