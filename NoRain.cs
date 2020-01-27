using GoodProLib.GUtils;
using Terraria.ModLoader;

namespace NoRain
{
	public class NoRain : Mod
	{
		public override void Load()
		{
			On.Terraria.Main.StartRain += Main_StartRain;
		}

		public override void Unload()
		{
			On.Terraria.Main.StartRain -= Main_StartRain;
		}

		private void Main_StartRain(On.Terraria.Main.orig_StartRain orig)
		{
			ChatUtils.Chat("Rain skipped", true, default);
		}
	}
}