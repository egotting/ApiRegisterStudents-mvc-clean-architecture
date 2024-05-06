using Crudv3.Models;
using Crudv3.Models.DTO.Student;
using crudv3.Services;
using crudv3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crudv3.Controllers;

[Route("v3")]
[ApiController]
public class StudentsController : ControllerBase
{
    //private readonly DBStudentContextModels _context;
    private readonly IStudentService _service;
    public StudentsController(IStudentService service /*,DBStudentContextModels context*/)
    {
        _service = service;
     //   _context = context;
    }


    [HttpGet]
    [Route("/student")]
    public IActionResult GetAll()
    {
        return Ok(_service?.GetAll());
    }

    [HttpGet]
    [Route("/student/{identidade}")]
    public IActionResult GetStudentById(string identidade)
    {
        return Ok(_service?.GetStudentById(identidade));
    }

    [HttpPost]
    [Route("/student")]
    public IActionResult SaveStudent([FromBody]StudentRequestDTO studentRequestDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        var result = _service.SaveStudent(studentRequestDto);
        return Ok(result); // N ENVIANDO OS VALORES PARA O BANCO
    }
    
    
    
    // Test
    //[HttpPost]
    //[Route("/test")]
    //public async Task<ActionResult<string>> PostTest([FromBody] testModel test)
    //{
    //    return Ok(test.Nome);
    //}
}

