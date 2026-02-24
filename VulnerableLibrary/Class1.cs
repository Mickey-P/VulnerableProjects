namespace VulnerableLibrary;

public static class SomeClass
{
    public static object? VulnerableMethod(string input) => Newtonsoft.Json.JsonConvert.DeserializeObject(input);
}
