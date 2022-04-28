using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula31_Intermediario
{
    public partial class Form1 : Form
    {
        public decimal res = 0;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtproduto.Text != "" && txtpreco.Text != "")
            {
                listpreços.Items.Add(txtpreco.Text);
                listprodutos.Items.Add(txtproduto.Text);
                res += Decimal.Parse(txtpreco.Text);
                lbltotal.Text = "R$" + res.ToString();
                LimpaCampos();
            }
            else
            {
                MessageBox.Show("Campo Produto ou Preço não Preenchido");
                txtproduto.Focus();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subtrair(listprodutos.SelectedIndex);
            listpreços.Items.RemoveAt(listprodutos.SelectedIndex);
            listprodutos.Items.RemoveAt(listprodutos.SelectedIndex);
        }
        public void Subtrair(int index)
        {
            string sub = listpreços.Items[index].ToString();
            res -= Decimal.Parse(sub);
            lbltotal.Text = res.ToString();
            LimpaCampos();
        }
        public void LimpaCampos()
        {
            txtproduto.Text = "";
            txtpreco.Text = "";
            txtproduto.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
