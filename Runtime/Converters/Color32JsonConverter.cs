using Newtonsoft.Json;
using UnityEngine;

namespace uJSON.Converters
{
    public sealed class Color32JsonConverter : JsonConverter<Color32>
    {
        public override Color32 ReadJson(
            JsonReader reader,
            System.Type objectType,
            Color32 existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            string s = (string)reader.Value;

            if (ColorUtility.TryParseHtmlString(s, out Color color))
                return color;

            return Color.clear;
        }

        public override void WriteJson(
            JsonWriter writer,
            Color32 value,
            JsonSerializer serializer)
        {
            if (value.a < byte.MaxValue)
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