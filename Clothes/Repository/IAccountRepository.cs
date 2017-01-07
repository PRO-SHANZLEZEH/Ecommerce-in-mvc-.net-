using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clothes.Models;

namespace Clothes.Repository
{
    public interface IAccountRepository
    {
              void creat (Account account);
        Account login(string username, string password);
    }
}
