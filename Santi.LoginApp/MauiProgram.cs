using Santi.LoginApp.Interfaces.Services;
using Santi.LoginApp.Options;
using Santi.LoginApp.Services;

namespace Santi.LoginApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//builder.Services.Configure<Settings>(builder.Configuration.GetSection(nameof(Settings)));

		builder.Services.AddScoped<ILoginService, LoginService>();
		builder.Services.AddScoped<IRegisterService, RegisterService>();

        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<RegisterViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<RegisterPage>();

        return builder.Build();
	}
} 
