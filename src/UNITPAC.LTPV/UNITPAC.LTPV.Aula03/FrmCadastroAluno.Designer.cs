namespace UNITPAC.LTPV.Aula03
{
    partial class FrmCadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnTopo = new System.Windows.Forms.Panel();
            this.LblTopo = new System.Windows.Forms.Label();
            this.PnInferior = new System.Windows.Forms.Panel();
            this.PnPrincipal = new System.Windows.Forms.Panel();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblSobreNome = new System.Windows.Forms.Label();
            this.TxtSobreNome = new System.Windows.Forms.TextBox();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.TxtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.PnTopo.SuspendLayout();
            this.PnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnTopo
            // 
            this.PnTopo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnTopo.Controls.Add(this.LblTopo);
            this.PnTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnTopo.Location = new System.Drawing.Point(0, 0);
            this.PnTopo.Name = "PnTopo";
            this.PnTopo.Size = new System.Drawing.Size(775, 40);
            this.PnTopo.TabIndex = 0;
            // 
            // LblTopo
            // 
            this.LblTopo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTopo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTopo.Location = new System.Drawing.Point(0, 0);
            this.LblTopo.Name = "LblTopo";
            this.LblTopo.Size = new System.Drawing.Size(773, 38);
            this.LblTopo.TabIndex = 0;
            this.LblTopo.Text = "Cadastro de Alunos";
            this.LblTopo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnInferior
            // 
            this.PnInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnInferior.Location = new System.Drawing.Point(0, 210);
            this.PnInferior.Name = "PnInferior";
            this.PnInferior.Size = new System.Drawing.Size(775, 132);
            this.PnInferior.TabIndex = 1;
            // 
            // PnPrincipal
            // 
            this.PnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnPrincipal.Controls.Add(this.TxtDataNascimento);
            this.PnPrincipal.Controls.Add(this.TxtMatricula);
            this.PnPrincipal.Controls.Add(this.LblMatricula);
            this.PnPrincipal.Controls.Add(this.TxtSobreNome);
            this.PnPrincipal.Controls.Add(this.LblSobreNome);
            this.PnPrincipal.Controls.Add(this.TxtNome);
            this.PnPrincipal.Controls.Add(this.LblDataNascimento);
            this.PnPrincipal.Controls.Add(this.LblNome);
            this.PnPrincipal.Controls.Add(this.TxtId);
            this.PnPrincipal.Controls.Add(this.LblId);
            this.PnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnPrincipal.Location = new System.Drawing.Point(0, 40);
            this.PnPrincipal.Name = "PnPrincipal";
            this.PnPrincipal.Size = new System.Drawing.Size(775, 170);
            this.PnPrincipal.TabIndex = 0;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(42, 28);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(30, 24);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "Id:";
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(74, 23);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(92, 29);
            this.TxtId.TabIndex = 1;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(5, 63);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(67, 24);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(74, 58);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(286, 29);
            this.TxtNome.TabIndex = 3;
            // 
            // LblSobreNome
            // 
            this.LblSobreNome.AutoSize = true;
            this.LblSobreNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSobreNome.Location = new System.Drawing.Point(367, 63);
            this.LblSobreNome.Name = "LblSobreNome";
            this.LblSobreNome.Size = new System.Drawing.Size(120, 24);
            this.LblSobreNome.TabIndex = 4;
            this.LblSobreNome.Text = "Sobre nome:";
            // 
            // TxtSobreNome
            // 
            this.TxtSobreNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSobreNome.Location = new System.Drawing.Point(490, 58);
            this.TxtSobreNome.Name = "TxtSobreNome";
            this.TxtSobreNome.Size = new System.Drawing.Size(270, 29);
            this.TxtSobreNome.TabIndex = 5;
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataNascimento.Location = new System.Drawing.Point(5, 95);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(139, 24);
            this.LblDataNascimento.TabIndex = 6;
            this.LblDataNascimento.Text = "Dt. nascimento:";
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.TxtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtDataNascimento.Location = new System.Drawing.Point(143, 92);
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.Size = new System.Drawing.Size(217, 29);
            this.TxtDataNascimento.TabIndex = 7;
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatricula.Location = new System.Drawing.Point(397, 97);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(90, 24);
            this.LblMatricula.TabIndex = 8;
            this.LblMatricula.Text = "Matricula:";
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatricula.Location = new System.Drawing.Point(490, 92);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(270, 29);
            this.TxtMatricula.TabIndex = 9;
            // 
            // FrmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 342);
            this.Controls.Add(this.PnPrincipal);
            this.Controls.Add(this.PnInferior);
            this.Controls.Add(this.PnTopo);
            this.Name = "FrmCadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.PnTopo.ResumeLayout(false);
            this.PnPrincipal.ResumeLayout(false);
            this.PnPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnTopo;
        private System.Windows.Forms.Panel PnInferior;
        private System.Windows.Forms.Panel PnPrincipal;
        private System.Windows.Forms.Label LblTopo;
        private System.Windows.Forms.TextBox TxtSobreNome;
        private System.Windows.Forms.Label LblSobreNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.DateTimePicker TxtDataNascimento;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.Label LblDataNascimento;
    }
}