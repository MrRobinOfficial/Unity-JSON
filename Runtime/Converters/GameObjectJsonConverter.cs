using Newtonsoft.Json;
using UnityEngine;
using static uJSON.uJSONExtensions;

namespace uJSON.Converters
{
    public class GameObjectJsonConverter : JsonConverter<GameObject>
    {
        public override GameObject ReadJson(
            JsonReader reader,
            System.Type objectType,
            GameObject existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            return null;
        }

        public override void WriteJson(
            JsonWriter writer,
            GameObject value,
            JsonSerializer serializer)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("activeInHierarchy");
            writer.WriteValue(value.activeInHierarchy);

            writer.WritePropertyName("activeSelf");
            writer.WriteValue(value.activeSelf);

            writer.WritePropertyName("isStatic");
            writer.WriteValue(value.isStatic);

            writer.WritePropertyName("layer");
            writer.WriteValue(value.layer);

            //writer.WritePropertyName("scene");
            //writer.WriteValue(value.scene);

            writer.WritePropertyName("tag");
            writer.WriteValue(value.tag);

            writer.WritePropertyName("transform");
            writer.WriteValue(SerializeObject(value.transform));

            writer.WriteEndObject();
        }
    }
}