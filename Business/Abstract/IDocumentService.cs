using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDocumentService
    {
        public Task Add(Document document);
        public Task Update(Document document);
        public Task Delete(Document document);
    }
}
