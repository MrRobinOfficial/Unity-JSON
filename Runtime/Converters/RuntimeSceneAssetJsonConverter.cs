using UnityEditor;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace uJSON.Converters
{
    public class RuntimeSceneAssetJsonConverter : JsonConverter<RuntimeSceneAsset>
    {
        public override RuntimeSceneAsset ReadJson(
            JsonReader reader,
            System.Type objectType,
            RuntimeSceneAsset existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            return new RuntimeSceneAsset();
        }

        public override void WriteJson(
            JsonWriter writer,
            RuntimeSceneAsset value,
            JsonSerializer serializer)
        {
            //writer.WriteValue(value.)
            //writer.WriteValue(value.ToString());
        }
    }
}