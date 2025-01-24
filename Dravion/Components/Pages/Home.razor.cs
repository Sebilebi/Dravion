using Dravion.Models;

namespace Dravion.Components.Pages
{
    public partial class Home
    {
        private ItemList SelectedList { get; set; }
        public List<ItemList> ItemLists { get; set; } = HardcodedData.ItemLists; // Cargar datos hardcodeados en lugar de LocalStorage
        private string SelectedContentType { get; set; } = "mods";
        private string SelectedVersion { get; set; } = "";
        private bool isLoading = true; // Estado de carga

        protected override async Task OnInitializedAsync()
        {
            // Simula una carga de datos
            await Task.Delay(2000); // 2 segundos

            if (ItemLists == null || !ItemLists.Any())
            {
                isLoading = false;
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
