using Business.Abstract;
using Business.Messages;
using Core.Results;
using Core.Security.Hashing;
using Core.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IPersonnelService _personnelService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IPersonnelService personnelService, ITokenHelper tokenHelper)
        {
            _personnelService = personnelService;
            _tokenHelper = tokenHelper;
        }

        public async Task<IDataResult<Personnel>> Register(PersonnelForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var personnel = new Personnel
            {
                UserName = userForRegisterDto.UserName,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                MasterId = userForRegisterDto.MasterId,
                CompanyId = userForRegisterDto.CompanyId,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
            };
            await _personnelService.Add(personnel);
            return new SuccessDataResult<Personnel>(personnel, Message.PersonnelRegistered);
        }

        public async Task<IDataResult<Personnel>> Login(PersonnelForLoginDto personnelForLoginDto)
        {
            var personnelToCheck = await _personnelService.GetByUserName(personnelForLoginDto.UserName);
            if (personnelToCheck == null)
            {
                return new ErrorDataResult<Personnel>(Message.PersonnelNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(personnelForLoginDto.Password, personnelToCheck.PasswordHash, personnelToCheck.PasswordSalt))
            {
                return new ErrorDataResult<Personnel>(Message.PasswordError);
            }
            return new SuccessDataResult<Personnel>(personnelToCheck, Message.LoginSuccessfull);
        }

        public IDataResult<AccessToken> CreateAccessToken(Personnel personnel)
        {
            var claims = _personnelService.GetClaims(personnel);
            var accessToken = _tokenHelper.CreateToken(personnel, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Message.TokenCreated);
        }

        public async Task<IResult> UserExist(string userName)
        {
            if (await _personnelService.GetByUserName(userName) != null)
            {
                return new ErrorResult(Message.PersonnelExist);
            }
            return new SuccessResult();
        }
    }
}
