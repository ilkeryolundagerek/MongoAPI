namespace MongoAPI
{
    public class DBSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string OrnekCollectionName { get; set; } = null!;
    }
}
