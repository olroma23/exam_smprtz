using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Exam_3_2.Model;
using Exam_3_2.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Exam_3_2.Controllers
{
    public class GoodsController: Controller
    {
        private readonly GoodsService _goodsService;

        public GoodsController(GoodsService goodsService)
        {
            _goodsService = goodsService;
        }

        // GET
        //public IActionResult Index()
        //{

        //}

        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(GoodsModel productModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _goodsService.CreateGoods(productModel);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(productModel);
        //}
    }
}
