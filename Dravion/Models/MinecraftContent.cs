namespace Dravion.Models
{
    public class MinecraftContent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public List<string> Versions { get; set; }
        public string Downloads { get; set; }
        public string Summary { get; set; }
        public string ThumbnailUrl { get; set; }
        public ItemType Type { get; set; }

        public enum ItemType
        {
            Mods,
            Plugins,
            Shaders,
            ResourcePacks,
            Worlds
        }
    }
}
