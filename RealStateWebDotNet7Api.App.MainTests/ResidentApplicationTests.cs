using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealStateWebDotNet7Api.App.DTO;
using RealStateWebDotNet7Api.App.Interface;
using RealStateWebDotNet7Api.App.Main;
using RealStateWebDotNet7Api.App.MainTests;
using RealStateWebDotNet7Api.CrossApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateWebDotNet7Api.App.Main.Tests
{
    [TestClass()]
    public class ResidentApplicationTests
    {

        private static WebApplicationFactory<Program> _factory = null;
        private static IServiceScopeFactory _scopeFactory;

        [ClassInitialize]
        public static void Initialize(TestContext _)
        {
            //var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", true, true).AddEnvironmentVariables();
            //_configuration = builder.Build();

            ////var startup = new Startup();
            //var services = new ServiceCollection();
            ////Startup.configureServices(services);
            //_scopeFactory = services.BuildServiceProvider().GetService<IServiceScopeFactory>();

            _factory = new CustomWebAppFactory();
            _scopeFactory = _factory.Services.GetRequiredService<IServiceScopeFactory>();


        }
        

        [TestMethod()]
        public void InsertTest()
        {
            using var scope = _scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetService<IResidentApplication>();

            

            var resident = new ResidentsDTO() { };
            var result = context.Insert(resident);

            Assert.IsTrue(result.IsSuccess);
            Assert.Equals(result.Message, ConstantsCustom.MSG_SUCCESS_INSERT);
        }
    }
}