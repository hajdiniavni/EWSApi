namespace EWSApi.Utils.Configuration
{
    public class ElasticConfiguration
    {
        public string Uri { get; set; } = null!;
        public string Index { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string CertificateFingerprint { get; set; } = null!;
        public string ApiKey { get; set; } = null!;
    }
}
