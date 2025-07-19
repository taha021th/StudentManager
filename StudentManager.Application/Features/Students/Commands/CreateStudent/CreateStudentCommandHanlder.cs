using MediatR;
using StudentManager.Application.Interfaces;
using StudentManager.Domain.Entities;

namespace StudentManager.Application.Features.Students.Commands.CreateStudent
{
    public class CreateStudentCommandHanlder : IRequestHandler<CreateStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;
        public CreateStudentCommandHanlder(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<int> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student
            {
                FullName = request.FullName,
                NationalCode = request.NationalCode,
                BirthDate = request.BirthDate,
            };
            var createdStudent = await _studentRepository.AddAsync(student, cancellationToken);
            return createdStudent.Id;
        }
    }
}
