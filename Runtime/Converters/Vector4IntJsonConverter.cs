using Newtonsoft.Json;
using UnityEngine;

namespace uJSON.Converters
{
    public class Vector4IntJsonConverter : JsonConverter<Vector4Int>
    {
        public override Vector4Int ReadJson(
            JsonReader reader,
            System.Type objectType,
            Vector4Int existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            string s = (string)reader.Value;

            existingValue.Set(0, 0, 0, 0);

            if (string.IsNullOrEmpty(s))
                return existingValue;

            // Remove the parentheses
            if (s.StartsWith("(") && s.EndsWith(")"))
                s = s.Substring(1, s.Length - 2);

            // split the items
            string[] sArray = s.Split(',');

            existingValue.Set(
                int.Parse(sArray[0].Trim(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture),
                int.Parse(sArray[1].Trim(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture),
                int.Parse(sArray[2].Trim(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture),
                int.Parse(sArray[3].Trim(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture)
            );

            return existingValue;
        }

        public override void WriteJson(
            JsonWriter writer,
            Vector4Int value,
            JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}