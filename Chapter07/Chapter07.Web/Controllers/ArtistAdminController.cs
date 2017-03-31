using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcRecipes.Shared.DataAccess;
using Chapter07.Web.ViewModels;
using System.Data.SqlClient;
using System.Data.Common;
using Chapter07.Web.Strings;

namespace Chapter07.Web.Controllers
{
    public class ArtistAdminController : Controller
    {

        private IUnitOfWork _DataAccessLayer;

        public ArtistAdminController(IUnitOfWork dataAccessLayer)
        {
            _DataAccessLayer = dataAccessLayer;
        }

        public IActionResult List()
        {
            var model = new ArtistListViewModel();
            try
            {
                model.Artists = _DataAccessLayer?.ArtistRepository?.GetNewArtists(1);
                var nInt = model?.Artists?.Count;
                model.RecordsFound = nInt ?? 0;
                if(model.RecordsFound>0)
                {
                    model.Message = string.Format("{0} Records found", model.RecordsFound);
                }
                else
                {
                    model.Message = ArtistAdminStrings.NoDataFound;
                }
                
            }
            catch(DbException dbE)
            {
                model.Message = dbE.Message;
                return View("Error", model);
            }
            return View("List", model);
        }

        public IActionResult Review()
        {
            return View("Review");
        }

        public IActionResult DeleteConfirm()
        {
            return View("DeleteConfirm");
        }

        public IActionResult DeleteCompleted()
        {
            return View("DeleteCompleted");
        }

        public IActionResult DeleteFailed()
        {
            return View("DeleteFailed");
        }
    }
}
