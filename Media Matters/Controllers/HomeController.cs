using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Media_Matters.Models;

namespace Media_Matters.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBookRepo br;
        private readonly IAlbumRepo ar;
        private readonly IGameRepo gr;
        public HomeController(IBookRepo bookRepo, IAlbumRepo albumRepo, IGameRepo gameRepo)
        {
            br = bookRepo;
            ar = albumRepo;
            gr = gameRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Albums()
        {
            return View(ar.GetAlbums());
        }
        public IActionResult Books()
        {
            return View(br.GetBooks());
        }
        public IActionResult BoardGames()
        {
            return View(gr.GetBoardGames());
        }
    }
}