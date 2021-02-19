using System.Collections.Generic;
using System.Linq;

namespace TodoApp.Models
{
    public class TodoRepositoryInMemory : ITodoRepository
    {
        private static List<Todo> _todos = new List<Todo>();

        public TodoRepositoryInMemory()
        {
            _todos = new List<Todo>
            {
                new Todo {Id = 1, Title = "ASP.NET Core학습", IsDone = false},
                new Todo {Id = 2, Title = "Blazor 학습", IsDone = false},
                new Todo {Id = 3, Title = "C# 학습", IsDone = true}
            };
        }

        //인-메모리 데이터베이스 사용 영역
        public void Add(Todo model)
        {
            //현재 DB, 컬랙션에 있는 ID중 최댓값 +1 구하기
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model); //메서드 선언중인 메서드를 사용??
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList(); //tolist 안해도 됨 _todo 가 리스트라
        }
    }
} //_todo가 하나의 인메모리 데이터베이스임(하나의 컬렉션만 담을수 잇는)
