using NorthwindProject.Entities.Concrete;
using System.Collections.Generic;

namespace NorthwindProject.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
