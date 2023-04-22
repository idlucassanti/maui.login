using Santi.LoginApp.Models.Login;

namespace Santi.LoginApp.Interfaces.Services
{
    public interface ILoginService
    {
        Task<LoginResponse> RealizarLogin(LoginRequest loginRequest);
    }
}
