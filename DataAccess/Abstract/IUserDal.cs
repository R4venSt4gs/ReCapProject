using System.Collections.Generic;
using Core.DataAccess;
using Core.Entities.Concrete;
using System;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
