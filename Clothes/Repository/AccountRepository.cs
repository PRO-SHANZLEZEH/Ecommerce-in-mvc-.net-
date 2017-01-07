using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clothes.Models;

namespace Clothes.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private ClothesMarketEntities clothesMarketEntities = new ClothesMarketEntities();

        public void creat(Account account)
        {
            clothesMarketEntities.Accounts.Add(account);
            clothesMarketEntities.SaveChanges();
        }

        public Account login(string username, string password)
        {
            try
            {

                return clothesMarketEntities.Accounts.Single(account => account.username.Equals(username) &&
                account.password.Equals(password));
            }
            catch
            {

                return null;
            }
        }
    }
}