using Architecture_M;
using MirraGames.SDK;

namespace MirraSDK_M
{
    public class RateGameMirra : RateGameBase
    {
        public override void Rate()
        {
            MirraSDK.Platform.RateGame();
        }
    }
}