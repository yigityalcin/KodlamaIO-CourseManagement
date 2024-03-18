using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface ICategoryDal
{
    void Add(Category category);
    List<Category> GetAll();
    void Update(Category category);
    void Delete(Category category);
}
