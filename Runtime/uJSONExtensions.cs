using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using uJSON.Converters;

namespace uJSON
{
	public static partial class uJSONExtensions
	{
        public static JsonSerializerSettings GetJsonSerializerSettings() => s_JsonSettings;

        private static readonly JsonSerializerSettings s_JsonSettings = CreateSettings();

        private static JsonSerializerSettings CreateSettings()
        {
            var settings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                Converters =
                {
                    new EnumJsonConverter(),
                    new Vector2JsonConverter(),
                    new Vector2IntJsonConverter(),
                    new Vector3JsonConverter(),
                    new Vector3IntJsonConverter(),
                    new Vector4JsonConverter(),
                    new Vector4IntJsonConverter(),
                    new QuaternionJsonConverter(),
                    new Matrix4x4JsonConverter(),
                    new Hash128IntJsonConverter(),
                    new ColorJsonConverter(),
                    new Color32JsonConverter(),
                    new GameObjectJsonConverter(),
                    new TransformJsonConverter(),
                    new RuntimeSceneAssetJsonConverter(),
                    new TextAssetJsonConverter(),
                    new AudioClipJsonConverter(),
                    new SpriteJsonConverter(),
                }
            };

            return settings;
        }

        //public static string ToSaveableString(this JObject obj) =>
        //    obj.ToString(Formatting.Indented, JsonSettings.Converters.ToArray());

        public static string SerializeObject<T>(T data) =>
            JsonConvert.SerializeObject(data, s_JsonSettings);

        public static string SerializeObject<T>(T data, JsonSerializerSettings settings)
            => JsonConvert.SerializeObject(data, settings);

        public static T DeserializeObject<T>(string contents) => JsonConvert.DeserializeObject<T>(contents, s_JsonSettings);

        public static T DeserializeObject<T>(string contents, JsonSerializerSettings settings) => JsonConvert.DeserializeObject<T>(contents, settings);
    } 
}