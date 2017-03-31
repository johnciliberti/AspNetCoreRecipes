using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcRecipes.Shared.DataAccess;
using Chapter07.Web.Controllers;
using Moq;
using Chapter07.Web.ViewModels;
using Chapter07.Web.Strings;

namespace Chapter07.Test.Controllers
{
    public class ArtistAdminControllerTests
    {
        #region List

        [Fact]
        public void ListAction_ReturnsListView()
        {
            // Arrange
            var controller = new ArtistAdminController(Mock.Of<IUnitOfWork>());
            var expected = "List";

            // Act
            var result = controller.List() as ViewResult;
            var actual = result?.ViewName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "List Action ActionResult Model is of type ArtistListViewModel")]
        public void ListAction_ReturnsNewArtistList_ToListView()
        {
            // Arrange
            var controller = new ArtistAdminController(Mock.Of<IUnitOfWork>());
            // Act
            var result = controller.List() as ViewResult;
            // Assert
            Assert.NotNull(result.Model);
            Assert.IsType(typeof(ArtistListViewModel), result.Model);

        }

        [Fact(DisplayName = "List Action Artist List View Model Shows No Data message when empty")]
        public void ListAction_ReturnsEmptyNewArtistList_ToListView()
        {
            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.ArtistRepository.GetNewArtists(1))
                         .Returns(new List<Artist> { });

            var controller = new ArtistAdminController(unitOfWorkMock.Object);
            var expected = ArtistAdminStrings.NoDataFound;

            // Act
            var result = controller.List() as ViewResult;
            Assert.NotNull(result.Model);
            var viewModel = result?.Model as ArtistListViewModel;
            var actual = viewModel?.Message;

            // Assert
            Assert.Empty(viewModel?.Artists);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ListAction_PassesArtistListViewModel_ToListView_HasCorrectRowCount()
        {
            // Arrange
            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.ArtistRepository.GetNewArtists(1))
                      .Returns(new List<Artist> {
                    new Artist{ CreateDate= new DateTime(2017,2,26),
                                 UserName="TestUser1",
                                 EmailAddress = "TestUser1@myonlineband.com",
                                 ArtistId = 1,
                                 WebSite = "http://foxnews.com"
                            }
              });

            var controller = new ArtistAdminController(unitOfWorkMock.Object);
            var expected = 1;

            // Act
            var result = controller.List() as ViewResult;
            var viewModel = result?.Model as ArtistListViewModel;
            var actual = viewModel?.RecordsFound;

            // Assert
            Assert.NotNull(viewModel?.Artists);
            Assert.Equal(expected, actual);

        }

        [Fact(DisplayName = "List Action Redirect To Error Action When Back-end down")]
        public void ListAction_ShowsErrorMessageWhenItCannotConnectToBackend()
        {
            var exception = new Mock<System.Data.Common.DbException>();
            // Arrange
            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.ArtistRepository.GetNewArtists(1))
                       .Throws(exception.Object);
            var controller = new ArtistAdminController(unitOfWorkMock.Object);
            var expected = "Error";

            // Act
            var result = controller.List() as ViewResult;
            var actual = result?.ViewName;

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ListAction_UnAuthorizedUserCannotAccess()
        {
            // Arrange

            // Act

            // Assert
            Assert.True(false);
        }

        #endregion

        #region Review
        #endregion

        #region DeleteConfirm
        #endregion

        #region DeleteCompleted
        #endregion

        #region DeleteFailed
        #endregion
    }

}
