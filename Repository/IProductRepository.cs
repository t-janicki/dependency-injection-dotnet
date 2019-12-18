using System.Collections.Generic;
using DependencyInjection.Models;

namespace DependencyInjection.Repository {
    public interface IProductRepository {
        
        IEnumerable<Product> Products{ get; }
        Product this[string name]{ get; }

        void AddProduct(Product product);

        void DeleteProduct(Product product);
    }
}