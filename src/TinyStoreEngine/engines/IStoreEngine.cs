public interface IStoreEngine
{
    void Store(string key, string value);
    string Retrieve(string key);
}