using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clothes.Models;

namespace Clothes.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ClothesMarketEntities clothesMarketEntities = new ClothesMarketEntities();

        public List<Product> FeaturedProducts(int n)
        {
            return clothesMarketEntities.Products.Where(p => p.specials == true).OrderByDescending(p => p.id).Take(n).ToList();
        }

        public Product find(int id)
        {
            return clothesMarketEntities.Products.Find(id);
        }

        public List<Product> LatestProducts(int n)
        {
            return clothesMarketEntities.Products.OrderByDescending(p => p.id).Take(n).ToList();
        }

        public List<Product> RelatedProducts(Product product, int n)
        {
            return clothesMarketEntities.Products.Where(p => p.categoryId == product.categoryId &&
            p.id != product.id).Take(n).ToList();
        }
    }
}