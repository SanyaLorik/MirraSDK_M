using Architecture_M;
using MirraGames.SDK;

public class GameReadyMirra : GameReadyBase
{
    public override void StartGameReady()
    {
        MirraSDK.Analytics.GameIsReady();
    }
}