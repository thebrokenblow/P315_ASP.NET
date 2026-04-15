using Lesson3.Models;

namespace Lesson3.Repositories;

public class ProductRepository2
{
    public Guid Id { get; set; }

    public ProductRepository2()
    {
        Id = Guid.NewGuid();
    }
}