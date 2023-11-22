using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;

namespace Business.Abstract;

public interface ICourseService
{
    IDataResult<List<Course>> GetAll();
    IDataResult<List<Course>> GetAllByCategoryId(int id);
    IDataResult<List<CourseDetailDto>> GetCourseDetails();
    IDataResult<Course> GetById(int courseId);
    IResult Add(Course course);
    IResult Update(Course course);
    IResult Delete(Course course);
}