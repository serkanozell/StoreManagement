using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis.Extensions.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        IAssetService _assetService;
        IRedisCacheClient _redisCacheClient;

        public AssetController(IAssetService assetService, IRedisCacheClient redisCacheClient)
        {
            _assetService = assetService;
            _redisCacheClient = redisCacheClient;
        }

        [HttpPost("addasset")]
        public async Task<IActionResult> Add(Asset asset)
        {
            await _assetService.Add(asset);
            return Ok();
        }

        [HttpPost("deleteasset")]
        public async Task<IActionResult> Delete(Asset asset)
        {
            await _assetService.Delete(asset);
            return Ok();
        }

        [HttpPost("updateasset")]
        public async Task<IActionResult> Update(Asset asset)
        {
            await _assetService.Update(asset);
            return Ok();

        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _assetService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbyassetid")]
        public async Task<IActionResult> GetById(int assetId)
        {
            var result = await _assetService.GetById(assetId);
            return Ok(result);
        }
    }
}
