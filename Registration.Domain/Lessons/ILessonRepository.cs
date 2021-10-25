using Registration.Domain.Lessons; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Domain.Lessons
{
    public interface ILessonRepository: IBaseRepository<Lesson>
    {
    }
}
