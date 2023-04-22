using Moq;
using Santi.LoginApp.Interfaces.Services;
using Santi.LoginApp.Models.Login;
using Santi.LoginApp.ViewModels;

namespace Santi.LoginApp.Tests;

public class UnitTest1
{
	[Fact]
	public async Task DeveValidarDadosDoLogin()
	{
		var serviceMock = new Mock<ILoginService>();
		serviceMock.Setup(x => x.RealizarLogin(It.IsAny<LoginRequest>())).ReturnsAsync(It.IsAny<LoginResponse>());

		var mainViewModel = new MainViewModel(serviceMock.Object);

		await mainViewModel.Login();

		serviceMock.Verify(x => x.RealizarLogin(It.IsAny<LoginRequest>()), Times.Once);
	}
}
