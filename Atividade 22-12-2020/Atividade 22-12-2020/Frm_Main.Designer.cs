namespace Atividade_22_12_2020
{
    partial class Frm_Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Gerar = new System.Windows.Forms.Button();
            this.lst_Senhas = new System.Windows.Forms.ListBox();
            this.btn_ListSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Qtd = new System.Windows.Forms.Label();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Guiche = new System.Windows.Forms.TextBox();
            this.btn_Chamar = new System.Windows.Forms.Button();
            this.lst_Chamadas = new System.Windows.Forms.ListBox();
            this.btn_ListAtend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Gerar
            // 
            this.btn_Gerar.Location = new System.Drawing.Point(55, 13);
            this.btn_Gerar.Name = "btn_Gerar";
            this.btn_Gerar.Size = new System.Drawing.Size(75, 23);
            this.btn_Gerar.TabIndex = 0;
            this.btn_Gerar.Text = "Gerar";
            this.btn_Gerar.UseVisualStyleBackColor = true;
            this.btn_Gerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // lst_Senhas
            // 
            this.lst_Senhas.FormattingEnabled = true;
            this.lst_Senhas.Location = new System.Drawing.Point(13, 42);
            this.lst_Senhas.Name = "lst_Senhas";
            this.lst_Senhas.Size = new System.Drawing.Size(159, 147);
            this.lst_Senhas.TabIndex = 6;
            // 
            // btn_ListSenha
            // 
            this.btn_ListSenha.Location = new System.Drawing.Point(48, 195);
            this.btn_ListSenha.Name = "btn_ListSenha";
            this.btn_ListSenha.Size = new System.Drawing.Size(89, 23);
            this.btn_ListSenha.TabIndex = 1;
            this.btn_ListSenha.Text = "Listar Senhas";
            this.btn_ListSenha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Qtd Guichês";
            // 
            // lbl_Qtd
            // 
            this.lbl_Qtd.AutoSize = true;
            this.lbl_Qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qtd.Location = new System.Drawing.Point(215, 93);
            this.lbl_Qtd.Name = "lbl_Qtd";
            this.lbl_Qtd.Size = new System.Drawing.Size(29, 31);
            this.lbl_Qtd.TabIndex = 8;
            this.lbl_Qtd.Text = "0";
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(192, 127);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 2;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Guichê:";
            // 
            // txt_Guiche
            // 
            this.txt_Guiche.Location = new System.Drawing.Point(411, 16);
            this.txt_Guiche.MaxLength = 2;
            this.txt_Guiche.Name = "txt_Guiche";
            this.txt_Guiche.Size = new System.Drawing.Size(27, 20);
            this.txt_Guiche.TabIndex = 3;
            // 
            // btn_Chamar
            // 
            this.btn_Chamar.Enabled = false;
            this.btn_Chamar.Location = new System.Drawing.Point(452, 13);
            this.btn_Chamar.Name = "btn_Chamar";
            this.btn_Chamar.Size = new System.Drawing.Size(75, 23);
            this.btn_Chamar.TabIndex = 4;
            this.btn_Chamar.Text = "Chamar";
            this.btn_Chamar.UseVisualStyleBackColor = true;
            this.btn_Chamar.Click += new System.EventHandler(this.btn_Chamar_Click);
            // 
            // lst_Chamadas
            // 
            this.lst_Chamadas.FormattingEnabled = true;
            this.lst_Chamadas.Location = new System.Drawing.Point(287, 42);
            this.lst_Chamadas.Name = "lst_Chamadas";
            this.lst_Chamadas.Size = new System.Drawing.Size(317, 147);
            this.lst_Chamadas.TabIndex = 9;
            // 
            // btn_ListAtend
            // 
            this.btn_ListAtend.Location = new System.Drawing.Point(383, 196);
            this.btn_ListAtend.Name = "btn_ListAtend";
            this.btn_ListAtend.Size = new System.Drawing.Size(124, 23);
            this.btn_ListAtend.TabIndex = 5;
            this.btn_ListAtend.Text = "Listar Atendimentos";
            this.btn_ListAtend.UseVisualStyleBackColor = true;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 233);
            this.Controls.Add(this.btn_ListAtend);
            this.Controls.Add(this.lst_Chamadas);
            this.Controls.Add(this.btn_Chamar);
            this.Controls.Add(this.txt_Guiche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.lbl_Qtd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ListSenha);
            this.Controls.Add(this.lst_Senhas);
            this.Controls.Add(this.btn_Gerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Gerar;
        private System.Windows.Forms.ListBox lst_Senhas;
        private System.Windows.Forms.Button btn_ListSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Qtd;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Guiche;
        private System.Windows.Forms.Button btn_Chamar;
        private System.Windows.Forms.ListBox lst_Chamadas;
        private System.Windows.Forms.Button btn_ListAtend;
    }
}

