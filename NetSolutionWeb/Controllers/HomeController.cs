using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NetSolutionWeb.Data;
using NetSolutionWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetSolutionWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IWebHostEnvironment _environment;
        public HomeController(ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _environment = env;
        }



        public async Task<IActionResult> Index()
        {
            var testimonials = _context.Testimonials;
            ViewData["Testimonials"] = testimonials;
            return View(await _context.Stories.ToListAsync());
        }

        [Authorize]
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactUs([Bind("QuoteID,Name,EmailID,ContactNo,Budget,QuoteText")] Quote quote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(SuccessMessage));
            }
            return View(quote);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Apply([Bind("CareerID,Name,EmailID,ContactNo,FileUpload")] Career career)
        {
            using (var memoryStream = new MemoryStream())
            {
                await career.FileUpload.FormFile.CopyToAsync(memoryStream);

                string photoname = career.FileUpload.FormFile.FileName;
                career.ExtName = Path.GetExtension(photoname);
                if (!".pdf.doc.docx".Contains(career.ExtName.ToLower()))
                {
                    ModelState.AddModelError("FileUpload.FormFile", "PDF or Microsoft Word document Allowed.");
                }
                else
                {
                    ModelState.Remove("ExtName");
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(career);
                await _context.SaveChangesAsync();
                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "resume");
                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }
                string filename = career.CareerID + career.ExtName;
                var filePath = Path.Combine(uploadsRootFolder, filename);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await career.FileUpload.FormFile.CopyToAsync(fileStream).ConfigureAwait(false);
                }
                return RedirectToAction(nameof(SuccessApply));
            }
            return View(career);
        }

        public IActionResult SuccessMessage()
        {
            return View();
        }

        public IActionResult SuccessApply()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
