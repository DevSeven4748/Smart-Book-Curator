using BookCurator.BLL.DTOs;
using BookCurator.BLL.Options;
using BookCurator.BLL.Services.Abstract;
using BookCurator.DAL.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;

namespace BookCurator.BLL.Services.Concrete
{
    public class GeminiRecommendationService(HttpClient httpClient, IOptions<GeminiOptions> options) : IRecommendationService
    {
        private readonly GeminiOptions _options = options.Value;

        public async Task<string> GetRecommendationAsync(IEnumerable<Book> books, string? mood)
        {
            var prompt = BuildPrompt(books, mood);

            var request = new GeminiRequest
            {
                Contents = new List<GeminiContent>
                {
                    new GeminiContent
                    {
                        Parts = new List<GeminiPart> { new GeminiPart { Text = prompt} }
                    }
                }
            };

            var url = $"{_options.BaseUrl}/{_options.Model}:generateContent?key={_options.ApiKey}";

            // Simple retry for transient 503s
            const int maxAttempts = 5;
            for(var attempt = 1; attempt <= maxAttempts; attempt++)
            {
                var httpResponse = await httpClient.PostAsJsonAsync(url, request);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var result = await httpResponse.Content.ReadFromJsonAsync<GeminiResponse>();
                    var text = result?.Candidates.FirstOrDefault()?.Content.Parts.FirstOrDefault()?.Text;
                    return text ?? "No recommendation was returned.";
                }

                if (httpResponse.StatusCode == HttpStatusCode.ServiceUnavailable && attempt < maxAttempts)
                {
                    await Task.Delay(1000 * attempt); // simple backoff: 1s, then 2s
                    continue;
                }

                return $"Recommendation service is temporarily unavailable ({(int)httpResponse.StatusCode}). Please try again shortly."; //return error for each attempt
            }
            return "Recommendation service is temporarily unavailable. Please try again shortly."; //return error message for the entire process
        }

        private static string BuildPrompt(IEnumerable<Book> books, string? mood)
        {
            var bookList = string.Join(", ", books.Select(b => $"{b.Title} by {b.Author} ({b.Status})"));
            var moodPart = string.IsNullOrWhiteSpace(mood) ? "" : $"I'm in the mood for something like: {mood}.";

            return $"Based on this reading list: {bookList}.{moodPart} Recommend one book I haven't read yet, in 2-3 sentences, explaining why it fits";

        }























    }
}
