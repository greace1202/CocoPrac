using System;
using System.Windows.Forms;

namespace Coco
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        float entrada;
        float salida;
        float totalFlujos;
        float a, b, c, d;

        private void pcCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnbCostohonorario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cnbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalflujo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ndParametro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = cnbModelo.SelectedIndex;
            float parametro = float.Parse(ndParametro.Value.ToString());

            switch (indiceSeleccionado)
            {
                case 0:
                    a = 3.2f;
                    b = 1.05f;
                    c = 2.5f;
                    d = 0.38f;

                    ndParametro.Minimum = 60;  // Establecer mínimo permitido
                    ndParametro.Maximum = 80;  // Establecer máximo permitido

                    if (parametro < 60 || parametro > 80)
                    {
                        MessageBox.Show("Debe ingresar un valor entre 60 y 80 en el parametro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Salir del método para evitar continuar con el procesamiento incorrecto
                    }
                    break;
                case 1:
                    a = 3.0f;
                    b = 1.12f;
                    c = 2.5f;
                    d = 0.35f;

                    ndParametro.Minimum = 81;  // Establecer mínimo permitido
                    ndParametro.Maximum = 101; // Establecer máximo permitido

                    if (parametro < 81 || parametro > 101)
                    {
                        MessageBox.Show("Debe ingresar un valor entre 81 y 101 en el parametro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Salir del método para evitar continuar con el procesamiento incorrecto
                    }
                    break;
                case 2:
                    a = 2.8f;
                    b = 1.20f;
                    c = 2.5f;
                    d = 0.32f;

                    ndParametro.Minimum = 102; // Establecer mínimo permitido
                    ndParametro.Maximum = 122; // Establecer máximo permitido

                    if (parametro < 102 || parametro > 122)
                    {
                        MessageBox.Show("Debe ingresar un valor entre 102 y 122 en el parametro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Salir del método para evitar continuar con el procesamiento incorrecto
                    }
                    break;
                default:
                    MessageBox.Show("Debe seleccionar un modo de desarrollo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            //Convertimos los textBox a variables
            float.TryParse(txtEntrada.Text, out entrada);
            float.TryParse(txtSalida.Text, out salida);
            //Realizamos la suma correspondiente y la almacenamos en una variable
            totalFlujos = entrada + salida;
            //Pasamos la variable a un textBox
            txtTotalflujo.Text = totalFlujos.ToString();
            //Calculamos la cantidad de instrucciones o LDC
            float ldc = parametro * totalFlujos;
            //Pasamos la cantidad de instrucciones a un textBox
            txtCantidaddeinstrucciones.Text = ldc.ToString();
            //Calculamos y convertimos a Miles de linas de codigo KLOC o MLDC
            float mdlc = ldc / 1000;
            //Pasamos las MDLC a un textBox
            txtMileslineas.Text = mdlc.ToString();
            //Calculamos la estimacion de esfuerzo nominal
            float en = a * ((float)Math.Pow(mdlc, b));
            //Redondeamos
            float esfuerzo = (float)Math.Ceiling(en);
            //Pasamos la estimacion del esfuerzo nominal a un textBox
            txtEsfuerzonominal.Text = esfuerzo.ToString();
            //Estimamos el tiempo de desarrollo del software
            float td = c * ((float)Math.Pow(en, d));
            //Redondeamos
            float tiempodes = (float)Math.Floor(td);
            //Pasamos el tiempo de desarrollo a un textBox
            txtTiempodesarrollo.Text = tiempodes.ToString() + "  Meses";
            //Estimamos el personal nesesario
            float pn = en / td;
            //Redondeamos
            float personal = (float)Math.Floor(pn);
            //Pasamos la estimacion a un textBox
            txtPersonalnesesario.Text = personal.ToString() + "   Persona(s)/Mes";
            //Estimamos la productividad del software
            float p = ldc / en;
            //Pasamos la estimacion a un TextBox
            txtProductividad.Text = p.ToString() + "Instruccion/Persona(s) Mes";

            //Elegimos el costo honorario
            int costohonorario = cnbCostohonorario.SelectedIndex;
            switch (costohonorario)
            {
                case 0:
                    costhon = 2350f;
                    break;
                case 1:
                    costhon = 4500f;
                    break;
                default:
                    MessageBox.Show("Debe seleccionar costo honorario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            //Asignamos el valor seleccionado a un textBox
            txtHonorario.Text = costhon.ToString();

            //Estimamos el costo de desarrollo de sw
            float costo = en * costhon;
            //Pasamos la estimacion a un textBox
            txtCosto.Text = costo.ToString();

            //Estimamos el costo individual de los programadores
            float cip = costo / esfuerzo;
            //Pasamos la estimacion a un textBox
            txtIndividualdesarrollador.Text = cip.ToString();

            //Estimamos el costo de cada linea de codigo
            float clc = costo / ldc;
            //Pasamos la estimacion a un textBox
            txtPrecioindividual.Text = clc.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        float costhon;
        public Form1()
        {
            InitializeComponent();
            //Añadimos items al comboBox
            cnbModelo.Items.Add("Organico"); // Índice 0
            cnbModelo.Items.Add("Semi-acoplado"); // Índice 1
            cnbModelo.Items.Add("Acoplado"); // Índice 2

            //Añadimos items al comboBox
            cnbCostohonorario.Items.Add("Sueldo Minimo Nacional"); // Índice 0
            cnbCostohonorario.Items.Add("Sueldo Promedio Programador"); // Índice 1
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
