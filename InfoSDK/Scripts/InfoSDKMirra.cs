using Architecture_M;
using MirraGames.SDK;

namespace MirraSDK_M
{
    public class InfoSDKMirra : InfoSDKBase
    {
        public override bool IsStartedSDK => MirraSDK.IsInitialized;
    }
}