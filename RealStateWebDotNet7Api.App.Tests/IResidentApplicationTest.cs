using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace RealStateWebDotNet7Api.App.Tests
{
    [TestClass]
    public class IResidentApplicationTest

    {

        public static IConfiguration _configuration;
        public static IServiceScopeFactory _scopeFactory;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {

        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
