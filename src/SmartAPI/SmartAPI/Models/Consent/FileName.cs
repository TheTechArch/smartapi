namespace SmartAPI.Models.Consent
{
    public class Rootobject
    {
        public string type { get; set; }
        public string id { get; set; }
        public string from { get; set; }
        public To to { get; set; }
        public DateTime consented { get; set; }
        public DateTime validTo { get; set; }
        public Consentright[] consentRights { get; set; }
    }

    public class To
    {
        public string authority { get; set; }
        public string ID { get; set; }
    }

    public class Consentright
    {
        public string[] action { get; set; }
        public Resource[] resource { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Metadata
    {
        public string rente { get; set; }
        public string utloepsar { get; set; }
    }

    public class Resource
    {
        public string type { get; set; }
        public string value { get; set; }
    }

}
