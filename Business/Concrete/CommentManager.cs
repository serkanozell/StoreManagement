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
    public class CommentManager : ICommentService
    {
        ICommentRepository _commentRepository;

        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task Add(Comment comment)
        {
            await _commentRepository.Add(comment);
        }

        public async Task Delete(Comment comment)
        {
            await _commentRepository.Delete(comment);
        }

        public async Task Update(Comment comment)
        {
            await _commentRepository.Update(comment);
        }
    }
}
