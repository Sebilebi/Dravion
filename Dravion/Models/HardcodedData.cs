namespace Dravion.Models
{
    public class HardcodedData
    {
        public static List<MinecraftContent> AllItems = new List<MinecraftContent>
        {
            new MinecraftContent
            {
                Id = 1,
                Title = "OptiFine",
                Author = "sp614x",
                Versions = new List<string> { "1.21.1", "1.20.1", "1.19.4", "1.18.2", "1.17.1", "1.16.5" },
                Downloads = "100000000",
                Summary = "OptiFine is a Minecraft optimization mod.",
                ThumbnailUrl = "https://example.com/optifine.png",
                Type = "mods"
            },
            new MinecraftContent
            {
                Id = 2,
                Title = "Biomes O' Plenty",
                Author = "Forstride",
                Versions = new List<string> { "1.20.1", "1.19.4", "1.18.2", "1.17.1", "1.16.5" },
                Downloads = "50000000",
                Summary = "Adds new biomes to Minecraft.",
                ThumbnailUrl = "https://example.com/biomesoplenty.png",
                Type = "mods"
            },
            new MinecraftContent
            {
                Id = 3,
                Title = "JourneyMap",
                Author = "techbrew",
                Versions = new List<string> { "1.21.1", "1.20.1", "1.19.4", "1.18.2", "1.17.1", "1.16.5" },
                Downloads = "75000000",
                Summary = "Real-time mapping in-game or in a web browser as you explore.",
                ThumbnailUrl = "https://example.com/journeymap.png",
                Type = "mods"
            },
            new MinecraftContent
            {
                Id = 4,
                Title = "Essentials",
                Author = "EssentialsX Team",
                Versions = new List<string> { "1.21.1", "1.20.1", "1.19.4", "1.18.2", "1.17.1", "1.16.5" },
                Downloads = "80000000",
                Summary = "Essential commands and features for Bukkit servers.",
                ThumbnailUrl = "https://example.com/essentials.png",
                Type = "plugins"
            },
            new MinecraftContent
            {
                Id = 5,
                Title = "WorldEdit",
                Author = "EngineHub",
                Versions = new List<string> { "1.21.1", "1.20.1", "1.19.4", "1.18.2", "1.17.1", "1.16.5" },
                Downloads = "70000000",
                Summary = "In-game map editor for Bukkit servers.",
                ThumbnailUrl = "https://example.com/worldedit.png",
                Type = "plugins"
            },
            new MinecraftContent
            {
                Id = 6,
                Title = "SEUS (Sonic Ether's Unbelievable Shaders)",
                Author = "Sonic Ether",
                Versions = new List<string> { "1.20.1", "1.19.4", "1.18.2", "1.17.1", "1.16.5" },
                Downloads = "30000000",
                Summary = "Adds beautiful shaders to Minecraft.",
                ThumbnailUrl = "https://example.com/seus.png",
                Type = "shaders"
            },
            new MinecraftContent
            {
                Id = 7,
                Title = "BSL Shaders",
                Author = "CaptTatsu",
                Versions = new List<string> { "1.21.1", "1.20.1", "1.19.4", "1.18.2", "1.17.1", "1.16.5" },
                Downloads = "25000000",
                Summary = "A beautiful, customizable shader pack for Minecraft.",
                ThumbnailUrl = "https://example.com/bsl.png",
                Type = "shaders"
            },
            new MinecraftContent
            {
                Id = 8,
                Title = "Faithful 32x32",
                Author = "Faithful Team",
                Versions = new List<string> { "1.21.1", "1.20.1", "1.19.4", "1.18.2", "1.17.1", "1.16.5" },
                Downloads = "60000000",
                Summary = "The original Faithful 32x32 resource pack.",
                ThumbnailUrl = "https://example.com/faithful.png",
                Type = "resourcepacks"
            },
            new MinecraftContent
            {
                Id = 9,
                Title = "Modern HD Resource Pack",
                Author = "mikeyto1o",
                Versions = new List<string> { "1.20.1", "1.19.4", "1.18.2", "1.17.1", "1.16.5" },
                Downloads = "40000000",
                Summary = "A modern, high-definition resource pack for Minecraft.",
                ThumbnailUrl = "https://example.com/modernhd.png",
                Type = "resourcepacks"
            },
            new MinecraftContent
            {
                Id = 10,
                Title = "The Skyblock Island",
                Author = "Noobcrew",
                Versions = new List<string> { "1.21.1", "1.20.1", "1.19.4", "1.18.2", "1.17.1", "1.16.5" },
                Downloads = "20000000",
                Summary = "The classic Skyblock challenge map.",
                ThumbnailUrl = "https://example.com/skyblock.png",
                Type = "worlds"
            },
            new MinecraftContent
            {
                Id = 11,
                Title = "City of Newisle",
                Author = "Minecraft Build Team",
                Versions = new List<string> { "1.20.1", "1.19.4", "1.18.2" },
                Downloads = "15000000",
                Summary = "A massive, detailed city world for exploration.",
                ThumbnailUrl = "https://example.com/newisle.png",
                Type = "worlds"
            }
        };

        public static List<ItemList> ItemLists = new List<ItemList>
        {
            new ItemList
            {
                Id = 1,
                Name = "Vanilla+ Modpack",
                SelectedVersion = "1.20.1",
                Items = new Dictionary<string, List<MinecraftContent>>
                {
                    ["mods"] = new List<MinecraftContent> { AllItems[0], AllItems[1], AllItems[2] },
                    ["plugins"] = new List<MinecraftContent>(),
                    ["shaders"] = new List<MinecraftContent> { AllItems[6] },
                    ["resourcepacks"] = new List<MinecraftContent> { AllItems[7] },
                    ["worlds"] = new List<MinecraftContent>()
                }
            },
            new ItemList
            {
                Id = 2,
                Name = "Ultimate Server Setup",
                SelectedVersion = "1.19.4",
                Items = new Dictionary<string, List<MinecraftContent>>
                {
                    ["mods"] = new List<MinecraftContent>(),
                    ["plugins"] = new List<MinecraftContent> { AllItems[3], AllItems[4] },
                    ["shaders"] = new List<MinecraftContent>(),
                    ["resourcepacks"] = new List<MinecraftContent>(),
                    ["worlds"] = new List<MinecraftContent> { AllItems[9] }
                }
            },
            new ItemList
            {
                Id = 3,
                Name = "Beautiful Minecraft",
                SelectedVersion = "1.18.2",
                Items = new Dictionary<string, List<MinecraftContent>>
                {
                    ["mods"] = new List<MinecraftContent> { AllItems[0] },
                    ["plugins"] = new List<MinecraftContent>(),
                    ["shaders"] = new List<MinecraftContent> { AllItems[5], AllItems[6] },
                    ["resourcepacks"] = new List<MinecraftContent> { AllItems[8] },
                    ["worlds"] = new List<MinecraftContent> { AllItems[10] }
                }
            }
        };
    }
}
