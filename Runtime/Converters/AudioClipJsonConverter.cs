using Newtonsoft.Json;
using UnityEngine;

namespace uJSON.Converters
{
    public sealed class AudioClipJsonConverter : JsonConverter<AudioClip>
    {
        public override AudioClip ReadJson(
            JsonReader reader,
            System.Type objectType,
            AudioClip existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            string s = (string)reader.Value;
            //return AudioClip.Create();
            return null;
        }

        public override void WriteJson(
            JsonWriter writer,
            AudioClip value,
            JsonSerializer serializer)
        {
            //writer.WriteValue(value);
        }
    }
}