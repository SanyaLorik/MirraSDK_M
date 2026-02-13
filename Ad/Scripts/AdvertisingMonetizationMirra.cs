using Architecture_M;
using MirraGames.SDK;
using System;
using UnityEngine;

namespace MirraSDK_M
{
    public class AdvertisingMonetizationMirra : AdvertisingMonetizationBase
    {
        public override bool IsInterstitialVisible => MirraSDK.Ads.IsInterstitialVisible;

        public override void InvokeInterstitial(Action onOpen, Action<bool> onClose)
        {
            MirraSDK.Ads.InvokeInterstitial(
                onOpen: () => 
                {
                    onOpen?.Invoke();
                    Debug.Log("Межстраничная реклама открыта");
                },
                onClose: (isSuccess) =>
                {
                    onClose?.Invoke(isSuccess);
                    Debug.Log("Межстраничная реклама закрыта");
                }
            );
        }

        public override void InvokeRewarded(Action onOpen, Action<bool> onClose)
        {
            MirraSDK.Ads.InvokeRewarded(
                onOpen: () =>
                {
                    onOpen?.Invoke();
                    Debug.Log("Межстраничная реклама открыта");
                },
                onClose: (isSuccess) =>
                {
                    onClose?.Invoke(isSuccess);
                    Debug.Log("Межстраничная реклама закрыта");
                }
            );
        }
    }
}