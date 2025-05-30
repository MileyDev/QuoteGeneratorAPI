using Microsoft.AspNetCore.Mvc;
using QuoteGeneratorAPI.Models;
using QuoteGeneratorAPI.Services;

namespace QuoteGeneratorAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class QuotesController : ControllerBase
{
    public QuotesController()
    {
    }

    [HttpGet]
    public ActionResult<List<Quote>> GetAll() => QuoteGenerator.GetAll(2);

    [HttpGet("{category}")]
    public ActionResult<Quote> Get(string category)
    {
        var quote = QuoteGenerator.Get(category);

        if (quote == null)
            return NotFound();

        return quote;
    }

    [HttpPost]
    public IActionResult Add(Quote quote)
    {if (string.IsNullOrWhiteSpace(quote.QuoteNote) || string.IsNullOrWhiteSpace(quote.Author))
        return BadRequest("Quote and Author are required.");

    QuoteGenerator.AddQuote(quote);
    return CreatedAtAction(nameof(Get), new { category = quote.Category }, quote);
    }
}