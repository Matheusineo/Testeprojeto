using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_de_cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Nome = txtName.Text;
            string Sobrenome = txtLastname.Text;
            string Email = txtEmail.Text;
            string CPF = txtCpf.Text;
            string Estado = cmbState.GetItemText(cmbState.SelectedItem);
            string Cidade = txtCity.Text;
            string Logradouro = txtPublicplace.Text;
            string Bairro = txtNeighborhood.Text;
            string CEP = txtCep.Text;
            string Numero = txtNumber.Text;
            string Senha = txtPassword.Text;

            string sColor = "";
            if (rbtnMale.Checked)
            {
                sColor = rbtnMale.Text;
            }

            if (rbtnFemale.Checked)
            {
                sColor = rbtnFemale.Text;
            }

            if (rbtnOther.Checked)
            {
                sColor = rbtnOther.Text;
            }

            MessageBox.Show("Ola," + Nome + " " + Sobrenome + ",bem vindo ao sistema!!!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            txtCpf.Text = "";
            cmbState.SelectedIndex = -1;
            txtCity.Text = "";
            txtPublicplace.Text = "";
            txtNeighborhood.Text = "";
            txtCep.Text = "";
            txtNumber.Text = "";
            txtPassword.Text = "";

            MessageBox.Show("Processo cancelado,Por favor,coloque novamente as suas informações de usuario.");
        }
    }
}
