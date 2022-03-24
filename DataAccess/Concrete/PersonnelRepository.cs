using DataAccess.Abstract;
using DataAccess.RepositoryPattern;
using Entities.Concrete;
using Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class PersonnelRepository : EfRepoBase<Personnel, StoreManagementDbContext>, IPersonnelRepository
    {
        public List<Role> GetClaims(Personnel personnel)
        {
            using (StoreManagementDbContext db = new StoreManagementDbContext())
            {
                var result = from role in db.Roles
                             join personnelRole in db.RolePersonnel
                             on role.RoleId equals personnelRole.RoleId
                             where personnelRole.PersonnelId == personnel.PersonnelId
                             select new Role { RoleId = role.RoleId, Description = role.Description };
                return result.ToList();
            }
        }
    }
}
