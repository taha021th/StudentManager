using MediatR;
using StudentManager.Application.Dtos;
using StudentManager.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Application.Features.Students.Queries.GetAllStudent
{
    public class GetStudentQueryHandler : IRequestHandler<GetAllStudentQuery, List<StudentDto>>
    {
        private readonly IStudentRepository _studentRepository;
        public GetStudentQueryHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<List<StudentDto>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentRepository.GetAllAsync(cancellationToken);
            return students.Select(s => new StudentDto
            {
                Id = s.Id,
                FullName = s.FullName,
                NationalCode = s.NationalCode,
                BirthDate = s.BirthDate,
            }).ToList();
        }
    }
}
