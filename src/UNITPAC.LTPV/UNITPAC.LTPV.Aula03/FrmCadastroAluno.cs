using System;
using System.Windows.Forms;
using UNITPAC.LTPV.Aplicacao.Interfaces;
using UNITPAC.LTPV.Data.Interface;
using UNITPAC.LTPV.Dominio.AlunoRoot;

namespace UNITPAC.LTPV.Aula03
{
    public partial class FrmCadastroAluno : Form
    {
        private IAlunoRepository _repository;

        public FrmCadastroAluno()
        {
            _repository = Program.container.GetInstance<IAlunoRepository>();

            InitializeComponent();

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            GridAlunos.DataSource = _repository.ObterTodos();

            BtAdicionar.Enabled = true;
        }

        private void BtAdicionar_Click(object sender, System.EventArgs e)
        {
            Aluno model = new Aluno
            {
                Nome = TxtNome.Text,
                SobreNome = TxtSobreNome.Text,
                DataNascimento = TxtDataNascimento.Text.Replace(" ", "").Replace("/", "") == string.Empty ? DateTime.Now : Convert.ToDateTime(TxtDataNascimento.Text),
                Matricula = TxtMatricula.Text,
                Observacoes = TxtObservacoes.Text
            };

            var service = Program.container.GetInstance<IAlunoService>();

            if (service.Adicionar(model))
            {
                AtualizarGrid();

                MessageBox.Show(this, "Aluno cadastrado com sucesso.", "LTPV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparComponentes();
            }
            else
            {
                TxtNome.Focus();

                MessageBox.Show(this, "Não foi possível adicionar o aluno. \n\n" + service.ObterNotificacoes(), "LTPV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                     
        }

        private void BtAtualizar_Click(object sender, EventArgs e)
        {
            Aluno model = MapearDominio();

            var service = Program.container.GetInstance<IAlunoService>();

            if (service.Atualizar(model))
            {
                AtualizarGrid();

                MessageBox.Show(this, "Aluno atualizado com sucesso.", "LTPV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtNome.Focus();

                LimparComponentes();

                BtAdicionar.Enabled = true;
                BtAtualizar.Enabled = false;
            }
            else
            {
                TxtNome.Focus();

                MessageBox.Show(this, "Não foi possível atualizar o aluno. \n\n" + service.ObterNotificacoes(), "LTPV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Aluno MapearDominio()
        {
            var model = new Aluno
            {
                Nome = TxtNome.Text,
                SobreNome = TxtSobreNome.Text,
                DataNascimento = TxtDataNascimento.Text.Replace(" ", "").Replace("/", "") == string.Empty ? DateTime.Now : Convert.ToDateTime(TxtDataNascimento.Text),
                Matricula = TxtMatricula.Text,
                Observacoes = TxtObservacoes.Text
            };

            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                model.Id = Convert.ToInt32(TxtId.Text);
            }

            return model;
        }

        private void LimparComponentes()
        {
            TxtId.Text = string.Empty;
            TxtNome.Text = string.Empty;
            TxtSobreNome.Text = string.Empty;
            TxtDataNascimento.Text = string.Empty;
            TxtMatricula.Text = string.Empty;
            TxtObservacoes.Text = string.Empty;

            BtAtualizar.Enabled = false;
            BtExcluir.Enabled = false;

            TxtNome.Focus();
        }

        private void GridAlunos_DoubleClick(object sender, EventArgs e)
        {
            if (GridAlunos.Rows.Count > 0)
            {
                var model = _repository.ObterPorId(Convert.ToInt32(GridAlunos.SelectedRows[0].Cells[Id.Index].Value));

                if (model == null)
                {
                    return;
                }

                TxtId.Text = model.Id.ToString();
                TxtNome.Text = model.Nome;
                TxtSobreNome.Text = model.SobreNome;
                TxtDataNascimento.Text = model.DataNascimento.ToString("dd/MM/yyyy");
                TxtMatricula.Text = model.Matricula;
                TxtObservacoes.Text = model.Observacoes;

                TxtNome.Focus();

                BtAdicionar.Enabled = false;
                BtAtualizar.Enabled = true;
                BtExcluir.Enabled = true;
            }
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja realmente excluir o registro de aluno: " 
                + TxtId.Text + " - " + TxtNome.Text + " ?", "LTPV",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                TxtNome.Focus();
                return;
            }

            Aluno model = MapearDominio();

            var service = Program.container.GetInstance<IAlunoService>();

            if (service.Excluir(model))
            {
                AtualizarGrid();

                MessageBox.Show(this, "Aluno excluído com sucesso.", "LTPV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparComponentes();
            }
            else
            {
                TxtNome.Focus();

                MessageBox.Show(this, "Não foi possível excluir o aluno. \n\n" + service.ObterNotificacoes(), "LTPV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
