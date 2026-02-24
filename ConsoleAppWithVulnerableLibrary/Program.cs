// See https://aka.ms/new-console-template for more information
dynamic? result = VulnerableLibrary.SomeClass.VulnerableMethod("{\"key\": \"Vulnerable World!\"}");
Console.WriteLine($"Hello, {result?["key"]}");
