using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1_Tema_3_RMB_2324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            //!? RMB2324 Cambiamos la inicialización de tipoTelegrama a 'o'
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;

            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            //!? RMB2324 Se realizan los cambios
            //!? para los radio buttons
            if (radioBUrgente.Checked)
                tipoTelegrama = 'u';
            if (radioBOrdinario.Checked)
                tipoTelegrama = 'o';
            // Obtengo el numero de palabras que forma el telegrama
            //!? RMB2324 Utilizamos el método Split de la clase string
            //!? que devuelve un vector
            //!? y contamos los elementos de dicho vector con el método Length
            char[] delimitadores = new char[] { ' ', '\r', '\n' };
            numPalabras = textoTelegrama.
                Split(delimitadores, StringSplitOptions.RemoveEmptyEntries).Length;

            // Si el telegrama es ordinario
            if(tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    //!? RMB2324 Cambiamos asignación de coste
                    coste = 2.5;
                else
                    //!? RMB2324 Ponemos el cáculo correcto correcto
                    coste = 2.5 + (0.5 * (numPalabras - 10));
            else
            // Si el telegrama es urgente
                if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    //!? RMB2324 Ponemos un breakpoint condicional
                    coste = 5 + (0.75 * (numPalabras - 10));

            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
