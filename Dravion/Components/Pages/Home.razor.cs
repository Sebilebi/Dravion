﻿using Dravion.Models;

namespace Dravion.Components.Pages
{
    public partial class Home
    {
        private ItemList SelectedList { get; set; }
        public List<ItemList> ItemLists { get; set; } = HardcodedData.ItemLists; // Cargar datos hardcodeados en lugar de LocalStorage
        private string SelectedContentType { get; set; } = "mods";
        private string SelectedVersion { get; set; } = "";
        private bool isLoading = true; // Estado de carga
        private string searchTerm = string.Empty; // Almacena el término de búsqueda

        protected override async Task OnInitializedAsync()
        {
            // Simula una carga de datos
            await Task.Delay(2000); // 2 segundos

            if (ItemLists == null || !ItemLists.Any())
            {
                isLoading = false;
            }

            // Selecciona la primera lista por defecto
            if (ItemLists.Any())
            {
                SelectedList = ItemLists[0];
            }
        }

        private List<MinecraftContent> FilterItems(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return HardcodedData.AllItems; // Si no hay término de búsqueda, devuelve todos los elementos
            }

            // Filtra los elementos que coincidan con el término de búsqueda (ignorando mayúsculas/minúsculas)
            return HardcodedData.AllItems
                .Where(item => item.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        private bool IsItemAdded(MinecraftContent item)
        {
            return SelectedList?.Items[SelectedContentType].Any(i => i.Id == item.Id) ?? false;
        }

        private bool IsItemBlocked(MinecraftContent item)
        {
            return !string.IsNullOrEmpty(SelectedVersion) && !item.Versions.Contains(SelectedVersion);
        }

        private void ToggleItem(MinecraftContent item)
        {
            if (SelectedList == null)
            {
                return;
            }

            var itemList = SelectedList.Items[SelectedContentType];

            if (itemList.Any(i => i.Id == item.Id))
            {
                // Si el elemento ya está en la lista, lo eliminamos
                itemList.RemoveAll(i => i.Id == item.Id);
            }
            else
            {
                // Si el elemento no está en la lista, lo añadimos
                itemList.Add(item);
            }
        }
    }
}
