using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Calculadora.Calculadora;
using BLL_Calculadora.Calculadora;

namespace PL_Calculadora
{
    public partial class frmCalculadora : Form
    {
        #region Variables globales
        cls_Calculadora_DAL obj_DAL = new cls_Calculadora_DAL();
        cls_Calculadora_BLL obj_BLL = new cls_Calculadora_BLL();
        #endregion
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNum1_Click(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            obj_DAL.fNum1 = Convert.ToSingle(txtNum1.Text);
            obj_DAL.fNum2 = Convert.ToSingle(txtNum2.Text);
            obj_BLL.restar(ref obj_DAL);

            txtResultado.Text = obj_DAL.fResultado.ToString();

            obj_BLL.NumMenor(ref obj_DAL);
            txtMenor.Text = obj_DAL.fValidaMenor.ToString();
            
            obj_BLL.NumMayor(ref obj_DAL);
            txtMayor.Text = obj_DAL.fValidaMayor.ToString();

            obj_BLL.ParImparNum1(ref obj_DAL);
            txtNumero1.Text = obj_DAL.sValidaParImpar;

            obj_BLL.ParImparNum2(ref obj_DAL);
            txtNumero2.Text = obj_DAL.sValidaParImpar;

        }

        private void lblNumero2_Click(object sender, EventArgs e)
        {

        }
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            obj_DAL.fNum1 = Convert.ToSingle(txtNum1.Text);
            obj_DAL.fNum2 = Convert.ToSingle(txtNum2.Text);
            obj_BLL.multiplicar(ref obj_DAL);

            txtResultado.Text = obj_DAL.fResultado.ToString();

            obj_BLL.NumMenor(ref obj_DAL);
            txtMenor.Text = obj_DAL.fValidaMenor.ToString();
            
            obj_BLL.NumMayor(ref obj_DAL);
            txtMayor.Text = obj_DAL.fValidaMayor.ToString();

            obj_BLL.ParImparNum1(ref obj_DAL);
            txtNumero1.Text = obj_DAL.sValidaParImpar;

            obj_BLL.ParImparNum2(ref obj_DAL);
            txtNumero2.Text = obj_DAL.sValidaParImpar;

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMayor_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMenor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            obj_DAL.fNum1 = Convert.ToSingle(txtNum1.Text);
            obj_DAL.fNum2 = Convert.ToSingle(txtNum2.Text);
            if (obj_DAL.fNum2 == 0)
            {
                MessageBox.Show("La división entre 0 no es permitido");
            }

            obj_BLL.dividir(ref obj_DAL);
            txtResultado.Text = obj_DAL.fResultado.ToString();
            
            obj_BLL.NumMenor(ref obj_DAL);
            txtMenor.Text = obj_DAL.fValidaMenor.ToString();
            
            obj_BLL.NumMayor(ref obj_DAL);
            txtMayor.Text = obj_DAL.fValidaMayor.ToString();

            obj_BLL.ParImparNum1(ref obj_DAL);
            txtNumero1.Text = obj_DAL.sValidaParImpar;

            obj_BLL.ParImparNum2(ref obj_DAL);
            txtNumero2.Text = obj_DAL.sValidaParImpar;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            obj_DAL.fNum1 = Convert.ToSingle(txtNum1.Text);

            obj_DAL.fNum2 = Convert.ToSingle(txtNum2.Text);
            obj_BLL.sumar(ref obj_DAL);

            txtResultado.Text = obj_DAL.fResultado.ToString();

            obj_BLL.NumMenor(ref obj_DAL);
            txtMenor.Text = obj_DAL.fValidaMenor.ToString();
            
            obj_BLL.NumMayor(ref obj_DAL);
            txtMayor.Text = obj_DAL.fValidaMayor.ToString();

            obj_BLL.ParImparNum1(ref obj_DAL);
            txtNumero1.Text = obj_DAL.sValidaParImpar;

            obj_BLL.ParImparNum2(ref obj_DAL);
            txtNumero2.Text = obj_DAL.sValidaParImpar;

        }

        private void txtMayor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMenor_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblNum2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            { 
                e.Handled = false;
            return;
            }
            else
            {
                MessageBox.Show("Debe igresar solo números");
                e.Handled = true;
                return;
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
                return;
            }
            else
            {
                MessageBox.Show("Debe igresar solo números");
                e.Handled = true;
                return;
            }
        }

        private void txtNum1_Leave(object sender, EventArgs e)
        {
            if (txtNum1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debe ingresar un valor númerico OBLIGATORIAMENTE");
                txtNum1.Focus();
                return;
            }
        }

        private void txtNum2_Leave(object sender, EventArgs e)
        {
            if (txtNum2.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debe ingresar un valor númerico OBLIGATORIAMENTE");
                txtNum2.Focus();
                return;
            }
        }


    }
}
