﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Areas.Identity.Data;
using Project.Data;
using Project.Models;

[assembly: HostingStartup(typeof(Project.Areas.Identity.IdentityHostingStartup))]
namespace Project.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ProjectContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ProjectContextConnection")));

            });
        }
    }
}