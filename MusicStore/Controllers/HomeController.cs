using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    

    public class HomeController : Controller
    {
        MusicStoreEntities storedB = new MusicStoreEntities();
        // GET: Home
        
        public ActionResult Index()
        {
            var albums = GetTopSellingAlbums(5);
            return View(albums);
        }

        private List<Album> GetTopSellingAlbums(int count)
        {
            return storedB.Albums.OrderByDescending(a => a.OrderDetails.Count()).Take(count).ToList();
        }
    }
}