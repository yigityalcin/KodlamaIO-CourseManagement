using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> _courses;

    public CourseDal()
    {
        _courses = new List<Course>();
        _courses.Add(new Course { Id = 1, Name = "JavaScript", Description = "Yazılım Geliştirici Yetiştirme Kampı" });
        _courses.Add(new Course { Id = 2, Name = ".NET Senior", Description = "Senior Yazılım Geliştirici Yetiştirme Kampı" });
        _courses.Add(new Course { Id = 3, Name = "C# & Angular", Description = "2020 Yazılım Geliştirici Yetiştirme Kampı" });
        _courses.Add(new Course { Id = 4, Name = "C#", Description = "2024 Yazılım Geliştirici Yetiştirme Kampı" });
        _courses.Add(new Course { Id = 1, Name = "Java", Description = "2022 Yazılım Geliştirici Yetiştirme Kampı" });
        _courses.Add(new Course { Id = 1, Name = "Java & React", Description = "Yazılım Geliştirici Yetiştirme Kampı" });
        _courses.Add(new Course { Id = 1, Name = "Python & Selenium", Description = "2023 Yazılım Geliştirici Yetiştirme Kampı" });
    }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public void Update(Course course)
    {
        var updatedCourse = _courses.SingleOrDefault(e => e.Id == course.Id);

        updatedCourse = course;

        Console.WriteLine(updatedCourse.Name + " " + " isimli ders "
            + course.Name + " başarı ile güncellendi.");
    }

    public void Delete(Course course)
    {
        _courses.Remove(course);
        Console.WriteLine(course.Name + " " + "isimli ders silindi.");
    }
}
