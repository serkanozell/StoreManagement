using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LoginInfoManager : ILoginInfoService
    {
        ILoginInfoRepository _loginInfoRepository;

        public LoginInfoManager(ILoginInfoRepository loginInfoRepository)
        {
            _loginInfoRepository = loginInfoRepository;
        }

        public async Task Add(LoginInfo loginInfo)
        {
            await _loginInfoRepository.Add(loginInfo);
        }

        public async Task Delete(LoginInfo loginInfo)
        {
            await _loginInfoRepository.Delete(loginInfo);
        }

        public async Task Update(LoginInfo loginInfo)
        {
            await _loginInfoRepository.Update(loginInfo);
        }
    }
}
