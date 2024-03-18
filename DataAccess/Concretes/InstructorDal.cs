using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;

    public InstructorDal()
    {
        _instructors = new List<Instructor>();
        _instructors.Add(new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Information = "Egitmen 1 (boss)" });
        _instructors.Add(new Instructor { Id = 2, FirstName = "Halit Eney", LastName = "Kalaycı", Information = "Eğitmen 2" });

    }

    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(Instructor instructor)
    {
        var updatedInstructor = _instructors.SingleOrDefault(e => e.Id == instructor.Id);

        updatedInstructor = instructor;

        Console.WriteLine(updatedInstructor.FirstName + " " + updatedInstructor.LastName + " isimli eğitmenin adı "
            + instructor.FirstName + " " + instructor.LastName + " başarı ile güncellendi.");
    }

    public void Delete(Instructor instructor)
    {
        _instructors.Remove(instructor);
        Console.WriteLine(instructor.FirstName + " " + instructor.LastName + " isimli eğitmen silindi.");
    }
}
