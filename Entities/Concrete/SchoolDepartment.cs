using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SchoolDepartment:IEntity
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public int DepartmentId { get; set; }
    }
}
