using Core.Utilities.Results;
using Ocm.Entities.Concrete;
using System.Collections.Generic;

namespace Ocm.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
    }
}
