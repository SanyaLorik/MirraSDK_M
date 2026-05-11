using Architecture_M;
using MirraGames.SDK;
using System;

namespace MirraSDK_M
{
    public class PlayerInfoServiceMirra : PlayerInfoServiceBase
    {
        public override string DisplayName => MirraSDK.Player.DisplayName;

        public override string FirstName => MirraSDK.Player.FirstName;

        public override string LastName => MirraSDK.Player.LastName;

        public override string UserName => MirraSDK.Player.Username;

        public override string UniqueId => MirraSDK.Player.UniqueId;
        
        public override bool IsLoggedIn => MirraSDK.Player.IsLoggedIn;

        public override void Login(Action success = null, Action error = null)
        {
            MirraSDK.Player.InvokeLogin(success, error);
        }
    }
}