using Xunit;
using Microsoft.AspNetCore.Mvc;
using Chapter07.Web.Strings;
using Chapter07.Web.Controllers;

namespace Recipe07.Test.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexAction_ReturnsIndexView()
        {
            // Arrange
            var controller = new HomeController();
            var expected = "Index";

            // Act
            var result = controller.Index() as ViewResult;
            var actual = result?.ViewName;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AboutAction_ReturnsAboutView()
        {
            // Arrange
            var controller = new HomeController();
            var expected = "About";

            // Act
            var result = controller.About() as ViewResult;
            var actual = result?.ViewName;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AboutAction_ReturnsExpectedMessageInViewBag()
        {
            // Arrange
            var controller = new HomeController();
            var expected = HomeStrings.AboutMessage;

            // Act
            var result = controller.About() as ViewResult;
            var actual = result?.ViewData[HomeStrings.ViewDataMessage];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ContactAction_ReturnsContactView()
        {
            // Arrange
            var controller = new HomeController();
            var expected = "Contact";

            // Act
            var result = controller.Contact() as ViewResult;
            var actual = result?.ViewName;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ContactAction_ReturnsExpectedMessageInViewBag()
        {
            // Arrange
            var controller = new HomeController();
            var expected = HomeStrings.ContactMessage;

            // Act
            var result = controller.Contact() as ViewResult;
            var actual = result?.ViewData[HomeStrings.ViewDataMessage];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ErrorAction_ReturnsErrorView()
        {
            // Arrange
            var controller = new HomeController();
            var expected = "Error";

            // Act
            var result = controller.Error() as ViewResult;
            var actual = result?.ViewName;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
