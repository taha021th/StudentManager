using MediatR;
using StudentManager.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Application.Features.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;
        public DeleteStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository=studentRepository;
        }

        public async Task Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            await _studentRepository.DeleteAsync(request.Id, cancellationToken);
        }
    }
}
