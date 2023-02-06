using Newtonsoft.Json;
using UnityEngine;

namespace uJSON.Converters
{
    public class Vector4JsonConverter : JsonConverter<Vector4>
    {
        public override Vector4 ReadJson(
            JsonReader reader,
            System.Type objectType,
            Vector4 existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            string s = (string)reader.Value;

            existingValue.Set(0f, 0f, 0f, 0f);

            if (string.IsNullOrEmpty(s))
                return existingValue;

            // Remove the parentheses
            if (s.StartsWith("(") && s.EndsWith(")"))
                s = s.Substring(1, s.Length - 2);

            // split the items
            string[] sArray = s.Split(',');

            existingValue.Set(
                float.Parse(sArray[0].Trim(), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture),
                float.Parse(sArray[1].Trim(), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture),
                float.Parse(sArray[2].Trim(), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture),
                float.Parse(sArray[3].Trim(), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture)
            );

            return existingValue;
        }

        public override void WriteJson(
            JsonWriter writer,
            Vector4 value,
            JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}