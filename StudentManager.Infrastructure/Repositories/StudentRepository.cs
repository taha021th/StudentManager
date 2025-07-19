using Microsoft.EntityFrameworkCore;
using StudentManager.Application.Interfaces;
using StudentManager.Domain.Entities;
using StudentManager.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context=context;
        }
        public async Task<Student> AddAsync(Student student, CancellationToken cancellationToken)
        {
            await _context.Students.AddAsync(student, cancellationToken);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            var student = await _context.Students.FindAsync(id,cancellationToken);
            if (student !=null) {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }

        public async Task<List<Student>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _context.Students.AsNoTracking().ToListAsync(cancellationToken);
        }

        public async Task<Student> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            var getStudent= await _context.Students.FindAsync(id,cancellationToken);
            return getStudent;
        }

        public async Task UpdateAsync(Student student, CancellationToken cancellationToken)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
