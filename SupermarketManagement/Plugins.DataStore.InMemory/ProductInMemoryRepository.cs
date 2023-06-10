using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private HashSet<Product> products;
        private int lastProductId;

        public ProductInMemoryRepository()
        {
            lastProductId = 0;
            products = new HashSet<Product>(capacity: 2)
            {
                new Product { ProductId = GenerateNextProductId(), CategoryId = 1, Name = "Iced Tea", Quantity = 100, Price = 1.99 },
                new Product { ProductId = GenerateNextProductId(), CategoryId = 2, Name = "White Bread", Quantity = 300, Price = 1.50 },
            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }

            product.ProductId = GenerateNextProductId();
            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
            }
        }

        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(x => x.ProductId == productId);
        }

        public void DeleteProduct(int productId)
        {
            var productToDelete = GetProductById(productId);
            if (productToDelete != null)
            {
                products.Remove(productToDelete);
            }
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return products.Where(x => x.CategoryId == categoryId);
        }

        private int GenerateNextProductId()
        {
            lastProductId++;
            return lastProductId;
        }
    }
}

