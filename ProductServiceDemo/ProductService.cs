using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProductServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ProductService : IProductService
    {
       MangoProductAPIEntities mangoProductAPIEntities = new MangoProductAPIEntities();
        public void AddProduct(ProductContract productContract)
        {
            mangoProductAPIEntities.Products.Add(new Product
            {
                Name = productContract.Name,
                Price = productContract.Price,
                Description = productContract.Description,
                CategoryName = productContract.CategoryName,
                ImageUrl = productContract.ImageUrl
            });
            mangoProductAPIEntities.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var matchedProduct = mangoProductAPIEntities.Products.FirstOrDefault(p => p.ProductId == productId);
            if (matchedProduct != null)
            {
                mangoProductAPIEntities.Products.Remove(matchedProduct);
                mangoProductAPIEntities.SaveChanges();
            }
        }

        public ProductContract GetProduct(int ProductId)
        {
            var matchedProduct = mangoProductAPIEntities.Products.FirstOrDefault(p=> p.ProductId == ProductId);
            if(matchedProduct != null)
            {
                return new ProductContract
                {
                    ProductId = matchedProduct.ProductId,
                    Name = matchedProduct.Name,
                    CategoryName = matchedProduct.CategoryName,
                    Description = matchedProduct.Description,
                    Price = matchedProduct.Price,
                    ImageUrl = matchedProduct.ImageUrl
                };
            }
            else
            {
                return null;
            }
        }

        public List<ProductContract> GetProducts()
        {
           return mangoProductAPIEntities.Products.Select(p => new ProductContract
            {
                ProductId = p.ProductId,
                Name = p.Name,
                CategoryName = p.CategoryName,
                Description = p.Description,
                Price = p.Price,
                ImageUrl = p.ImageUrl
            }).ToList();
        }

        void IProductService.UpdateProduct(ProductContract productContract)
        {
            var existingProduct = mangoProductAPIEntities.Products.FirstOrDefault(p => p.ProductId == productContract.ProductId);
            if(existingProduct != null)
            {
                existingProduct.Name = productContract.Name;
                existingProduct.Description = productContract.Description;
                existingProduct.CategoryName = productContract.CategoryName;
                existingProduct.Price = productContract.Price;
                existingProduct.ImageUrl = productContract.ImageUrl;
                mangoProductAPIEntities.SaveChanges();
            }
        }
    }
}
