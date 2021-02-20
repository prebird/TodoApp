using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.API.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const string url = "https://localhost:44388/api/todos";

            // 데이터 전송
            using (var client = new HttpClient()) //가장전통적인것
            {
                //데이터 전송
                var json = JsonConvert.SerializeObject(new Todo 
                { Title = "HttpClientTest", IsDone = false });
                var post = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(url, post);
                //데이터 수신
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();
                var todos = JsonConvert.DeserializeObject<List<Todo>>(result);
                foreach (var t in todos)
                {
                    Console.WriteLine($"{t.Id} - {t.Title}({t.IsDone})");
                }

            }

            
        }
    }
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
