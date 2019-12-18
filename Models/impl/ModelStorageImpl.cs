using System.Collections.Generic;

namespace DependencyInjection.Models.impl {
    public class ModelStorageImpl : IModelStorage {
        private Dictionary<string, Product> items = new Dictionary<string, Product>();

        public Product this[string key]{
            get{ return items[key]; }
            set{ items[key] = value; }
        }

        public IEnumerable<Product> Items => items.Values;
        public bool ContainsKey(string key) => items.ContainsKey(key);
        public void RemoveItem(string key) => items.Remove(key);
    }
}