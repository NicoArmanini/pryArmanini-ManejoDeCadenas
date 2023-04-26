using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmanini_ManejoDeCadenas
{
    public partial class frmMain : Form
    {

        string TextoA; //declaro strings
        string TextoB;
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            TextoA = txtA.Text;
            lblCantA.Text = TextoA.Length.ToString();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            TextoB = txtB.Text;
            lblCantB.Text = TextoB.Length.ToString();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            lblCantA.Text = TextoA.Length.ToString();
            lblCantB.Text = TextoB.Length.ToString();

            int resultado = string.Compare(lblCantA.Text, lblCantB.Text);
            if (resultado == 0)
            {
                MessageBox.Show("El contenido de los textos  es igual");
            }
            else
            {
                if (resultado < 0)
                {
                    MessageBox.Show("El texto B tiene MAS caracteres");
                }
                else
                {
                    if (resultado > 0)
                    {
                        MessageBox.Show("El texto A tiene MAS caracteres");
                    }
                }
            }
        }

        private void btnRemplazar_Click(object sender, EventArgs e)
        {
            TextoA = txtA.Text;
            string stringB = "";
            stringB = TextoA.Replace(TextoA, txtB.Text);
            txtA.Text = stringB;
            txtB.Clear();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            DateTime A = dtpTiempo.Value;
            string B = A.ToString("dd/MM/yyyy");
            lblFecha.Text = B;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Visible = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TextoA.IndexOf(txtBuscar.Text) != -1)
            {
                txtBuscar.BackColor = Color.Green;
            }
            else
            {
                txtBuscar.BackColor = Color.Red;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
