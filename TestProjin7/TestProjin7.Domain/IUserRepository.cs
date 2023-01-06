using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjin7.Domain.Domains;

namespace TestProjin7.Domain
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailId(string emailId)
    }
}
