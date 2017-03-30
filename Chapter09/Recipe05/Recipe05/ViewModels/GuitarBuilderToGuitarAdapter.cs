using Recipe05.Data;
using Recipe05.Models;
using System.Linq;

namespace Recipe05.ViewModels
{
    public class GuitarBuilderToGuitarAdapter
    {
        public Guitar BuildGuitar(GuitarBuilderViewModel viewModel)
        {
            if (viewModel == null) return null;

            var guitar = new Guitar()
            {
                Name = viewModel.Guitar.Name,
                BridgePickup = SelectPickUp(viewModel.Inventory, viewModel.SelectedBridgePickup),
                MiddlePickup = SelectPickUp(viewModel.Inventory, viewModel.SelectedMiddlePickup),
                NeckPickup = SelectPickUp(viewModel.Inventory, viewModel.SelectedNeckPickup),
                Body = viewModel.Inventory?.GuitarBodies?.FirstOrDefault(a => a.Name == viewModel.SelectedBody),
                Strings = (from gs in viewModel.Inventory.GuitarStrings
                           where viewModel.SelectedStrings.Contains(gs.Name)
                           select gs).ToList()
            };
            return guitar;
        }

        private GuitarPickup SelectPickUp(Inventory inventory, string pickupName)
        {
            if (string.IsNullOrEmpty(pickupName)) return null;

            return inventory?.GuitarPickups?.FirstOrDefault(a => a.Name == pickupName);
        }
    }
}
