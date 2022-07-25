using AdditionApp.service;
using AdditionAppModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdditionApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionController : ControllerBase
    {
        private readonly IFindService _findService;

        public AdditionController(IFindService findService)
        {
            _findService = findService;
        }

        [HttpPost]
        public IActionResult FindAddition(NumberModel model)
        {
            double result = _findService.FindAddition(model);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult FindSubtraction(NumberModel model)
        {
         double result = _findService.FindSubtraction(model);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult FindMultiplication(NumberModel model)
        {
            double result = _findService.FindMultiplication(model);
            return Ok(result);
        }





    }
}
