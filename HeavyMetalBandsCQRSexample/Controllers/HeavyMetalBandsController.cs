using System.Diagnostics;
using HeavyMetalBandsCQRSexample.Data.Queries.Band;
using HeavyMetalBandsCQRSexample.Models;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace HeavyMetalBandsCQRSexample.Controllers
{
    public class HeavyMetalBandsController : Controller
    {
        private readonly IMediator _mediator;


        public HeavyMetalBandsController(IMediator mediator)
        {

            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var bands = await _mediator.Send(new GetBandsQuery());
            return View(bands); // View expects List<ProductDto>
        }


        [HttpGet]
        public async Task<IActionResult> CreateForm()
        {
            var bands = await _mediator.Send(new GetBandsQuery());
            return View(bands); // View expects List<ProductDto>
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View(); // Will load Create.cshtml
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBandCommand command)
        {
            if (!ModelState.IsValid)
                return View(command);

            var id = await _mediator.Send(command);
            return RedirectToAction("Index");
        }



    }
}
