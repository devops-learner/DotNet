using NUnit.Framework;
using Shop.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Shop.IntegrationTests.Shop.Data
{
    [TestFixture]
    class DbContextTests
    {
        private ApplicationDbContext _dbcontext;

        [SetUp]
        void setup()
        {
            _dbcontext = new ApplicationDbContext(System.Configuration.ConfigurationManager.AppSettings["testdbconnection"]);
        }
         
        [Test]
        public void Adduser()
        {
            ;
        }
    }
}
