using NorthwindProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindProject.Entities.Concrete;
using NorthwindProject.Core.DataAccess;

namespace NorthwindProject.DataAccess.Abstract
{
    public interface ICategoryDal :IEntityRepository<Category>
    {

    }
}
