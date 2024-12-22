using Microsoft.AspNetCore.Mvc;
using Platforma.Data;
using Platforma.Models;
using System.Collections.Generic;
using System;

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
            // ������� ������ ��� ����������� �� ������� ��������
            var listings = _context.Listings
                .OrderByDescending(l => l.PublishedAt)
                .Take(10)
                .ToList();

            var reviews = _context.Reviews
                .OrderByDescending(r => r.Rating)
                .Take(5)
                .ToList();

            return View(new HomeViewModel
            {
                Listings = listings,
                Reviews = reviews
            });
        }
    }
}

