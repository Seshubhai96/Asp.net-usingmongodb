namespace HMS.Config
{
    public interface IconfigHMS
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
