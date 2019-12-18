using System.Linq;
using DependencyInjection.Repository;

namespace DependencyInjection.Models {
    public class ProductTotalizer {
        public ProductTotalizer(IProductRepository repository) => Repository = repository;
        
        public IProductRepository Repository{ get; set; }

        public decimal Total => Repository.Products.Sum(p => p.Price);
    }
}