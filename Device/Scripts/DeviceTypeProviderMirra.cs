using Architecture_M;
using MirraGames.SDK;

namespace MirraSDK_M
{
    public class DeviceTypeProviderMirra : DeviceTypeProviderBase
    {
        public override DeviceTypeEnum DeviceType => MirraSDK.Device.IsMobile == true ? DeviceTypeEnum.Mobile : DeviceTypeEnum.Desktop;
    }
}
