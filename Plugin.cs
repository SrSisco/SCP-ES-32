using System;
using Exiled.Events.Handlers;
using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;
using Exiled.API.Features;
namespace SCP_ES_32
{
    public class SCP_ES_32 : Plugin<Config>
    {
        public override string Name => "SCP-ES-32";
        public override string Author => "SrSisco";
        public override Version Version => new Version(2, 0, 0);

        public static SCP_ES_32 Instance;
        private EventHandlers _handlers;
        
        
        public override void OnEnabled()
        {
            Instance = this;
            _handlers = new EventHandlers();
            Server.RoundStarted += _handlers.OnRoundStarted;
            Server.RoundEnded += _handlers.OnRoundEnded;
            Log.Info("SCP-ES-32 has been enabled.");
            base.OnEnabled();

        }

        public override void OnDisabled()
        {
            Server.RoundStarted -= _handlers.OnRoundStarted;
            Server.RoundEnded -= _handlers.OnRoundEnded;
            _handlers = null;
            Instance = null;
            Log.Info("SCP-ES-32 has been disabled.");
            base.OnDisabled();
        }
    }
}