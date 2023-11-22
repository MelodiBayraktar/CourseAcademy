// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;


    //CourseTest();
    //CategoryTest();
    //InstructorTest();

    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    Category  category= new Category { Name = "Veri Analiz" };
    var result = categoryManager.Add(category);
    //Category category = categoryManager.GetById(3).Data;
    //var result = categoryManager.Delete(category);
    if (result.Success == true)
    {
        Console.WriteLine(result.Message);
    }
    else
    {
        Console.WriteLine(result.Message);
    }

 void InstructorTest()
{
    InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());
    var result = instructorManager.GetAll();
    if (result.Success == true)
    {
        foreach (var instructor in result.Data)
        {
            Console.WriteLine(instructor.Name);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}
 void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    var result = categoryManager.GetAll();
    if (result.Success == true)
    {
        foreach (var category in result.Data)
        {
            Console.WriteLine(category.Name);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}
void CourseTest()
{
    CourseManager courseManager = new CourseManager(new EfCourseDal());

    var result = courseManager.GetCourseDetails(); //GetAll() -> çağırılırsa datalar gelecek
    if (result.Success==true)
    {
        foreach (var course in result.Data)
        {
            Console.WriteLine(course.Title + "/" + course.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
   
}