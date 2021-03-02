using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CripPass.Classes;

namespace CripPass
{
    public partial class CripPass : Form
    {
        public CripPass()
        {
            InitializeComponent();
        }

        private void CripPass_Load(object sender, EventArgs e)
        {
            txtSenha1.UseSystemPasswordChar = true;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha1.UseSystemPasswordChar = false;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha1.UseSystemPasswordChar = true;
        }

        private void btCrip_Click(object sender, EventArgs e)
        {

            if (vericrip() == true)
            {
                try
                {
                    txtCripSenha1.Text = Criptografar.Cript(txtSenha1.Text, txtChave1.Text);
                }
                catch
                {
                    MessageBox.Show("Chave incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else MessageBox.Show("Preencha todos os campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btDescrip_Click(object sender, EventArgs e)
        {
            if(veridesc() == true)
            {
                try
                {
                    txtSenhaDesc2.Text = Descriptografar.Descript(txtSenhaCrip2.Text, txtChave2.Text);
                }
                catch
                {
                    txtChave2.SelectAll();
                    txtChave2.Focus();
                    MessageBox.Show("Chave incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else MessageBox.Show("Preencha todos os campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool vericrip()
        {
            if (txtChave1.Text != String.Empty && txtSenha1.Text != String.Empty)
                return true;
            else return false;
        }

        private bool veridesc()
        {
            if (txtChave2.Text != String.Empty && txtSenhaCrip2.Text != String.Empty)
                return true;
            else return false;
        }

        private void tabCripPass_Click(object sender, EventArgs e)
        {
            //txtSenha1.Clear();
            //txtChave1.Clear();
            //txtCripSenha1.Clear();
            //txtCripSenha1.Clear();
            //txtSenhaDesc2.Clear();
            //txtChave2.Clear();
            //txtSenhaCrip2.Clear();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                System.Environment.Exit(0);
        }

        private void btSair2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                System.Environment.Exit(0);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CripPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btNovo1_Click(object sender, EventArgs e)
        {
            txtSenha1.Clear();
            txtChave1.Clear();
            txtCripSenha1.Clear();
            txtChave1.Focus();
        }

        private void btNovo2_Click(object sender, EventArgs e)
        {
            txtSenhaDesc2.Clear();
            txtChave2.Clear();
            txtSenhaCrip2.Clear();
            txtChave2.Focus();
        }
    }
}
