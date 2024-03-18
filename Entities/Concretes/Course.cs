using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Course : BaseEntity<int>
{
    public string Name { get; set; }
    public string Description { get; set; }

    // Bir kurs bir eğitmene ait olabilir.
    public int InstructorId { get; set; }
    public virtual Instructor Instructor { get; set; }

    // Bir kurs sadece bir kategoriye ait olabilir.
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}
