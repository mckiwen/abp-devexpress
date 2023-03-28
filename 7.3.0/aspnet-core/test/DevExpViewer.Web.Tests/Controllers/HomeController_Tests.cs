using System.Threading.Tasks;
using DevExpViewer.Models.TokenAuth;
using DevExpViewer.Web.Controllers;
using Shouldly;
using Xunit;

namespace DevExpViewer.Web.Tests.Controllers
{
    public class HomeController_Tests: DevExpViewerWebTestBase
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