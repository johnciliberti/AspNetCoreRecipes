using Chapter07.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using Chapter07.Web.Strings;

namespace Chapter07.Test.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexAction_ReturnsIndexView()
        {
            // Arrange
            var controller = new HomeController();
            var expected = HomeStrings.IndexView;

            // Act
            var result = controller.Index() as ViewResult;
            var actual = result.ViewName;

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
            var actual = result?.ViewData[HomeStrings.ViewDataMessageKey];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AboutAction_ReturnsAboutView()
        {
            // Arrange
            var controller = new HomeController();
            var expected = HomeStrings.AboutView;

            // Act
            var result = controller.About() as ViewResult;
            var actual = result?.ViewName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ContactAction_ReturnsContactView()
        {
            // Arrange
            var controller = new HomeController();
            var expected = HomeStrings.ContactView;

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
            var actual = result?.ViewData[HomeStrings.ViewDataMessageKey];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ErrorAction_ReturnsErrorView()
        {
            // Arrange
            var controller = new HomeController();
            var expected = HomeStrings.ErrorView;

            // Act
            var result = controller.Error() as ViewResult;
            var actual = result?.ViewName;

            // Assert
            Assert.Equal(expected, actual);
        }
    }

}
