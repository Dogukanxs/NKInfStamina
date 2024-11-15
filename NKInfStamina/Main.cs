using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKInfStamina
{
    public class Main : RocketPlugin
    {
        protected override void Load()
        {
            Logger.Log("NKInfStamina Loaded!", ConsoleColor.Blue);
            Logger.Log("Discord: discord.gg/wqggaXhPre | dogukanxs", ConsoleColor.Cyan);
            UnturnedPlayerEvents.OnPlayerUpdateStamina += UnturnedPlayerEvents_OnPlayerUpdateStamina;
        }

        private void UnturnedPlayerEvents_OnPlayerUpdateStamina(Rocket.Unturned.Player.UnturnedPlayer player, byte stamina)
        {
            if (player.Stamina >= 50)
            {
                return;
            }
            player.Player.life.serverModifyStamina(100f);
        }

        protected override void Unload()
        {
            Logger.Log("NKInfStamina Unloaded!", ConsoleColor.Blue);
            Logger.Log("Discord: discord.gg/wqggaXhPre | dogukanxs", ConsoleColor.Cyan);
            UnturnedPlayerEvents.OnPlayerUpdateStamina -= UnturnedPlayerEvents_OnPlayerUpdateStamina;
        }
    }
}
