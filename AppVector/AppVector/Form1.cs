using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppVector
{
    public partial class Frmvectores : Form
    {

        // CREANDO UNA INSTANCIA DE MI CLASE VECTOR
        clsVector v = new clsVector();
        public Frmvectores()
        {
            InitializeComponent();
        }

        // MOSTRAR VECTOR
        private void mostrarVector() {
            lbresultado.Text = "";
            for (int i = 0; i < v.longitud(); i++) {
                lbresultado.Text = lbresultado.Text + v.obtenervalor(i) + ",";
            }
            lbresultado.Text = lbresultado.Text + "]";
        }

        // BOTON ADICIONAR
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            int x =Convert.ToInt16(txtvalor.Text);
            v.adicionar(x);
            mostrarVector();
        }

        // TEXT ADICIONAR
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(txtvalor.Text);
            v.adicionar(x);
            mostrarVector();
        }

        //TEXT MOSTRAR
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        //BOTON MOSTRAR
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        //TEXT INVERTIR
        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.invertir();
            mostrarVector();
        }

        //TEXT CANTIDADE DE PARES
        private void cantidaddeParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.cantPares();
            MessageBox.Show("Cant. de Elementos pares: " + c.ToString());

        }

        //TEXT ORDENAR MENOR A MAYOR
        private void ordenarMenorAmayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.OrdenarMenorAmayor();
            mostrarVector();
        }

        //TEXT ELIMINAR ELEMENTO POS
        private void eliminarElementoPosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt16(txtvalor.Text);
            v.EliminarElementoPos(p);
            mostrarVector();
        }

        //TEXT INVERTIR VECTOR
        private void invertirVectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.invertirVect();
            mostrarVector();
        }

        //TEXT CONTAR NUMEROS "CAPICUA"
        private void contarNCapicuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantidadCapicuas = v.ContarCapicuas();
            MessageBox.Show("Cantidad de números capicúa: "+cantidadCapicuas);
        }

        //TEXT CONTAR NUMEROS PRIMOS
        private void contarNPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           int cantidadPrimos = v.ContarPrimos(); 
           MessageBox.Show("Cantidad de números primos: " + cantidadPrimos); 
        }

        private void lbvalor_Click(object sender, EventArgs e)
        {

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
