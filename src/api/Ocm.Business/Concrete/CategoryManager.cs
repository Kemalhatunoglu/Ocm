using Core.Utilities.Results;
using Ocm.Business.Abstract;
using Ocm.DataAccess.Abstract;
using Ocm.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Ocm.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }
    }
}
