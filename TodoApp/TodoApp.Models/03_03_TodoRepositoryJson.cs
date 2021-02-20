using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TodoApp.Models
{
    public class TodoRepositoryJson : ITodoRepository
    {
        private readonly string _filePath;
        private static List<Todo> _todos = new List<Todo>();

        
        // 읽어오기
        public TodoRepositoryJson(string filePath)
        {
            this._filePath = filePath;
            string todos = File.ReadAllText(filePath, Encoding.Default); //string으로 받기 때문
            _todos = JsonConvert.DeserializeObject<List<Todo>>(todos);
        }


        public void Add(Todo model)
        {
            //현재 DB, 컬랙션에 있는 ID중 최댓값 +1 구하기
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);

            // Json 파일 저장
            string json = JsonConvert.SerializeObject(_todos, Formatting.Indented);
            File.WriteAllText(_filePath, json);
            
        }

        public List<Todo> GetAll()
        {
            Console.WriteLine();
            return _todos.ToList(); //tolist 안해도 됨 _todo 가 리스트라
        }
    }
} //_todo가 하나의 인메모리 데이터베이스임(하나의 컬렉션만 담을수 잇는)
