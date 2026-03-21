using Architecture_M;
using MirraGames.SDK;
using System;
using UnityEngine;

namespace MirraSDK_M
{
    public class SaveLoadMirra : SaveLoaderBase
    {
        private const string MirraPrefsKey = "GameSave";

        public override object Load(Type type)
        {
            string defaultData = JsonUtility.ToJson(new object());
            string stringValue = MirraSDK.Data.GetString(key: MirraPrefsKey, defaultValue: defaultData);

            Debug.Log($"{MirraPrefsKey} Load {stringValue}");
            return JsonUtility.FromJson(stringValue, type);
        }

        public override void Save(object gameSave, Type type)
        {
            string data = JsonUtility.ToJson(gameSave, true);
            MirraSDK.Data.SetString(key: MirraPrefsKey, writeValue: data, important: true);

            Debug.Log($"{MirraPrefsKey} Save {data}");
        }
    }
}