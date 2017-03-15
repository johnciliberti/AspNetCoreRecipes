using AspNetCoreMvcRecipes.Shared.DataAccess;
using System.Collections.Generic;

namespace Recipe06.Models
{
    public class InlineEditingArtistSkillListModel
    {
        public int SelectedRow { get; set; }
        public IEnumerable<ArtistSkill> ArtistSkillList { get; set; }
        public bool IsSelected(ArtistSkill item)
        {
            if (item == null)
                return false;
            return item.ArtistTalentId == SelectedRow;
        }

    }
}
