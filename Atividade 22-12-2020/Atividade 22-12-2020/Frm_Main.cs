using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_22_12_2020
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private Queue<Senha> senhas = new Queue<Senha>();
        private int ultima = 0, guiches = 0;


        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            ultima++;

            senhas.Enqueue(new Senha(ultima));

            lst_Senhas.Items.Add(senhas.Last().dadosParciais());

            if (lst_Senhas.Items.Count > 0)
                btn_Chamar.Enabled = true;
        }

        private void btn_Chamar_Click(object sender, EventArgs e)
        {
            lst_Chamadas.Items.Add(senhas.Dequeue().dadosCompletos());

            lst_Senhas.Items.RemoveAt(0);

            if (lst_Senhas.Items.Count < 1)
                btn_Chamar.Enabled = false;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            guiches++;

            lbl_Qtd.Text = guiches.ToString();
        }
    }
}
