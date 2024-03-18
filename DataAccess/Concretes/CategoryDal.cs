﻿using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;

    public CategoryDal()
    {
        _categories = new List<Category>();
        _categories.Add(new Category { Id = 1, Name = "Programlama"});

    }

    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public void Update(Category category)
    {
        var updatedCategory = _categories.SingleOrDefault(e => e.Id == category.Id);

        updatedCategory = category;

        Console.WriteLine(updatedCategory.Name + " " + " isimli kategori "
            + category.Name + " başarı ile güncellendi.");
    }

    public void Delete(Category category)
    {
        _categories.Remove(category);
        Console.WriteLine(category.Name + " " + "isimli kategori silindi.");
    }
}
