using Newtonsoft.Json;
using UnityEngine;

namespace uJSON.Converters
{
    public sealed class SpriteJsonConverter : JsonConverter<Sprite>
    {
        public override Sprite ReadJson(
            JsonReader reader,
            System.Type objectType,
            Sprite existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            string s = (string)reader.Value;
            //return Sprite.Create();
            return null;
        }

        public override void WriteJson(
            JsonWriter writer,
            Sprite value,
            JsonSerializer serializer)
        {
            //writer.WriteValue(value);
        }
    }
}