using Architecture_M;
using MirraGames.SDK;
using System.Collections.Generic;

namespace MirraSDK_M
{
    partial class LeaderboardServiceMirra : LeaderboardServiceBase
    {
        private const int countPlayers = 50;

        private List<PlayerScore> _playerScores = new(countPlayers);

        public override IReadOnlyList<PlayerScore> GetPlayerScores(string leaderboardId)
        {
            MirraSDK.Achievements.GetLeaderboard(leaderboardId, (leaderboard) =>
            {
                int length = leaderboard.players.Length;
                for (int i = 0; i < length; i++)
                {
                    ref MirraGames.SDK.Common.PlayerScore playerScore = ref leaderboard.players[i];
                    _playerScores[i] = new(playerScore.displayName, playerScore.position, playerScore.score);
                }
            });

            return _playerScores;
        }

        public override void SetScore(string leaderboardId, int score)
        {
            MirraSDK.Achievements.SetScore(leaderboardId, score);
        }
    }
}
