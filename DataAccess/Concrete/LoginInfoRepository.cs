using DataAccess.Abstract;
using DataAccess.RepositoryPattern;
using Entities.Concrete;
using Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class LoginInfoRepository : EfRepoBase<LoginInfo, StoreManagementDbContext>, ILoginInfoRepository
    {
    }
}
