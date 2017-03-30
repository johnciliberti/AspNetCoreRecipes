using Microsoft.AspNetCore.Mvc.Rendering;
using Recipe05.Data;
using Recipe05.Models;
using Recipe05.Util;
using System.Collections.Generic;

namespace Recipe05.ViewModels
{
    public class GuitarBuilderViewModel
    {
        public GuitarBuilderViewModel()
        {
            // in a real app we would get the data via constructor injection
            PopulateFromInventory();
        }

        public Guitar Guitar { get; set; } = new Guitar();

        public IEnumerable<SelectListItem> BridePickupList { get; set; }
        public string SelectedBridgePickup { get; set; }

        public IEnumerable<SelectListItem> MiddlePickupList { get; set; }
        public string SelectedMiddlePickup { get; set; }

        public IEnumerable<SelectListItem> NeckPickupList { get; set; }
        public string SelectedNeckPickup { get; set; }

        public IEnumerable<SelectListItem> BodyList { get; set; }
        public string SelectedBody { get; set; }

        public IEnumerable<SelectListItem> StringsList { get; set; }
        public IEnumerable<string> SelectedStrings { get; set; }


        private void PopulateFromInventory()
        {
            Inventory = new Inventory();
            BodyList = SelectListItemAdapter.ConvertToSelectListItemCollection
                        (Inventory.GuitarBodies, s => s.Name);
            BridePickupList = SelectListItemAdapter.ConvertToSelectListItemCollection
                        (Inventory.GuitarPickups, s => s.Name);
            MiddlePickupList = SelectListItemAdapter.ConvertToSelectListItemCollection
                        (Inventory.GuitarPickups, s => s.Name);
            NeckPickupList = SelectListItemAdapter.ConvertToSelectListItemCollection
                        (Inventory.GuitarPickups, s => s.Name);
            StringsList = SelectListItemAdapter.ConvertToSelectListItemCollection
                        (Inventory.GuitarStrings, s => s.Name);
        }

        internal Inventory Inventory { get; private set; }
    }
}
