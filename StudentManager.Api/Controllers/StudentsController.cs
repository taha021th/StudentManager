using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManager.Application.Features.Students.Commands.CreateStudent;
using StudentManager.Application.Features.Students.Commands.DeleteStudent;
using StudentManager.Application.Features.Students.Commands.UpdateStudent;
using StudentManager.Application.Features.Students.Queries.GetAllStudent;
using StudentManager.Application.Features.Students.Queries.GetByIdStudent;

namespace StudentManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _mediator.Send(new GetAllStudentQuery());
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = _mediator.Send(new GetByIdStudentQuery { Id=id });
            if (student==null) return NotFound();
            return Ok(student);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateStudentCommand command)
        {

            var studentId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = studentId }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id,[FromBody] UpdateStudentCommand command)
        {
            if (id!=command.Id) return BadRequest();
            await _mediator.Send(command);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteStudentCommand { Id=id });
            return NoContent();
        }
    }
}
