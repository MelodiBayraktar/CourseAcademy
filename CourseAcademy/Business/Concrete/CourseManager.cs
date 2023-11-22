using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;

namespace Business.Concrete;

public class CourseManager :ICourseService
{
    ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public IResult Add(Course course)
    {
        //business codes
        if (course.Title.Length < 2) 
        { 
            return new ErrorResult(Messages.CourseNameInvalid);
        }
    
        _courseDal.Add(course);
        return new SuccessResult(Messages.CourseAdded);
    }

    public IResult Delete(Course course)
    {
        _courseDal.Delete(course);
        return new SuccessResult(Messages.CourseDeleted);
    }

    public IDataResult<List<Course>> GetAll()
    {
        if (DateTime.Now.Hour == 22)
        {
            return new ErrorDataResult<List<Course>>(Messages.MaintenanceTime);
        }

        return new SuccessDataResult<List<Course>>(_courseDal.GetAll(),Messages.CourseListed);
    }

    public IDataResult<List<Course>> GetAllByCategoryId(int id)
    {
        return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.CategoryId == id));
    }

    public IDataResult<Course> GetById(int courseId)
    {
        return new SuccessDataResult<Course>(_courseDal.Get(c => c.Id == courseId), Messages.CourseListed);
    }

    public IDataResult<List<CourseDetailDto>> GetCourseDetails()
    {
        //
        //if (DateTime.Now.Hour == 12)
        //{
        //    return new ErrorDataResult<List<CourseDetailDto>>(Messages.MaintenanceTime);
        //}

        return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails());
    }

    public IResult Update(Course course)
    {
        _courseDal.Update(course);
        return new SuccessResult(Messages.CourseUpdated);
    }
}