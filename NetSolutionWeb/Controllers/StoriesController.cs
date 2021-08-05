using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetSolutionWeb.Data;
using NetSolutionWeb.Models;

namespace NetSolutionWeb.Controllers
{
    [Authorize(Roles = "admin")]
    public class StoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public StoriesController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _environment = env;
        }

        // GET: Stories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stories.ToListAsync());
        }

        // GET: Stories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var story = await _context.Stories
                .FirstOrDefaultAsync(m => m.StoryID == id);
            if (story == null)
            {
                return NotFound();
            }

            return View(story);
        }

        // GET: Stories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StoryID,ClientName,TagLine,Industry,Features,FileUpload")] Story story)
        {
            using (var memoryStream = new MemoryStream())
            {
                await story.FileUpload.FormFile.CopyToAsync(memoryStream);

                string photoname = story.FileUpload.FormFile.FileName;
                story.ExtName = Path.GetExtension(photoname);
                if (!".jpg.jpeg.png.gif.bmp".Contains(story.ExtName.ToLower()))
                {
                    ModelState.AddModelError("FileUpload.FormFile", "Invalid Format of Image Given.");
                }
                else
                {
                    ModelState.Remove("ExtName");
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(story);
                await _context.SaveChangesAsync();
                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "stories");
                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }
                string filename = story.StoryID + story.ExtName;
                var filePath = Path.Combine(uploadsRootFolder, filename);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await story.FileUpload.FormFile.CopyToAsync(fileStream).ConfigureAwait(false);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(story);
        }

        // GET: Stories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var story = await _context.Stories.FindAsync(id);
            if (story == null)
            {
                return NotFound();
            }
            return View(story);
        }

        // POST: Stories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StoryID,ClientName,TagLine,Industry,Features,ExtName")] Story story)
        {
            if (id != story.StoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(story);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoryExists(story.StoryID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(story);
        }

        // GET: Stories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var story = await _context.Stories
                .FirstOrDefaultAsync(m => m.StoryID == id);
            if (story == null)
            {
                return NotFound();
            }

            return View(story);
        }

        // POST: Stories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var story = await _context.Stories.FindAsync(id);
            _context.Stories.Remove(story);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoryExists(int id)
        {
            return _context.Stories.Any(e => e.StoryID == id);
        }
    }
}
