using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealStateWebDotNet7Api.App.DTO;
using RealStateWebDotNet7Api.App.Interface;

namespace RealStateWebDotNet7Api.Services.WebApi.Controllers.v1
{
    //[Route("api/[controller]/[action]")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    //http resouces for .net
    [ApiController]
    [ApiVersion("1.0")]
    public class ResidentsController
        //Inherits controller base as well
        : Controller
    {
        private readonly IResidentApplication _residentApplication;

        public ResidentsController(IResidentApplication residentApplication)
        {
            _residentApplication = residentApplication;
        }

        [HttpPost]
        //[HttpGet("{customerId}")]
        public IActionResult Insert([FromBody] ResidentsDTO resident)
        {
            if (resident == null) return BadRequest();
            var response = _residentApplication.Insert(resident);
            if (response.IsSuccess) return Ok(response);

            return BadRequest(response.Message);
        }


        [HttpGet]
        //Will produce another uri segment
        //[HttpGet("GetAllPagination")]
        //[HttpGet("{customerId}")]
        public IActionResult GetAllPagination([FromQuery] int pageNum , int pageSize)
        {
          var response = _residentApplication.GetAllPaginated(pageNum, pageSize);
            if (response.IsSuccess) return Ok();

            return BadRequest(response.Message);
        }



    }
}
