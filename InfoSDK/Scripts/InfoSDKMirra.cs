using Architecture_M;
using MirraGames.SDK;
using MirraGames.SDK.Common;

namespace MirraSDK_M
{
    public class InfoSDKMirra : InfoSDKBase
    {
        public override bool IsStartedSDK => MirraSDK.IsInitialized;

        public override LanguageEnum LanguageType
        {
            get
            {
                LanguageType language = MirraSDK.Language.Current;

                return language switch
                {
                    MirraGames.SDK.Common.LanguageType.English => LanguageEnum.English,
                    MirraGames.SDK.Common.LanguageType.Russian => LanguageEnum.Russian,
                    MirraGames.SDK.Common.LanguageType.Japanese => LanguageEnum.Japanese,
                    MirraGames.SDK.Common.LanguageType.Chinese => LanguageEnum.Chinese,
                    MirraGames.SDK.Common.LanguageType.Turkish => LanguageEnum.Turkish,
                    MirraGames.SDK.Common.LanguageType.Hindi => LanguageEnum.Hindi,
                    MirraGames.SDK.Common.LanguageType.Korean => LanguageEnum.Korean,
                    MirraGames.SDK.Common.LanguageType.Portuguese => LanguageEnum.Portuguese,
                    MirraGames.SDK.Common.LanguageType.Indonesian => LanguageEnum.Indonesian,
                    MirraGames.SDK.Common.LanguageType.German => LanguageEnum.German,
                    MirraGames.SDK.Common.LanguageType.Spanish => LanguageEnum.Spanish,
                    MirraGames.SDK.Common.LanguageType.Italian => LanguageEnum.Italian,
                    MirraGames.SDK.Common.LanguageType.Ukrainian => LanguageEnum.Ukrainian,
                    MirraGames.SDK.Common.LanguageType.Polish => LanguageEnum.Polish,
                    MirraGames.SDK.Common.LanguageType.French => LanguageEnum.French,
                    MirraGames.SDK.Common.LanguageType.Danish => LanguageEnum.Danish,
                    MirraGames.SDK.Common.LanguageType.Czech => LanguageEnum.Czech,
                    MirraGames.SDK.Common.LanguageType.Afrikaans => LanguageEnum.Afrikaans,
                    MirraGames.SDK.Common.LanguageType.Icelandic => LanguageEnum.Icelandic,
                    MirraGames.SDK.Common.LanguageType.Norwegian => LanguageEnum.Norwegian,
                    MirraGames.SDK.Common.LanguageType.Swedish => LanguageEnum.Swedish,
                    MirraGames.SDK.Common.LanguageType.Dutch => LanguageEnum.Dutch,
                    MirraGames.SDK.Common.LanguageType.Slovak => LanguageEnum.Slovak,
                    MirraGames.SDK.Common.LanguageType.Thai => LanguageEnum.Thai,
                    MirraGames.SDK.Common.LanguageType.Vietnamese => LanguageEnum.Vietnamese,
                    _ => LanguageEnum.None
                };
            }
        }
    }
}