using Microsoft.AspNetCore.Mvc;
using SalesWebMvc2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2.Controllers
{
    public class SellersController : Controller
    {
        //Injeção de Dependencia.
        private readonly SellerService _sellerService;

        //Construtor que injeta a dependencia.
        public SellersController(SellerService sellerService)
        {
             _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
