using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNITPAC.LTPV.Aula03
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();            
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrosDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroAluno frmcadaluno = new FrmCadastroAluno();
            AbrirFormMdi(frmcadaluno);
        }

        private void AbrirFormMdi(Form frm, bool formUnico = true)
        {            
            FormCollection fc = Application.OpenForms;

            bool formAberto = false;

            foreach (Form item in fc)
            {                
                if (item.Name == frm.Name)
                {
                    if (formUnico)
                    {
                        MessageBox.Show(this, "Formulário já aberto", "Alerta", MessageBoxButtons.OK);
                        item.Show();
                        item.Focus();
                        formAberto = true;
                    }
                }
            }

            if (!formAberto)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
