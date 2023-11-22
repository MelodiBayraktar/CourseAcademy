using Core.Entities;


namespace Entity.Concrete;

public class Instructor : IEntity
{
    public int Id { get; set; }
    public string Name  { get; set; }
    public List<Course>? Courses { get; set; }
}