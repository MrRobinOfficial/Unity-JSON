using Newtonsoft.Json;
using UnityEngine;

namespace uJSON.Converters
{
    public class EnumJsonConverter : JsonConverter<System.Enum>
    {
        public override System.Enum ReadJson(
            JsonReader reader,
            System.Type objectType,
            System.Enum existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            string s = (string)reader.Value;

            if (System.Enum.TryParse(objectType, s, out var value))
                existingValue = (System.Enum)value;

            return existingValue;
        }

        public override void WriteJson(
            JsonWriter writer,
            System.Enum value,
            JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}