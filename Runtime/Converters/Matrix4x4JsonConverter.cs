using Newtonsoft.Json;
using UnityEngine;

namespace uJSON.Converters
{
    public class Matrix4x4JsonConverter : JsonConverter<Matrix4x4>
    {
        public override Matrix4x4 ReadJson(JsonReader reader, System.Type objectType, Matrix4x4 existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var sVector = reader.ReadAsString();

            return Matrix4x4.identity;
        }

        public override void WriteJson(JsonWriter writer, Matrix4x4 value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}