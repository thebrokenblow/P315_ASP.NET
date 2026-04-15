using Lesson3.Models;

namespace Lesson3.Repositories;

public class ProductRepository1
{
    public Guid Id { get; set; }

    public ProductRepository1()
    {
        Id = Guid.NewGuid();
    }
}