using Architecture_M;
using Zenject;

namespace MirraSDK_M
{
    public class LanguageDeterminantMirra : RealLanguageDeterminantBase
    {
        [Inject] private IInfoSDK _infoSDK;

        public override LanguageEnum DeterminateRealLanguage()
        {
            return _infoSDK.LanguageType;
        }
    }
}