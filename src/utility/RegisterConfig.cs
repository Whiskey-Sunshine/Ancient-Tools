using AncientTools.Config;
using HarmonyLib;
using System;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace AncientTools.Utility
{
    class RegisterConfig: ModSystem
    {
        const string AT_CONFIG_NETWORK_CHANNEL = "ATConfigNetworkChannel";

        private IServerNetworkChannel serverChannel;
        private IClientNetworkChannel clientChannel;

        ModConfig config = new ModConfig();

        public override void StartPre(ICoreAPI api)
        {
            base.StartPre(api);

            api.Network.RegisterChannel(AT_CONFIG_NETWORK_CHANNEL)
                .RegisterMessageType(typeof(AncientToolsConfig));

            if(api.Side == EnumAppSide.Server)
            {
                ICoreServerAPI sapi = (ICoreServerAPI)api;

                sapi.Event.PlayerJoin += OnPlayerJoin;
                config.ReadConfigServer(sapi);

                serverChannel = sapi.Network.GetChannel(AT_CONFIG_NETWORK_CHANNEL);
            }
            if(api.Side == EnumAppSide.Client) 
            {
                ICoreClientAPI capi;
                capi = (ICoreClientAPI)api;

                //-- Sets a handler for when a packet gets sent over the network channel`ATConfigNetworkChannel`. The packet(which is our config data) will be passed to applyServerConfig and will allow clients to use server config data directly instead of requiring an unnecessary save and load from the client --//
                clientChannel = capi.Network.GetChannel(AT_CONFIG_NETWORK_CHANNEL).SetMessageHandler<AncientToolsConfig>(applyServerConfig);

                void applyServerConfig(AncientToolsConfig serverConfig)
                {
                    config.ReadConfig(capi, serverConfig);
                }
            }
        }
        public override void Dispose()
        {
            base.Dispose();

            config = null;
        }
        /// <summary>
        /// Send the server config values to a client when it connects to the server. 
        /// </summary>
        /// <param name="player">The player client to receive the server config data</param>
        private void OnPlayerJoin(IServerPlayer player) 
        {
            serverChannel.SendPacket(config.ATConfig, player);
        }

    }
}
