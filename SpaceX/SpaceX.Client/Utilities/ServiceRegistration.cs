﻿using Microsoft.Extensions.DependencyInjection;
using SpaceX.Services.Main.Pdf;
using SpaceX.Services.Contracts;
using DinkToPdf.Contracts;
using DinkToPdf;

namespace SpaceX.Client.Utilities
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<IGetDataService, GetDataService>();
            services.AddScoped<IPdfCreatorService, PdfCreatorService>();
            services.AddScoped<ITemplateGenerator, TemplateGenerator>();
            services.AddScoped<IDisplayDataService, DisplayDataService>();
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

            return services;
        }
    }
}