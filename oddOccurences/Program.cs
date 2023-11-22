string[] inputWords = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();

Dictionary<string, int> extractedWords = new();

foreach (string word in inputWords)
{
    if (extractedWords.ContainsKey(word))
    {
        extractedWords[word] += 1;
    }
    else
    {
        extractedWords.Add(word, 1);
    }
}

foreach (KeyValuePair<string, int> pair in extractedWords)
{
    if (pair.Value % 2 != 0)
    {
        Console.Write($"{pair.Key} ");
    }
}
