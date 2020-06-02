using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
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
			Chat("Rain skipped");
		}

		public static void Chat(string message)
		{
			if (Main.netMode == NetmodeID.SinglePlayer)
				Main.NewText(message);
			else
				NetMessage.BroadcastChatMessage(NetworkText.FromLiteral(message), Color.White);
		}
	}
}