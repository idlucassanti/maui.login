using Santi.LoginApp.Interfaces.Services;
using Santi.LoginApp.Models.Login;

namespace Santi.LoginApp.ViewModels;

[ObservableObject]
public partial class MainViewModel
{
	private readonly ILoginService _loginService;

	[ObservableProperty]
	private string email;

	[ObservableProperty]
	private string password;

	public MainViewModel(ILoginService loginService)
	{
		_loginService = loginService;
	}

	[RelayCommand]
	public async Task Login()
	{
		var loginRequest = new LoginRequest(email, password);

		var result = await _loginService.RealizarLogin(loginRequest);

		if (!string.IsNullOrEmpty(result.Token))
		{
			// TODO: Security Storage - login novamente sem ter que passar pelo processo de login
		}
	}

	[RelayCommand]
	public async Task CriarConta()
	{
		await Shell.Current.GoToAsync(nameof(RegisterPage));
	}
}
