using System.Threading.Tasks;
using Gandalf.Inc.Models.TokenAuth;
using Gandalf.Inc.Web.Controllers;
using Shouldly;
using Xunit;

namespace Gandalf.Inc.Web.Tests.Controllers
{
    public class HomeController_Tests: IncWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}