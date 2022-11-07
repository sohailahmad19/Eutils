﻿using TekTrackingCore.Framework;
using TekTrackingCore.ViewModels;
using TekTrackingCore.Views;
using TekTrackingCore.Services;
using TekTrackingCore.Sample.Services;
using TekTrackingCore.Sample.Helpers;
using Syncfusion.Maui.ListView.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace TekTrackingCore;

public static class MauiProgram
{
    public static void UseResolver(this IServiceProvider sp)
    {
        ServiceResolver.RegisterServiceProvider(sp);
    }
    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .ConfigureSyncfusionCore()
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
		builder.Services.AddSingleton<BriefingViewModel>();
        builder.Services.AddSingleton<Briefing>();

        builder.Services.AddSingleton<StaticListItemViewModel>();
        //builder.Services.AddSingleton<StaticListItemPage>();

        builder.Services.AddSingleton<JSONWebService>();
        builder.Services.AddSingleton<DatabaseSyncService>();

        //builder.Services.AddSingleton<AccordionViewModel>();
        builder.Services.AddSingleton<ExpandableView>();




        builder.Services.AddSingleton<IHttpsClientHandlerService, HttpsClientHandlerService>();

        builder.Services.AddSingleton<DataService>();
        builder.Services.AddSingleton<CompanyTreeViewBuilder>();
        builder.Services.AddTransient<CompanyPage>();
  

        MauiApp app = builder.Build();
        app.Services.UseResolver();
      


        return app;
    }

    public static void SetMainDashboardPage()
    {
        App.Current.MainPage = new AppShell();


    }
}

