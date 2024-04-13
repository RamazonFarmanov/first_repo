﻿using Microsoft.Extensions.Logging;
using Shell_App.Models.ViewModels;

namespace Shell_App
{
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
            builder.Services.AddSingleton<UserRepository>();
            builder.Services.AddTransient<AccountManagementPage>();
            /*#if DEBUG
                        builder.Logging.AddDebug();
            #endif*/
            return builder.Build();
        }
    }
}