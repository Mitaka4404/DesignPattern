using Newtonsoft.Json.Linq;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = Configuration.Settings["Username"];
            var server = Configuration.Settings["Server"];
            Console.WriteLine($"{server}, {user}");
        }
    }

    public sealed class Configuration
    {
        // Singleton インスタンス属性
        public static Configuration Settings { get; } = new Configuration();

        // Configuration Objectの　データ
        private Dictionary<string, object> dict = new Dictionary<string, object>();

        // private コンストラクタ
        private Configuration()
        {
            LoadConfig();
        }

        // Config ファイル読み込み exeファイルが作成されるパスに格納必要
        private void LoadConfig()
        {
            var str = File.ReadAllText("Config.json");
            JObject jo = JObject.Parse(str);

            foreach (var kv in jo)
            {
                dict.Add(kv.Key, kv.Value);
            }
        }

        // Keyに対するValueをリターンするインデックス
        public object this[string key]
        {
            get { return dict[key]; }
        }
        
    }
}