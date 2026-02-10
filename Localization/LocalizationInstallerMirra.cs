using Architecture_M;

namespace MirraSDK_M
{
    public class LocalizationInstallerMirra<TLocalizationData> : LocalizationInstaller<TLocalizationData>
        where TLocalizationData : LocalizationData
    {
        protected override RealLanguageDeterminantBase GetLanguageDeterminantLogic()
        {
            LanguageDeterminantMirra languageDeterminantMirra = new();
            Container.Inject(languageDeterminantMirra);

            return languageDeterminantMirra;
        }
    }
}