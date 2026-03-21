using Architecture_M;
using MirraGames.SDK;
using UnityEngine;

namespace MirraSDK_M
{
    public class SaveLoadMirra : SaveLoaderBase<GameSaveBase>
    {
        private const string MirraPrefsKey = "GameSave";

        public override GameSaveBase Load()
        {
            string defaultData = JsonUtility.ToJson(new GameSaveBase());
            string stringValue = MirraSDK.Data.GetString(key: MirraPrefsKey, defaultValue: defaultData);

            Debug.Log($"{MirraPrefsKey} Load {stringValue}");
            return JsonUtility.FromJson<GameSaveBase>(stringValue);
            GameSave a = (GameSave)(new GameSaveBase());
        }

        public override void Save(GameSaveBase gameSave)
        {
            string data = JsonUtility.ToJson(gameSave, true);
            MirraSDK.Data.SetString(key: MirraPrefsKey, writeValue: data, important: true);

            Debug.Log($"{MirraPrefsKey} Save {data}");
        }
    }
}