using Microsoft.AspNetCore.Identity;
using NetCore6_Book.Models;

namespace NetCore6_Book.Reponsitory
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel model);
        public Task<string> SignInAsync(SignInModel model);

    }
}
