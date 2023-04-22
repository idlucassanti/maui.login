using Santi.LoginApp.Interfaces.Services;
using Santi.LoginApp.Models.Login;

namespace Santi.LoginApp.Services
{
    public class LoginService : ILoginService
    {
        public async Task<LoginResponse> RealizarLogin(LoginRequest loginRequest)
        {
            var response = new LoginResponse();

            await Task.Delay(3000);

            return response;
        }
    }
}
