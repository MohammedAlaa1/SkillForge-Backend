using SkillForge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillForge.Application.Interfaces
{
    public interface IEnrollmentRepository
    {
        Task<Enrollment> GetByIdAsync(Guid id);
        Task AddAsync(Enrollment enrollment);
    }
}
