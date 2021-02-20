using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TodoApp.Models
{
    public class TodoRepositoryFile : ITodoRepository
    {
        private readonly string _filePath;
        private static List<Todo> _todos = new List<Todo>();

        //public TodoRepositoryFile()
        //{
        //    _todos = new List<Todo>
        //    {
        //        new Todo {Id = 1, Title = "ASP.NET Core학습", IsDone = false},
        //        new Todo {Id = 2, Title = "Blazor 학습", IsDone = false},
        //        new Todo {Id = 3, Title = "C# 학습", IsDone = true}
        //    };
        //}
        // 읽어오기
        public TodoRepositoryFile(string filePath)
        {
            this._filePath = filePath;
            string[] todos = File.ReadAllLines(filePath, Encoding.Default); //string으로 받기 때문
            foreach (var t in todos) //타입변환
            {
                string[] line = t.Split(','); 
                _todos.Add(new Todo { Id = Convert.ToInt32(line[0]), Title = line[1],
                    IsDone = Convert.ToBoolean(line[2]) });
                //개체 리터럴?
            }
        }


        public void Add(Todo model)
        {
            //현재 DB, 컬랙션에 있는 ID중 최댓값 +1 구하기
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);

            //파일 저장
            string data = "";
            foreach (var t in _todos)
            {
                //data += $"{t.Id},{ t.Title},{ t.IsDone}\r\n"; //줄바꿈/r/n
                data += $"{t.Id},{ t.Title},{ t.IsDone}{Environment.NewLine}"; //줄바꿈
            }
            //File.Write 로 써도 됨
            using (StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.Write(data);
                sw.Close(); //파일 닫아줘야함
                sw.Dispose(); //메모리 해제해라 using 있으면 없어도 됨
            }
        }

        public List<Todo> GetAll()
        {
            Console.WriteLine();
            return _todos.ToList(); //tolist 안해도 됨 _todo 가 리스트라
        }
    }
} //
