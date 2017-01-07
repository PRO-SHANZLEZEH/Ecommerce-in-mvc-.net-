using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clothes.Models;

namespace Clothes.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private ClothesMarketEntities clothesMarketEntities = new ClothesMarketEntities();

        public Category find(int id)
        {
            return clothesMarketEntities.Categories.Find(id);
        }

        public List<Category> findAll()
        {
            return clothesMarketEntities.Categories.ToList();
        }
    }
}