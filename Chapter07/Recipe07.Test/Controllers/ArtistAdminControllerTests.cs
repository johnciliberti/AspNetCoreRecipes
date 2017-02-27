using Xunit;
using Microsoft.AspNetCore.Mvc;
using Chapter07.Web.Controllers;
using Moq;
using AspNetCoreMvcRecipes.Shared.DataAccess;
using Chapter07.Web.ViewModels;
using System.Collections.Generic;
using System;
using Chapter07.Web.Strings;
using System.Data.SqlClient;


namespace Recipe07.Test.Controllers
{
    public class ArtistAdminControllerTests
    {
        #region List
        [Fact(DisplayName ="List Action Returns ActionResult with ViewName of List")]
        public void ListAction_ReturnsListView()
        {
            //arrange
           var controller = new ArtistAdminController(Mock.Of<IUnitOfWork>());

            var expected = "List";

            // Act
            var result = controller.List() as ViewResult;
            var actual = result?.ViewName;

            // Assert
            Assert.NotNull(result);
            Assert.IsType(typeof(ViewResult), result);
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "List Action ActionResult Model is of type ArtistListViewModel")]
        public void ListAction_PassesArtistListViewModel_ToListView_IsNotNull()
        {
            //arrange
            var controller = new ArtistAdminController(Mock.Of<IUnitOfWork>());

            //act
            var result = controller.List() as ViewResult;

            //assert
            Assert.NotNull(result.Model);
            Assert.IsType(typeof(ArtistListViewModel), result.Model);
        }

        

        [Fact(DisplayName ="List Action Artist List View has correct row count")]
        public void ListAction_PassesArtistListViewModel_ToListView_HasCorrectRowCount()
        {
            //arrange
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

            //act
            var result = controller.List() as ViewResult;
            var viewModel = result?.Model as ArtistListViewModel;
            var actual = viewModel?.RecordsFound;

            //assert
            Assert.NotNull(viewModel?.Artists);
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "List Action Artist List View Model Shows No Data message when empty")]
        public void ListAction_ReturnsEmptyNewArtistList_ToListView()
        {
            //arrange
            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.ArtistRepository.GetNewArtists(1))
                .Returns(new List<Artist> { });

            var controller = new ArtistAdminController(unitOfWorkMock.Object);
            var expected = ArtistAdminStrings.NoDataFound;

            //act
            var result = controller.List() as ViewResult;
            Assert.NotNull(result.Model);
            var viewModel = result?.Model as ArtistListViewModel;
            var actual = viewModel?.Message;

            //assert
            Assert.Empty(viewModel?.Artists);
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "List Action Redirect To Error Action When Back-end down")]
        public void ListAction_RedirectToErrorAction_WhenItCannotConnectToBackend()
        {
            var exception = new Mock<System.Data.Common.DbException>();
            //arrange
            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.ArtistRepository.GetNewArtists(1))
                .Throws(exception.Object);
            var controller = new ArtistAdminController(unitOfWorkMock.Object);
            var expected = "Error";
            //act
            var result = controller.List() as ViewResult;
            var actual = result?.ViewName;
            //assert

            Assert.Equal(expected, actual);
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
