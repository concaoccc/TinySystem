public class SimpleEngine : IStoreEngine
{
    string dataFile = "SimpleStoreEngineData.txt";

    public void Store(string key, string value)
    {
        // append key valye pair to file to the end of the file
        File.AppendAllText(dataFile, $"{key}={value}\n");
    }

    public string Retrieve(string key)
    {
        // read key value pair from the last line of the file and check the key
        return File.ReadAllLines(dataFile).LastOrDefault(line => line.StartsWith(key))?.Split('=')[1];
    }
}