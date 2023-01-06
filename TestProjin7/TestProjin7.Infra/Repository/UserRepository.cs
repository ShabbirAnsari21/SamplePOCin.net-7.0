using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjin7.Domain;
using TestProjin7.Domain.Domains;
using TestProjin7.Infra.AppDbConttext;

namespace TestProjin7.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext= applicationDbContext;
        }
        public async Task<User> GetUserByEmailId(string emailId)
        {
           var user =  await _applicationDbContext.Users.Where(x => x.Name == emailId).FirstOrDefaultAsync();
            return user;
        }
    }
}
