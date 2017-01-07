using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clothes.Models;

namespace Clothes.Repository
{
    public interface IProductRepository
    {
        List<Product> LatestProducts(int n);
        List<Product> FeaturedProducts(int n);
        List<Product> RelatedProducts(Product product, int n);

        Product find(int id);
    }
}
