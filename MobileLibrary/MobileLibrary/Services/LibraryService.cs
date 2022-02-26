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
