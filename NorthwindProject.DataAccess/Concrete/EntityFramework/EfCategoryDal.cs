using NorthwindProject.Core.DataAccess.EntityFramework;
using NorthwindProject.DataAccess.Abstract;
using NorthwindProject.Entities.Concrete;

namespace NorthwindProject.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}
