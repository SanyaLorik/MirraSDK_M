using Architecture_M;
using MirraGames.SDK;
using UnityEngine;

namespace MirraSDK_M
{
    public class SaveLoadMirra<TGameSaveBase> : SaveLoaderBase<TGameSaveBase>
        where TGameSaveBase : GameSaveBase, new()
    {
        private const string MirraPrefsKey = "GameSave";

        public override TGameSaveBase Load()
        {
            string defaultData = JsonUtility.ToJson(new TGameSaveBase());
            string stringValue = MirraSDK.Data.GetString(key: MirraPrefsKey, defaultValue: defaultData);

            Debug.Log($"{MirraPrefsKey} Load {stringValue}");
            return JsonUtility.FromJson<TGameSaveBase>(stringValue);

        }

        public override void Save(TGameSaveBase gameSave)
        {
            string data = JsonUtility.ToJson(gameSave, true);
            MirraSDK.Data.SetString(key: MirraPrefsKey, writeValue: data, important: true);

            Debug.Log($"{MirraPrefsKey} Save {data}");
        }
    }
}