using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.AuthDefinition.Helper
{

    public class CustomUserStore : IUserStore<Users<int>>
    {
        private readonly List<IdentityUser<int>> _users;

        public CustomUserStore()
        {
            _users = new List<IdentityUser<int>>();
        }

        public Task<IdentityResult> CreateAsync(IdentityUser<int> user, CancellationToken cancellationToken)
        {
            _users.Add(user);

            return Task.FromResult(IdentityResult.Success);
        }

        public Task<IdentityUser<int>> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return Task.FromResult(_users.SingleOrDefault(u => u.NormalizedUserName == normalizedUserName));
        }

        /// more methods
    } 
}
