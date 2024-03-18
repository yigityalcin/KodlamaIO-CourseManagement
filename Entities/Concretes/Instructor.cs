using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Instructor : BaseEntity<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Information { get; set; }

    // Bir eğitmen birden çok kursa sahip olabilir.
    public virtual ICollection<Course> Courses { get; set; }
}
