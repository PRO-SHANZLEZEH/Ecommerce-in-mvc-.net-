using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clothes.Models;

namespace Clothes.Repository
{
    public class OrdersDetailRepository : IOrdersDetailRepository
    {
        private ClothesMarketEntities clothesMarketEntities = new ClothesMarketEntities();

        public void creat(OrdersDetail orderDetail)
        {
           this.clothesMarketEntities.OrdersDetails.Add(orderDetail);
            this.clothesMarketEntities.SaveChanges();
        }
    }
}