using System.IO;
using WyvernGTAG_Plugin;

namespace WyvernPluginExample
{
    public class Mod : PluginModule
    {
        public override string Name { get; set; } = "Debug File Plugin";
        public override string ToolTip { get; set; } = "Writes to useless files in your Gorilla Tag folder.";
        public override bool IsEnabled { get; set; } = false;

        public override void onUpdate()
        {
            File.AppendAllText("WyvernPlugin-out.txt", "onUpdate\n");
        }

        public override void onEnable()
        {
            File.AppendAllText("WyvernPlugin-out.txt", "onEnable\n");
        }

        public override void onDisable()
        {
            File.AppendAllText("WyvernPlugin-out.txt", "onDisable\n");
        }

        public override void onGUI()
        {
            File.AppendAllText("WyvernPlugin-out.txt", "onGUI\n");
        }
    }
}
