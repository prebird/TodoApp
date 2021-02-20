using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace TodoApp.WebApplication
{
    public partial class TodoList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            const string url = "https://localhost:44388/api/todos";

            // 데이터 전송
            using (var client = new HttpClient()) //가장전통적인것
            {
                //데이터 전송
                var json = JsonConvert.SerializeObject(new Todo
                { Title = "HttpClientTest", IsDone = false });
                var post = new StringContent(json, Encoding.UTF8, "application/json");
                client.PostAsync(url, post).Wait();
                //데이터 수신
                var response = client.GetAsync(url).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                var todos = JsonConvert.DeserializeObject<List<Todo>>(result);

                //필터링 : LINQ로 함수형 프로그래밍 스타일 구현
                //Selecct(): map()
                //select -> IEnumerable 반환-> 체이닝가능
                //var q = from todo in todos // 쿼리신텍스
                //        select todo;
                //select는 새로운 타입으로 맵핑시키는 것도 가능
                //var q = todos.Select(t => new TodoViewModel // 메서드 신텍스
                //{ Title = t.Title, IsDone = t.IsDone });

                //쿼리어블 -> 쿼리형태로 계속붙히고 싶을때
                //짝수인것들의 타이틀과 이즈던만 읽어오기
                var query = todos.AsQueryable<Todo>();
                query = query.Where(x => x.Id % 2 == 0);
                var q = todos.Select(t => new TodoViewModel 
                { Title = t.Title, IsDone = t.IsDone });

                // 데이터 바인딩
                this.GridView1.DataSource = q;
                this.GridView1.DataBind(); //웹폼의 문법 

            }
        }

        public class Todo
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public bool IsDone { get; set; }
        }

        public class TodoViewModel
        {
            public string Title { get; set; }
            public bool IsDone { get; set; }
        }
    }
}