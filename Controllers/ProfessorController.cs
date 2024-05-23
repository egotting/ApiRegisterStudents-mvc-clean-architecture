using crudv3.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Crudv3.Controllers;

[ApiController]
[Route("api")]
public class ProfessorController : ControllerBase
{
    private readonly IProfessorService _service;

    public ProfessorController(IProfessorService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("/professor")]
    public IActionResult GetProfessor()
    {
        return Ok(_service.GetAll());
    }
}