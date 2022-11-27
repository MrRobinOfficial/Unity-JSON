using Newtonsoft.Json;
using UnityEngine;
using static uJSON.uJSONExtensions;

namespace uJSON.Converters
{
    public class TransformJsonConverter : JsonConverter<Transform>
    {
        public override Transform ReadJson(JsonReader reader, System.Type objectType, Transform existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return null;
        }

        public override void WriteJson(JsonWriter writer, Transform value, JsonSerializer serializer)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("childCount");
            writer.WriteValue(value.childCount);

            writer.WritePropertyName("eulerAngles");
            writer.WriteValue(SerializeObject(value.eulerAngles));

            writer.WritePropertyName("forward");
            writer.WriteValue(SerializeObject(value.forward));

            writer.WritePropertyName("hasChanged");
            writer.WriteValue(value.hasChanged);

            writer.WritePropertyName("hierarchyCapacity");
            writer.WriteValue(value.hierarchyCapacity);

            writer.WritePropertyName("hierarchyCount");
            writer.WriteValue(value.hierarchyCount);

            writer.WritePropertyName("localEulerAngles");
            writer.WriteValue(SerializeObject(value.localEulerAngles));

            writer.WritePropertyName("localPosition");
            writer.WriteValue(SerializeObject(value.localPosition));

            writer.WritePropertyName("localRotation");
            writer.WriteValue(SerializeObject(value.localRotation));

            writer.WritePropertyName("localScale");
            writer.WriteValue(SerializeObject(value.localScale));

            writer.WritePropertyName("localToWorldMatrix");
            writer.WriteValue(SerializeObject(value.localToWorldMatrix));

            writer.WritePropertyName("lossyScale");
            writer.WriteValue(SerializeObject(value.lossyScale));

            writer.WritePropertyName("parent");
            writer.WriteValue(SerializeObject(value.parent));

            writer.WritePropertyName("position");
            writer.WriteValue(SerializeObject(value.position));

            writer.WritePropertyName("right");
            writer.WriteValue(SerializeObject(value.right));

            writer.WritePropertyName("root");
            writer.WriteValue(SerializeObject(value.root));

            writer.WritePropertyName("rotation");
            writer.WriteValue(SerializeObject(value.rotation));

            writer.WritePropertyName("up");
            writer.WriteValue(SerializeObject(value.up));

            writer.WritePropertyName("worldToLocalMatrix");
            writer.WriteValue(SerializeObject(value.worldToLocalMatrix));

            writer.WriteEndObject();
        }
    }
}