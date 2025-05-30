# 📜 QuoteGeneratorAPI

A simple but powerful ASP.NET Core Web API for serving inspirational quotes, built as part of a learning series by [Micheal Sokoya (MileyDev)](https://github.com/MileyDev). This API supports retrieving random quotes, filtering by category, and adding new quotes dynamically.

---

## 🚀 Features

- ✅ Get two random quotes
- ✅ Get a quote by category
- ✅ Add a new quote via POST
- ✅ JSON-based in-memory data storage
- ✅ Swagger UI for testing endpoints
- ✅ Clean, minimal API structure with controllers

---

## 📂 Project Structure

QuoteGeneratorAPI/
├── Controllers/
│ └── QuoteController.cs
├── Services/
│ └── QuoteGenerator.cs
├── Models/
│ └── Quote.cs
├── quotes.json
├── Program.cs
└── QuoteGeneratorAPI.csproj


---

## 🔧 Tech Stack

- **.NET 8 (ASP.NET Core Web API)**
- **C#**
- **System.Text.Json** for serialization
- **Swagger (Swashbuckle.AspNetCore)** for API docs

---

## 📬 API Endpoints

| Method | Route                     | Description                      |
|--------|---------------------------|----------------------------------|
| GET    | `/api/quote`              | Get 2 random quotes              |
| GET    | `/api/quote/{category}`   | Get 1 random quote by category   |
| POST   | `/api/quote`              | Add a new quote                  |

### 🧪 Example POST Payload

```json
{
  "quoteNote": "Stay hungry, stay foolish.",
  "author": "Steve Jobs",
  "category": "Motivation"
}

Running Locally
git clone https://github.com/MileyDev/QuoteGeneratorAPI.git
cd QuoteGeneratorAPI
dotnet run

🌐 Live Demo
Coming soon on Render 🌍
(Will update once deployed)

📚 Author
Micheal Sokoya (MileyDev)
.NET Developer | Streetwear Creator | Tech Polymath
🔗 LinkedIn
💻 GitHub

🪪 License
MIT License. Use it, modify it, remix it. Just don't forget to inspire someone along the way.