using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using uJSON.Converters;

namespace uJSON
{
	public static partial class uJSONExtensions
	{
        private static readonly JsonSerializerSettings JsonSettings = CreateSettings();

        private static JsonSerializerSettings CreateSettings()
        {
            var settings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                Converters =
                {
                    new Vector3JsonConverter(),
                    new QuaternionJsonConverter(),
                    new Matrix4x4JsonConverter(),
                    new GameObjectJsonConverter(),
                    new TransformJsonConverter(),
                    new SceneJsonConverter(),
                }
            };

            return settings;
        }

        public static string ToSaveableString(this JObject obj) =>
            obj.ToString(Formatting.Indented, JsonSettings.Converters.ToArray());

        public static string SerializeObject<T>(T data) =>
            JsonConvert.SerializeObject(data, JsonSettings);

        public static string SerializeObject<T>(T data, JsonSerializerSettings settings) =>
            JsonConvert.SerializeObject(data, settings);

        public static T DeserializeObject<T>(string contents) =>
            JsonConvert.DeserializeObject<T>(contents, JsonSettings);

        public static T DeserializeObject<T>(string contents, JsonSerializerSettings settings) =>
            JsonConvert.DeserializeObject<T>(contents, settings);
    } 
}