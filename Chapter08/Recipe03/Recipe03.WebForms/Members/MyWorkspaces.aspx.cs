using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recipe03.WebForms.Members
{
    public partial class MyWorkspaces : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            // in order to simplify this example we are hard coding a user name
            var id = 1784;
            using (var unitOfWork = new UnitOfWork())
            {
                var model = unitOfWork.CollaborationSpaceRepository.GetCollaborationSpacesForArtist(id);

                if (list.Count > 0)
                {
                    ProjectsRepeater.DataSource = list;
                    ProjectsRepeater.DataBind();
                }
                else
                {
                    noWorkspaces.Visible = true;
                }
            }

        }

    }
}