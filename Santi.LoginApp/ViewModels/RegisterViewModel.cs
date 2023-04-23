using Santi.LoginApp.Interfaces.Services;
using Santi.LoginApp.Models.Register;

namespace Santi.LoginApp.ViewModels
{
    [ObservableObject]
    public partial class RegisterViewModel
    {
        private readonly IRegisterService _registerService;

        [ObservableProperty]
        string nomeCompleto;

        [ObservableProperty]
        string email;

        [ObservableProperty]
        string senha;

        public RegisterViewModel(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        [RelayCommand]
        public async Task Cadastrar()
        {
            var registerRequest = new RegisterRequest(nomeCompleto, email, senha);

            var result = await _registerService.CriarConta(registerRequest);

            if (result) await Shell.Current.GoToAsync("..");
        }
    }
}
