using Exiled.API.Features;
using Exiled.API.Interfaces;
using Exiled.Loader;
using System;
using ServerEvent = Exiled.Events.Handlers.Server;
namespace SCP_ES_32
{
    public class Plugin : Plugin<Config>
    {
        private EventHandlers EventHandler;
        public override string Name => "SCP-ES-32";
        public override string Author => "SrSisco#9981";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            EventHandler = new EventHandlers(this);

            ServerEvent.RoundStarted += EventHandler.OnRoundStarted;
            base.OnEnabled();

        }

        public override void OnDisabled()
        {
            ServerEvent.RoundStarted -= EventHandler.OnRoundStarted;
            EventHandler = null;
            Log.Info("SCP-ES-32 ha sido habilitado.");
            base.OnDisabled();
        }
    }
   
    
}
