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
    public class PageManager : IPageService
    {
        IPageRepository _pageRepository;

        public PageManager(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }

        public async Task Add(Page page)
        {
            await _pageRepository.Add(page);
        }

        public async Task Delete(Page page)
        {
            await _pageRepository.Delete(page);
        }

        public async Task Update(Page page)
        {
            await _pageRepository.Update(page);
        }
    }
}
