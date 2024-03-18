using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface IInstructorDal
{
    void Add(Instructor instructor);
    List<Instructor> GetAll();
    void Update(Instructor instructor);
    void Delete(Instructor instructor);
}
