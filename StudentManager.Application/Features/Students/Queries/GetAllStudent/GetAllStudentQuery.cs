using MediatR;
using StudentManager.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Application.Features.Students.Queries.GetAllStudent
{
    public class GetAllStudentQuery : IRequest<List<StudentDto>>
    {
    }
}
