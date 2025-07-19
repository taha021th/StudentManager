using StudentManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Application.Interfaces
{
    public interface IStudentRepository
    {
        Task<Student> GetByIdAsync(int id,CancellationToken cancellationToken);
        Task<List<Student>> GetAllAsync(CancellationToken cancellationToken);
        Task<Student> AddAsync(Student student,CancellationToken cancellationToken);
        Task UpdateAsync(Student student,CancellationToken cancellationToken);
        Task DeleteAsync(int id, CancellationToken cancellationToken);
    }
}
