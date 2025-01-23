using Dravion.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.JSInterop;

namespace Dravion.Components.Pages
{
    public partial class Home
    {
        private ItemList SelectedList { get; set; }
        private List<ItemList> ItemLists { get; set; } = new List<ItemList>();
        private string SelectedContentType { get; set; } = "mods";
        private string SelectedVersion { get; set; } = "";

        protected override async Task OnInitializedAsync()
        {
            // Cargar datos hardcodeados en lugar de LocalStorage
            ItemLists = HardcodedData.ItemLists;
            if (ItemLists.Count > 0)
            {
                SelectedList = ItemLists[0];
            }
        }

        private bool IsItemAdded(MinecraftContent item)
        {
            return SelectedList?.Items[SelectedContentType].Any(i => i.Id == item.Id) ?? false;
        }

        private bool IsItemBlocked(MinecraftContent item)
        {
            return !string.IsNullOrEmpty(SelectedVersion) && !item.Versions.Contains(SelectedVersion);
        }

    }
}
