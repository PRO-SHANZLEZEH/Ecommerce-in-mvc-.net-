using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clothes.Models;

namespace Clothes.Repository
{
    public class OrdersRepository : IOrdersRepository
    {
        private ClothesMarketEntities clothesMarketEntities = new ClothesMarketEntities();

        public int creat(Order order)
        {
            this.clothesMarketEntities.Orders.Add( order);
            this.clothesMarketEntities.SaveChanges();
            return order.id;
        }
    }
}