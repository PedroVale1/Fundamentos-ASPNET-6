namespace Blog
{
    public static class Configuration
    {
        public static string JwtKey = "ZmVkYW3ZDg4NjNiNdH";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "curso_api_ASDQWQWKewaERTFEed/z0ae2Nwe/unQwes=";
        public static StmpConfiguration Smtp = new();

        public class StmpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
