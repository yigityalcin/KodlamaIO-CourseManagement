using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Category : BaseEntity<int>
{
    public string Name { get; set; }

    // Bir kategori birden çok kursa sahip olabilir.
    public virtual ICollection<Course> Courses { get; set; }
}
