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
    public class CoursesController : ControllerBase
    {
         ICourseService _courseService;

         public CoursesController(ICourseService courseService)
         {
             _courseService = courseService;
         }

         [HttpGet("getall")]
         public IActionResult GetAll()
         {
             var result = _courseService.GetAll();
             if (result.Success)
             {
                 return Ok(result);
             }
             return BadRequest(result);

         }

         [HttpGet("getbyid")]
         public IActionResult GetById(int id)
         {
             var result = _courseService.GetById(id);
             if (result.Success)
             {
                 return Ok(result);
             }

             return BadRequest(result);
         }

         [HttpPost("add")]
         public IActionResult Add(Course course)
         {
             var result = _courseService.Add(course);
             if (result.Success)
             {
                 return Ok(result);
             }

             return BadRequest(result);
         }
         [HttpPut("update")]
         public IActionResult Update(Course course)
         {
             var result = _courseService.Update(course);
             if (result.Success)
             {
                 return Ok(result);
             }

             return BadRequest(result);
         }
         
         [HttpDelete("delete")]
         public IActionResult Delete(Course course)
         {
             var result = _courseService.Delete(course);
             if (result.Success)
             {
                 return Ok(result);
             }

             return BadRequest(result);
         }
    }
}
