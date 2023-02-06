using Newtonsoft.Json;
using UnityEngine;

namespace uJSON.Converters
{
    public sealed class TextAssetJsonConverter : JsonConverter<TextAsset>
    {
        public override TextAsset ReadJson(
            JsonReader reader,
            System.Type objectType,
            TextAsset existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            string s = (string)reader.Value;
            return new TextAsset(s);
        }

        public override void WriteJson(
            JsonWriter writer,
            TextAsset value,
            JsonSerializer serializer)
        {
            writer.WriteValue(value.text);
        }
    }
}