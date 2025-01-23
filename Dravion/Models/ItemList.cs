namespace Dravion.Models
{
    public class ItemList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SelectedVersion { get; set; }
        public Dictionary<string, List<MinecraftContent>> Items { get; set; }

        public ItemList()
        {
            Items = new Dictionary<string, List<MinecraftContent>>
            {
                ["mods"] = new List<MinecraftContent>(),
                ["plugins"] = new List<MinecraftContent>(),
                ["shaders"] = new List<MinecraftContent>(),
                ["resourcepacks"] = new List<MinecraftContent>(),
                ["worlds"] = new List<MinecraftContent>()
            };
        }
    }
}
