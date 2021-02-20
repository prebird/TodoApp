using System;
using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.ConsoleAppJson
{
    public class Class1
    {
        static void Main(string[] args)
        {
            ITodoRepository _repository = new
                TodoRepositoryFile(@"C:\language\Csharp\TodoApp\Todos.json");
            List<Todo> todos = new List<Todo>();
            todos = _repository.GetAll(); //가져오기
            //[1] 기본데이터 출력
            foreach (var t in todos)
            {
                Console.WriteLine($"{t.Id}-{t.Title}({t.IsDone})");
            }
            //[2] 데이터 입력
            Todo todo = new Todo { Title = "Database", IsDone = true };
            _repository.Add(todo);
            todos = _repository.GetAll(); //다시 로드

            //[3] 변경 데이터 출력
            foreach (var t in todos)
            {
                Console.WriteLine($"{t.Id}-{t.Title}({t.IsDone})");
            }
        }
    }
}
