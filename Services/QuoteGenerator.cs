using QuoteGeneratorAPI.Models;
using QuoteGeneratorAPI.Controllers;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Text.Json;

namespace QuoteGeneratorAPI.Services;

public static class QuoteGenerator
{
    private static readonly string _FilePath = "quotes.json";
    private static List<Quote> Quotes = LoadQuotes();

    public static List<Quote> GetAll(int count)
    {
        var random = new Random();
        return Quotes.OrderBy(q => random.Next())
        .Take(count)
        .ToList();
    }

    public static Quote? Get(string category)
    {
        var matchingQuotes = Quotes
        .Where(q => q.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
        .ToList();

        if (matchingQuotes.Count == 0)
            return null;

        var random = new Random();
        return matchingQuotes[random.Next(matchingQuotes.Count)];
    }

    public static void AddQuote(Quote Quote)
    {
        Quotes.Add(Quote);
        SaveQuote();
    }

    private static List<Quote> LoadQuotes()
    {
        if (!File.Exists(_FilePath))
            return new List<Quote>();

        var json = File.ReadAllText(_FilePath);
        return JsonSerializer.Deserialize<List<Quote>>(json) ?? new List<Quote>();
    }

    private static void SaveQuote()
    {
        var json = JsonSerializer.Serialize(Quotes, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_FilePath, json);
    }
}
