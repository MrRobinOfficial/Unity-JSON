using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace uJSON.Converters
{
    public class SceneJsonConverter : JsonConverter<Scene>
    {
        public override Scene ReadJson(JsonReader reader, System.Type objectType, Scene existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return new();
        }

        public override void WriteJson(JsonWriter writer, Scene value, JsonSerializer serializer) =>
            writer.WriteValue(value.ToString());
    }
}