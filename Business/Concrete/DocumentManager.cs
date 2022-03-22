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
    public class DocumentManager : IDocumentService
    {
        IDocumentRepository _documentRepository;

        public DocumentManager(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public async Task Add(Document document)
        {
            await _documentRepository.Add(document);
        }

        public async Task Delete(Document document)
        {
            await _documentRepository.Delete(document);
        }

        public async Task Update(Document document)
        {
            await _documentRepository.Update(document);
        }
    }
}
