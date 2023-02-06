using Newtonsoft.Json;
using UnityEngine;

namespace uJSON.Converters
{
    public class Hash128IntJsonConverter : JsonConverter<Hash128>
    {
        public override Hash128 ReadJson(
            JsonReader reader,
            System.Type objectType,
            Hash128 existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            string s = (string)reader.Value;

            existingValue = new Hash128();

            if (string.IsNullOrEmpty(s))
                return existingValue;

            existingValue = Hash128.Parse(s);

            return existingValue;
        }

        public override void WriteJson(
            JsonWriter writer,
            Hash128 value,
            JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}