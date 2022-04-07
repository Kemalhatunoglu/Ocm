using Core.Utilities.Results;
using Ocm.Business.Abstract;
using Ocm.Business.Constants;
using Ocm.Business.Mappings.AutoMapper;
using Ocm.DataAccess.Abstract;
using Ocm.Entities.Concrete;
using Ocm.Entities.Dtos;
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
        public IResult Add(CategoryDto categoryDto)
        {
            var createModel = ObjectMapper.Mapper.Map<CategoryDto, Category>(categoryDto);
            _categoryDal.Add(createModel);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }

        public IResult Remove(int id)
        {
            var dataToBeDeleted = _categoryDal.Get(x => x.Id == id);

            if (dataToBeDeleted != null)
            {
                _categoryDal.Delete(dataToBeDeleted);
                return new SuccessResult(Messages.Success);
            }
            return new ErrorResult(Messages.Error);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.Success);
        }
        #endregion
    }
}
