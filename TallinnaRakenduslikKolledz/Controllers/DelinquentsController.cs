﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TallinnaRakenduslikKolledz.Data;
using TallinnaRakenduslikKolledz.Models;

namespace TallinnaRakenduslikKolledz.Controllers
{
    public class DelinquentsController : Controller
    {
        private readonly SchoolContext _context;
        public DelinquentsController(SchoolContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Delinquents.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind
        ("ID, LastName, FirstName, isTeacherorStudent,ViolationDescription")] Delinquent delinquent)
        {
            if (ModelState.IsValid)
            {

                _context.Delinquents.Add(delinquent);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
                //return RedirectToAction(nameof("Index"));

            }
            return View(delinquent);
        }

        
        
    }
    
}
