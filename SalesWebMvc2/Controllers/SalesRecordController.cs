using Microsoft.AspNetCore.Mvc;
using SalesWebMvc2.Data;
using SalesWebMvc2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2.Controllers
{
    public class SalesRecordController : Controller
    {
        //Injeção de Dependencia.
        private readonly SalesRecordService _salesRecordService;

        //Construtor que injeta a dependencia.
        public SalesRecordController(SalesRecordService salesRecordService)
        {
            _salesRecordService = salesRecordService;
        }

        public IActionResult Index()
        {
            var list = _salesRecordService.FindAll();
            return View(list); 
        }
    }
}
