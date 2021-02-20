using System;
using System.Windows.Forms;
using TodoApp.Models;

namespace TodoApp.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        // _repository를 주입해서 사용하기 위해(밑에 두 코드블럭에)
        private readonly ITodoRepository _repository;

        public Form1()
        {
            InitializeComponent();
            _repository = new TodoRepositoryJson
                (@"C:\language\Csharp\TodoApp\Todos.json");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //데이터그리드의 데이터 원본에 GetAll메서드 실행 
            //제이슨 파일을 읽어서 윈폼에서 출력
            DisplayData();
        }

        private void DisplayData() //밑에서도 쓰니까 메서드로 뽑아냈음 ctrl . 
        {
            this.dataGridView1.DataSource = _repository.GetAll();
        }

        // 저장버튼을 눌렀을때 입력 값들 ADD하기 + 저장
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            bool isDone = blnIsDone.Checked;

            Todo todo = new Todo { Title = title, IsDone = isDone };
            _repository.Add(todo);

            DisplayData(); //저장후 다시 출력
        }
    }
}
