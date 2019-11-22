using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ===============================
// AUTHOR     : Sumathilatha Myla
// CREATE DATE     :11/20/2019
// PURPOSE     :User Repositary implemented by IEntityRepository.
// ===============================

namespace SubtypeCovariance
{
    public class UserRepository : IEntityRepository<User>
    {
        //public override Entity GetByID(Guid id)
        public  User GetByID(Guid id)
        {
            return new User(id);
        }
    }
}
