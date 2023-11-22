using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public IResult Add(Category category)
    {
        _categoryDal.Add(category);
        return new SuccessResult(Messages.CategoryAdded);
    }

    public IResult Delete(Category category)
    {
        _categoryDal.Delete(category);
        return new SuccessResult(Messages.CategoryDeleted);
    }

    public IDataResult<List<Category>> GetAll()
    {
        if (DateTime.Now.Hour == 11)
        {
            return new ErrorDataResult<List<Category>>(Messages.MaintenanceTime);
        }
        return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoryListed);
    }
       
    public IDataResult<Category> GetById(int categoryId)
    {
        return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == categoryId)); 
    }

    public IResult Update(Category category)
    {
        _categoryDal.Update(category);
        return new SuccessResult(Messages.CategoryUpdated);
    }


}