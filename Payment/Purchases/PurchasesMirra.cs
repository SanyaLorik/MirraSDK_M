using Architecture_M;
using Cysharp.Threading.Tasks;
using MirraGames.SDK;
using MirraGames.SDK.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MirraSDK_M
{
    public class PurchasesMirra : PurchasesBase
    {
        public override async UniTask IsAvailableAsync()
        {
            await UniTask.WaitWhile(() => MirraSDK.IsInitialized == false);
        }

        public override IReadOnlyList<PurchaseSlotBase> FindAllPurchases(IReadOnlyList<PurchaseSlotBase> purchaseSlots)
        {
            List<PurchaseSlotBase> slots = new(purchaseSlots.Count);
            foreach (var slot in purchaseSlots)
            {
                ProductData productData = MirraSDK.Payments.GetProductData(slot.Id);
                if (productData == null)
                {
                    Debug.Log($"Покупка с id:{slot.Id} не найдена");
                    continue;
                }

                PurchaseInfo info = new(productData.Tag, productData.PriceInteger, productData.PriceFloat, productData.Currency);
                slot.SetPurchaseInfo(info);

                slots.Add(slot);
            }

            return slots;
        }

        public override void PurchaseBySDK(string id, Action onSuccess, Action onError)
        {
            MirraSDK.Payments.Purchase(
                productTag: id,
                onSuccess: onSuccess,
                onError: onError);
        }

        public override void Consume(IReadOnlyList<PurchaseSlotBase> availablePurchases)
        {
            MirraSDK.Payments.RestorePurchases((restoreData) =>
            {
                string[] pendingProducts = restoreData.PendingProducts;
                Debug.Log($"Игрок не получил '{pendingProducts.Length}' разных товаров: [{string.Join(", ", pendingProducts)}]");

                foreach (string productTag in pendingProducts)
                {
                    restoreData.RestoreProduct(productTag, onProductRestore: () =>
                    {
                        PurchaseSlotBase purchaseSlot = availablePurchases.FirstOrDefault(i => i.Id == productTag);
                        if (purchaseSlot == default)
                            return;

                        purchaseSlot.Buy();

                        Debug.Log($"Товар '{productTag}' восстановлен");

                    });
                }
            });
        }
    }
}