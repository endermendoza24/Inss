using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CalculadoraPensionINSS
{
    public partial class Form1 : Form
    {
        MetodosDeCalculo metodo = new MetodosDeCalculo();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Calculos();
        }

        public void Calculos()
        {
            try
            {
                metodo.nombre = txtNombre.Text;
                metodo.apellido = txtApellido.Text;
                metodo.semanas = Convert.ToInt32(txtSemanas.Text);
                metodo.edad = Convert.ToInt32(txtEdad.Text);
                metodo.salario = Convert.ToDecimal(txtSalario.Text);
                if (chkTeacher.Checked)
                {
                    metodo.docente = true;
                }
                if (chkAsign.Checked == true)
                {
                    metodo.estado = true;
                }
                else
                {
                    metodo.estado = false;
                }
                metodo.CalculoDePension();
                lblResultado2.Text = "Usted obtuvo el " + metodo.FactorBase.ToString("00.00") + " % de su promedio salarial";
                lblResultado1.Text = metodo.nombre + " su pensión va a ser de " + metodo.pensionTotal.ToString("00.00") + " C$" + 
                    System.Environment.NewLine + metodo.mensaje;
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
