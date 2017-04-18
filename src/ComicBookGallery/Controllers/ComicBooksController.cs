using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        /* Updating our parameter to be nullable by adding a question mark after int. */
        /* Therefore MVC can successfully pass null for the id parameter if an id value isn't provided as part of the request */
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            /* Can place both ((int)id) and id.Value */
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            /* ViewBag is an object provided by MVC, that allows us to pass data from our controller to a view. */
            /* Capatilize the letter after the ViewBag. since we switching from using variables to properties, */
            /* we need to capatilize the first letter of each property name. */
            /* We can see that it is of type dynamic. */
            /* This allows us to define properties on the ViewBag object, */
            /* without having to modify a class as we normally have to do. */
            /* ViewBag is one of the few real world use cases for dynamic types in C#. */
            /*ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last great act of revenge! Even if Spider Man survives...<strong>will Peter Parker?</strong></p>";*/
            
            /* To comment out multiple lines, select the lines, hold down the ctrl + k following by c */
            /* To uncomment, select the lines, hold down ctrl + k following by u */
 
            return View(comicBook);
        }
    }
}