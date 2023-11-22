using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
         IInstructorService _instructorService;

         public InstructorsController(IInstructorService instructorService)
         {
             _instructorService = instructorService;
         }

         [HttpGet("getall")]
         public IActionResult GetAll()
         {
             var result = _instructorService.GetAll();
             if (result.Success)
             {
                 return Ok(result);
             }
             return BadRequest(result);

         }

         [HttpGet("getbyid")]
         public IActionResult GetById(int id)
         {
             var result = _instructorService.GetById(id);
             if (result.Success)
             {
                 return Ok(result);
             }

             return BadRequest(result);
         }

         [HttpPost("add")]
         public IActionResult Add(Instructor instructor)
         {
             var result = _instructorService.Add(instructor);
             if (result.Success)
             {
                 return Ok(result);
             }

             return BadRequest(result);
         }
         [HttpPut("update")]
         public IActionResult Update(Instructor instructor)
         {
             var result = _instructorService.Update(instructor);
             if (result.Success)
             {
                 return Ok(result);
             }

             return BadRequest(result);
         }
         
         [HttpDelete("delete")]
         public IActionResult Delete(Instructor instructor)
         {
             var result = _instructorService.Delete(instructor);
             if (result.Success)
             {
                 return Ok(result);
             }

             return BadRequest(result);
         }
    }
}
