using MediatR;
using StudentManager.Application.Dtos;
using StudentManager.Application.Interfaces;
using StudentManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Application.Features.Students.Queries.GetByIdStudent
{
    public class GetByIdStudentQueryHandler : IRequestHandler<GetByIdStudentQuery, StudentDto>
    {
        private readonly IStudentRepository _studentRepository;
        public GetByIdStudentQueryHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<StudentDto> Handle(GetByIdStudentQuery request, CancellationToken cancellationToken)
        {
            var getStudent = await _studentRepository.GetByIdAsync(request.Id, cancellationToken);
            if (getStudent==null) return null;


            return new StudentDto
            {
                Id = getStudent.Id,
                FullName = getStudent.FullName,
                NationalCode = getStudent.NationalCode,
                BirthDate = getStudent.BirthDate
            };

        }
    }
}
