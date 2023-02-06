using Newtonsoft.Json;
using UnityEngine;

namespace uJSON.Converters
{
    public class Vector3IntJsonConverter : JsonConverter<Vector3Int>
    {
        public override Vector3Int ReadJson(
            JsonReader reader,
            System.Type objectType,
            Vector3Int existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            string s = (string)reader.Value;

            existingValue.Set(0, 0, 0);

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
                int.Parse(sArray[2].Trim(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture)
            );

            return existingValue;
        }

        public override void WriteJson(
            JsonWriter writer,
            Vector3Int value,
            JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}