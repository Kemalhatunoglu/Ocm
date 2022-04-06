using Core.Utilities.Results;
using Ocm.Business.Abstract;
using Ocm.Business.Constants;
using Ocm.DataAccess.Abstract;
using Ocm.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Ocm.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        #region Fields
        private ICategoryDal _categoryDal;
        #endregion

        #region Ctor
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        #endregion

        #region Methods
        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }

        public IResult Remove(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.Success);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.Success);
        }
        #endregion

    }
}
