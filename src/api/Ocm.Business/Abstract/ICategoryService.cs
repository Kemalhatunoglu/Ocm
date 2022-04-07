using Core.Utilities.Results;
using Ocm.Entities.Concrete;
using Ocm.Entities.Dtos;
using System.Collections.Generic;

namespace Ocm.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
        IResult Add(CategoryDto categoryDto);
        IResult Update(Category category);
        IResult Remove(int id);
    }
}
