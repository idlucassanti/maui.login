using Santi.LoginApp.Models.Register;

namespace Santi.LoginApp.Interfaces.Services
{
    public interface IRegisterService
    {
        Task<bool> CriarConta(RegisterRequest registerRequest);
    }
}
