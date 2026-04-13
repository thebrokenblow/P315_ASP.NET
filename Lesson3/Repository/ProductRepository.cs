using Lesson3.Model;

namespace Lesson3.Repository;

public class ProductRepository
{
    private readonly List<Product> _products = [];
    private int _nextId = 1;

    public ProductRepository()
    {
        _products =
        [
            new()
            {
                Id = _nextId++,
                Name = "Ноутбук",
                Description = "Мощный игровой ноутбук с RTX 4060",
                Price = 1500.99m,
                Quantity = 10,
                Category = "Электроника"
            },
            new()
            {
                Id = _nextId++,
                Name = "Смартфон",
                Description = "Флагманский смартфон с отличной камерой",
                Price = 999.99m,
                Quantity = 25,
                Category = "Электроника"
            },
            new()
            {
                Id = _nextId++,
                Name = "Наушники",
                Description = "Беспроводные наушники с шумоподавлением",
                Price = 199.99m,
                Quantity = 50,
                Category = "Аксессуары"
            },
            new()
            {
                Id = _nextId++,
                Name = "Книга",
                Description = "Интересная книга по программированию",
                Price = 49.99m,
                Quantity = 100,
                Category = "Книги"
            }
        ];
    }

    public List<Product> Get()
    {
        return _products;
    }

    public Product GetById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }

    public Product Add(Product product)
    {
        product.Id = _nextId++;

        _products.Add(product);

        return product;
    }
}