
using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace _27_FrontToBackSqlConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        //List<Slider> _sliders = new List<Slider>
        //{
        //    new Slider{Title="Title-1",Subtitle="Subtitle-1",Description="Gullerden qalmadi",Image="1-2-524x617.png",Order=3,IsDeleted=false},
        //    new Slider{Title="Title-2",Subtitle="Subtitle-2",Description="Mohtesem endirimler",Image="1-1-524x617.png",Order=1,IsDeleted=true},
        //    new Slider{Title="Title-3",Subtitle="Subtitle-3",Description="Guller manata",Image="red-rose-flowers-840x473.jpg", Order = 2,IsDeleted=false}
        //};



        public IActionResult Index()
        {
            //_context.AddRange(_sliders);
            //_context.SaveChanges();
            List<Slider> sliders = _context.Sliders.Where(s=>!s.IsDeleted)
                .OrderBy(s=>s.Order)
                .Take(2)
                .ToList();



            HomeVM homeVM = new()
            {
                Sliders = sliders
                
            };
            return View(homeVM);
        }

    }
}
