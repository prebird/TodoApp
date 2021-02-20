using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.API.Controllers
{
    [Route("api/[Controller]")]//규칙
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _repository;

        public TodosController()
        {
            _repository = new TodoRepositoryJson
                (@"C:\language\Csharp\TodoApp\Todos.json");
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            // return Content("안녕하세요.");
             return Ok(_repository.GetAll()); //json 파일 넘겨줌

        }

        //http기술을 통해 던져주는것을 받고싶으면
        [HttpPost]
        public IActionResult Add([FromBody]Todo dto) 
        {
            _repository.Add(dto);
            return Ok(dto); //  데이터를 Add
        }
    }

}
