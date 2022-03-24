using AutoMapper;
using Business.Abstract;
using Core.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class AuthController : ControllerBase
    {
        IAuthService _authService;
        IMapper _mapper;

        public AuthController(IAuthService authService, IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] PersonnelForLoginDto personnelForLoginDto)
        {
            var personnelToLogin = await _authService.Login(personnelForLoginDto);
            if (!personnelToLogin.Success)
            {
                return BadRequest(personnelToLogin.Message);
            }

            var result = _authService.CreateAccessToken(personnelToLogin.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("register")]
        [Authorize(Roles ="admin")]
        public async Task<IActionResult> Register([FromBody] PersonnelForRegisterDto personnelForRegisterDto)
        {
            var personnelExists = await _authService.UserExist(personnelForRegisterDto.UserName);
            if (!personnelExists.Success)
            {
                return BadRequest(personnelExists.Message);
            }

            var registerResult = await _authService.Register(personnelForRegisterDto, personnelForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);

        }
    }
}
