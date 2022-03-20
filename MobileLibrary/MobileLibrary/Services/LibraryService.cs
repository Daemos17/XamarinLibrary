using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MobileLibrary.Models;
using System.Net.Http;
using System.Collections.Generic;

namespace MobileLibrary.Services
{
   public class LibraryService
    {

        //private readonly HttpClient _httpClient;


        //public LibraryService(HttpClient httpClient)
        //{
        //    _httpClient = httpClient;
        //}

        //public async Task<IEnumerable<Book>> GetBooks()
        //{
        //    var response = await _httpClient.GetAsync("Books");

        //    response.EnsureSuccessStatusCode();

        //    var responseAsString = await response.Content.ReadAsStringAsync();
        //    return JsonSerializer.Deserialize<IEnumerable<Book>>(responseAsString);
        //}
        //public async Task<Book> GetBook(int id)
        //{
        //    var response = await _httpClient.GetAsync($"Books/{id}");

        //    response.EnsureSuccessStatusCode();

        //    var responseAsString = await response.Content.ReadAsStringAsync();
        //    return JsonSerializer.Deserialize<Book>(responseAsString);
        //}

        //public async Task AddBook(Book book)
        //{
        //    var response = await _httpClient.PostAsync("Books",
        //        new StringContent(JsonSerializer.Serialize(book), Encoding.UTF8, "application/json"));

        //    response.EnsureSuccessStatusCode();
        //}

        //public async Task DeleteBook(Book book)
        //{
        //    var response = await _httpClient.DeleteAsync($"Books/{book.IdBook}");

        //    response.EnsureSuccessStatusCode();
        //}

        //public async Task SaveBook(Book book)
        //{
        //    var response = await _httpClient.PutAsync($"Books?id={book.IdBook}",
        //        new StringContent(JsonSerializer.Serialize(book), Encoding.UTF8, "application/json"));

        //    response.EnsureSuccessStatusCode();
        //}



        const string Url = "http://192.168.1.33:4300/api/library/"; // обращайте внимание на конечный слеш

        // настройки для десериализации для нечувствительности к регистру символов
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        // настройка клиента
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        // получаем все книги
        public async Task<IEnumerable<Book>> Get()
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return JsonSerializer.Deserialize<IEnumerable<Book>>(result, options);
        }


    }
}
