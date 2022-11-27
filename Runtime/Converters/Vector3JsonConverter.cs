using Newtonsoft.Json;
using UnityEngine;

namespace uJSON.Converters
{
    public class Vector3JsonConverter : JsonConverter<Vector3>
    {
        public override Vector3 ReadJson(JsonReader reader, System.Type objectType, Vector3 existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var sVector = reader.ReadAsString();

            // Remove the parentheses
            if (sVector.StartsWith("(") && sVector.EndsWith(")"))
                sVector = sVector.Substring(1, sVector.Length - 2);

            // split the items
            string[] sArray = sVector.Split(',');

            // store as a Vector3
            Vector3 result = new Vector3(
                float.Parse(sArray[0]),
                float.Parse(sArray[1]),
                float.Parse(sArray[2]));

            return result;
        }

        public override void WriteJson(JsonWriter writer, Vector3 value, JsonSerializer serializer) => writer.WriteValue(value.ToString());
    }
}