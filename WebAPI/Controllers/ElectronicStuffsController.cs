using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectronicStuffsController : ControllerBase
    {
        IElectronicStuffService _stuff;
        public ElectronicStuffsController(IElectronicStuffService stuff)
        {
            _stuff = stuff;
        }
        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var result = _stuff.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _stuff.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(ElectronicStuff stuff)
        {
            var result = _stuff.Add(stuff);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPost("delete")]
        public IActionResult Delete(ElectronicStuff stuff )
        {
            var result = _stuff.Delete(stuff);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPost("update")]
        public IActionResult Update(ElectronicStuff stuff)
        {
            var result = _stuff.Update(stuff);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPost("calculate")]
        public IActionResult Calculate(ElectronicStuff stuff)
        {
            var result = _stuff.Calculate(stuff);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
