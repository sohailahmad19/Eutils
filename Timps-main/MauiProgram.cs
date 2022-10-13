using TekTrackingCore.ViewModels;
using TekTrackingCore.Views;

namespace TekTrackingCore;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


		//Routing.RegisterRoute("dashboard", typeof(MainPage));
		//Routing.RegisterRoute("login", typeof(LoginPage));

		builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<LoginPage>();

        builder.Services.AddSingleton<MianPageViewModel>();
        builder.Services.AddSingleton<MainPage>();


        return builder.Build();
	}
}
