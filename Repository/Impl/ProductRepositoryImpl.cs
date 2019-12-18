using System.Collections.Generic;
using DependencyInjection.Models;

namespace DependencyInjection.Repository.Impl {
    public class ProductRepositoryImpl : IProductRepository {
        private IModelStorage _storage;
        private string guid = System.Guid.NewGuid().ToString();

        public ProductRepositoryImpl(IModelStorage modelStorage){
            _storage = modelStorage;
            new List<Product>{
                new Product { Name = "Kajak", Price = 275M},
                new Product { Name = "Kamizelka", Price = 48.95M},
                new Product { Name = "Pilka nozna", Price = 19.50M}
            }.ForEach(AddProduct);
        }

        public IEnumerable<Product> Products => _storage.Items;

        public Product this[string name] => _storage[name];

        public void AddProduct(Product product) => _storage[product.Name] = product;

        public void DeleteProduct(Product product) => _storage.RemoveItem(product.Name);
        
        public override string ToString() {
            return guid; }
    }
}