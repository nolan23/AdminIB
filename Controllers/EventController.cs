using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdminIB.Models;

namespace AdminIB.Controllers
{
    public class EventController : Controller
    {
        private readonly RequestContext _context;

        public EventController(RequestContext context)
        {
            _context = context;
        }

        // GET: Event
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });
            }
            ViewBag.Username = HttpContext.Session.GetString("Username");
            return View(await _context.Event.ToListAsync());
        }

        // GET: Event/Details/5
        public async Task<IActionResult> Details(int? id)
        {
             if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });
            }
            ViewBag.Username = HttpContext.Session.GetString("Username");
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        public async Task<IActionResult> Detail()
        {
            IEnumerable<Event> events = null;
            // // https://localhost:5001/api/requestevent
            // using (var client = new HttpClient())
            // {
            //     client.BaseAddress = new Uri("https://localhost:5001/");
            //     //HTTP GET
            //     client.DefaultRequestHeaders.Accept.Clear();
            //     client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //     client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            //     ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => certificate.Issuer == "CN=localhost";
            //     HttpResponseMessage response = await client.GetAsync("api/requestevent");
            //     if (response.IsSuccessStatusCode)
            //     {
            //         events = await response.Content.ReadAsAsync<List<Event>>();
            //     }
            //     else //web api sent error response 
            //     {
            //         //log response status here..

            //         events = Enumerable.Empty<Event>();

            //         ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            //     }
            // }
            return View(events);
        }

        // GET: Event/Create
        public IActionResult Create()
        {
             if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });
            }
            ViewBag.Username = HttpContext.Session.GetString("Username");
            return View();
        }

        // POST: Event/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NamaEvent,StartDate,EndDate,Description,Penyelenggara,Keterangan")] Event @event)
        {
             if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });
            }
            ViewBag.Username = HttpContext.Session.GetString("Username");
            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Event/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
             if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });
            }
            ViewBag.Username = HttpContext.Session.GetString("Username");
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NamaEvent,StartDate,EndDate,Description,Penyelenggara,Keterangan")] Event @event)
        {
             if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });
            }
            ViewBag.Username = HttpContext.Session.GetString("Username");
            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                    https://localhost:5001/api/requestevent
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Event/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
             if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });
            }
            ViewBag.Username = HttpContext.Session.GetString("Username");
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
             if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });
            }
            ViewBag.Username = HttpContext.Session.GetString("Username");
            var @event = await _context.Event.FindAsync(id);
            _context.Event.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.Id == id);
        }
    }
}
