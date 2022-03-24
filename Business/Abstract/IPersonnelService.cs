using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonnelService
    {
        Task<IResult> Add(Personnel personnel);
        Task<IResult> Update(Personnel personnel);
        Task<IResult> Delete(Personnel personnel);
        List<Role> GetClaims(Personnel personnel);
        Task<Personnel> GetByUserName(string userName);
    }
}
