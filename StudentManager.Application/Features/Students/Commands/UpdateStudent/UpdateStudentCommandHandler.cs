using MediatR;
using StudentManager.Application.Interfaces;
using StudentManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Application.Features.Students.Commands.UpdateStudent
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;
        public UpdateStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var studentToUpdate = new Student
            {
                Id=request.Id,
                FullName=request.FullName,
                NationalCode  =request.NationalCode,
                BirthDate=request.BirthDate,
            };
            await _studentRepository.UpdateAsync(studentToUpdate, cancellationToken);
        }
    }
}
