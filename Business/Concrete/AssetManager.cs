using Business.Abstract;
using Core.CrossCuttingConcern.Caching;
using DataAccess.Abstract;
using Entities.Concrete;
using Newtonsoft.Json;
using StackExchange.Redis.Extensions.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AssetManager : IAssetService
    {
        IAssetRepository _assetRepository;
        ICacheManager _cacheManager;
        IRedisCacheClient _redisCacheClient;
        private readonly static string key = "getallassets";

        public AssetManager(IAssetRepository assetRepository, IRedisCacheClient redisCacheClient, ICacheManager cacheManager)
        {
            _assetRepository = assetRepository;
            _redisCacheClient = redisCacheClient;
            _cacheManager = cacheManager;
        }

        public async Task Add(Asset asset)
        {
            await _assetRepository.Add(asset);
        }

        public async Task Delete(Asset asset)
        {
            await _assetRepository.Delete(asset);
        }

        public async Task<List<Asset>> GetAll()
        {
            if (_cacheManager.IsAdd(key))
            {
                var json =await _redisCacheClient.Db0.Database.StringGetAsync(key);
                var end = JsonConvert.DeserializeObject<List<Asset>>(json);
                return end;
            }
            var result = new List<Asset>(await _assetRepository.GetAll());
            var jsonData =await _redisCacheClient.Db0.AddAsync(key,await _assetRepository.GetAll(), DateTime.Now.AddMinutes(5));
            _redisCacheClient.Serializer.Serialize(jsonData);
            //var result = await _assetRepository.GetAll();
            return result;
        }

        public async Task<Asset> GetByBarcode(string barcodeNumber)
        {
            return await _assetRepository.GetAssetByBarcode(barcodeNumber);
        }

        public async Task<Asset> GetById(int assetId)
        {
            return await _assetRepository.Get(a => a.AssetId == assetId);
        }

        public async Task Update(Asset asset)
        {
            await _assetRepository.Update(asset);
        }
    }
}
