using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmExemplo1 : Form
    {
        public frmExemplo1()
        {
            InitializeComponent();
        }

        private void cmdRun_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                //Primeiro texto preenche o quadro
                //Segundo texto preenche a label do quadro
                //O último é a ação do botão
                MessageBox.Show("Preencha o campo.", "Opss!", MessageBoxButtons.OK);
                txtNome.Focus();
                return;
            }
            MessageBox.Show("Olá " + txtNome.Text);
        }

        private void cmdRun_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();

            //.Left manipula o eixo X
            txtNome.Left = r.Next(this.Size.Width);

            //.Top manipula o eixo Y
            txtNome.Top = r.Next(this.Size.Height);
        }

        private void frmExemplo1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }
    }
}
