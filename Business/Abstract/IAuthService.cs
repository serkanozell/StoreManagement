using Core.Results;
using Core.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        Task<IDataResult<Personnel>> Register(PersonnelForRegisterDto userForRegisterDto, string password);
        Task<IDataResult<Personnel>> Login(PersonnelForLoginDto personnelForLoginDto);
        Task<IResult> UserExist(string userName);
        IDataResult<AccessToken> CreateAccessToken(Personnel user);
    }
}
