using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace uJSON.Converters
{
    public sealed class ColorJsonConverter : JsonConverter<Color>
    {
        public override Color ReadJson(
            JsonReader reader,
            System.Type objectType,
            Color existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            string s = (string)reader.Value;

            if (ColorUtility.TryParseHtmlString(s, out existingValue))
                return existingValue;

            return Color.clear;
        }

        public override void WriteJson(
            JsonWriter writer,
            Color value,
            JsonSerializer serializer)
        {
            if (value.a < 1f)
            {
                string s = ColorUtility.ToHtmlStringRGBA(value);
                writer.WriteValue($"#{s}");
            }
            else
            {
                string s = ColorUtility.ToHtmlStringRGB(value);
                writer.WriteValue($"#{s}");
            }
        }
    }
}