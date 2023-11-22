using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract;

public interface IInstructorService
{
    IDataResult<List<Instructor>> GetAll();
    IDataResult<Instructor> GetById(int id);
    IResult Add(Instructor instructor);
    IResult Update(Instructor instructor);
    IResult Delete(Instructor instructor);
  
}