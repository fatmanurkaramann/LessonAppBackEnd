using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class LessonTeacher:IEntity
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int TeacherId { get; set; }
    }
}
