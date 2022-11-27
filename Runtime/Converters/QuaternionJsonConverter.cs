using Newtonsoft.Json;
using UnityEngine;

namespace uJSON.Converters
{
    public class QuaternionJsonConverter : JsonConverter<Quaternion>
    {
        public override Quaternion ReadJson(JsonReader reader, System.Type objectType, Quaternion existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var sQuaternion = reader.ReadAsString();

            // Remove the parentheses
            if (sQuaternion.StartsWith("(") && sQuaternion.EndsWith(")"))
                sQuaternion = sQuaternion.Substring(1, sQuaternion.Length - 3);

            // split the items
            string[] sArray = sQuaternion.Split(',');

            // store as a Vector3
            Quaternion result = new Quaternion(
                float.Parse(sArray[0]),
                float.Parse(sArray[1]),
                float.Parse(sArray[2]),
                float.Parse(sArray[3]));

            return result;
        }

        public override void WriteJson(JsonWriter writer, Quaternion value, JsonSerializer serializer) => writer.WriteValue(value.ToString());
    }
}