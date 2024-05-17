using crudv3.Exceptions;
using Crudv3.Models;
using Crudv3.Models.DTO.Student;
using crudv3.Repository.interfaces;
using crudv3.Services;
using crudv3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crudv3.Controllers;

[ApiController]
[Route("api")]
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
        return Ok(_service.GetStudentById(identidade));
    }

    [HttpPost]
    [Route("/student")]
    public IActionResult SaveStudent([FromBody] StudentRequestDTO newStudent)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(newStudent);
        }

        var result = _service.SaveStudent(newStudent);
        return Ok(result);
    }


    [HttpDelete]
    [Route("/student/{identidade}")]
    public IActionResult DeleteStudent(string identidade)
    {
        _service.DeleteStudentById(identidade);
        return NoContent();
    }

    [HttpPatch]
    [Route("student/{identidade}")]
    public IActionResult UpdateStudent(string identidade, [FromBody] UpdateNameStudentDTO updateNameDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(updateNameDto);
        }

        var result = _service.UpdateNameStudent(identidade, updateNameDto);
        return Ok(result);
    }
}