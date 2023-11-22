

using Core.Entities;

namespace Entity.Concrete;

public class Course : IEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public Category? Category { get; set; }
    public Instructor? Instructor { get; set; }
}