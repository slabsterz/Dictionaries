int repeat = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> synonyms = new();

for (int i = 0; i < repeat; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (synonyms.ContainsKey(word))
    {
        synonyms[word].Add(synonym);
    }
    else
    {
        synonyms.Add(word, new List<string>());
        synonyms[word].Add(synonym);
    }
}

foreach (KeyValuePair<string, List<string>> pair in synonyms)
{
    Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
}