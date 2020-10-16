using System.Windows.Forms;
using UNITPAC.LTPV.Data.Interface;

namespace UNITPAC.LTPV.Aula03
{
    public partial class FrmCadastroAluno : Form
    {
        private IAlunoRepository _repository;

        public FrmCadastroAluno()
        {
            _repository = Program.container.GetInstance<IAlunoRepository>();
            
            InitializeComponent();

            GridAlunos.DataSource = _repository.ObterTodos();
        }
    }
}
