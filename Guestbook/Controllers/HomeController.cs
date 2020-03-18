using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Guestbook.Models;
using Guestbook.ViewModels;
using Microsoft.Extensions.Configuration;


namespace Guestbook.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await GetGuestBooks());
        }

        [HttpPost]
        public async Task<IActionResult> Index(string Name, string Mail)
        {
            var list = new List<GusetBookViewModel>();
            if (!string.IsNullOrEmpty(Name)) 
                list = await GetGuestBooksByName(Name);
            if (!string.IsNullOrEmpty(Mail))
                list = await GetGuestBooksByMail(Mail);
            return View(list);
        }
       
        [HttpPost]
        public async Task<IActionResult> Create(GusetBookViewModel user)
        {
            /*db.Users.Add(user);
            await db.SaveChangesAsync();*/
            await AddGuestBook(user);
            
            return RedirectToAction("Index");
        }

        public async Task<List<GusetBookViewModel>> GetGuestBooksByMail(string mail)
        {
            var ret = await db.Users.Where(x => x.Mail == mail).Select(x => new GusetBookViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Mail = x.Mail,
                Message = x.Message,
                DateAdded = x.DateAdded
            }).ToListAsync();
            return ret;
        }
        
        public async Task<List<GusetBookViewModel>> GetGuestBooksByName(string name)
        {
            var ret = await db.Users.Where(x => x.Name == name).Select(x => new GusetBookViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Mail = x.Mail,
                Message = x.Message,
                DateAdded = x.DateAdded
            }).ToListAsync();
            return ret;
        }

        public async Task AddGuestBook(GusetBookViewModel model)
        {
            var ret = new GuestbookEntry()
            {
                Name = model.Name,
                Mail = model.Mail,
                DateAdded = DateTime.Now,
                Message = model.Message
            };

            db.Users.Add(ret);
            await db.SaveChangesAsync();
        }

        public async Task<IActionResult> Delete(int id)
        {
            await DeleteGB(id);
            return Redirect("/Home/Index");
        }

        public async Task DeleteGB(int id)
        {
            var ret = await db.Users.FirstOrDefaultAsync(x => x.Id == id);
            db.Users.Remove(ret);
            await db.SaveChangesAsync();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var ret = await GetGuestBooksById(id);
            return View(ret);
        }

        [HttpPost]
        
        public async Task<IActionResult> Edit(GusetBookViewModel model)
        {
            var gb = await db.Users.SingleOrDefaultAsync(x => x.Id == model.Id);
            
            gb.Name = model.Name;
            gb.Mail = model.Mail;
            gb.DateAdded = DateTime.Now;
            gb.Message = model.Message;
            
            db.Users.Update(gb);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<GusetBookViewModel> GetGuestBooksById(int id)
        {
            var ret = await db.Users.Where(x => x.Id == id).Select(x => new GusetBookViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Mail = x.Mail,
                Message = x.Message,
                DateAdded = x.DateAdded
            }).FirstOrDefaultAsync();
            return ret;
        }

        public async Task<List<GusetBookViewModel>> GetGuestBooks()
        {
            var ret = await db.Users.Select(x => new GusetBookViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Mail = x.Mail,
                Message = x.Message,
                DateAdded = x.DateAdded
            }).ToListAsync();
            return ret;
        }
       
        
    }
    
    
}