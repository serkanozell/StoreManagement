using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILoginInfoService
    {
        public Task Add(LoginInfo loginInfo);
        public Task Update(LoginInfo loginInfo);
        public Task Delete(LoginInfo loginInfo);
    }
}
