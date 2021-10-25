using Registration.Domain.Lessons;
using Registration.Domain.Students; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Domain.Students
{
    public interface IStudentRepository: IBaseRepository<Student>
    {
    }
}
