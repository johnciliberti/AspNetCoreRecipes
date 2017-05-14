using Recipe02.DataAccess.Repository;
using System;
using System.Linq;
using System.Web.UI;



namespace WebForms.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var repo = new MemoryGuitarRepository();
            var guitars = repo.GetAllGuitars().Where(m => m.Model.StartsWith("S"));
            FavoriteGuitarName.Text = guitars.FirstOrDefault()?.Model;
        }
    }
}