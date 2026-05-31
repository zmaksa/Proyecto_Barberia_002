using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Barberia_002
{
    public partial class Form_Opciones_sistemaBarberia : Form
    {
        public Form_Opciones_sistemaBarberia()
        {
            InitializeComponent();
        }




        //boton salir del programa, te saca si le das a sí, si le das a no, te devuelve.
        private void Voton_Salir_DelPrograma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que quiere salir del programa?", "Salir del programa.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //este botón abre el inventario
        private void Boton_Abrir_Inventario_Click(object sender, EventArgs e)
        {
            REAL_Inventario formularioDelInventario100porcientoreal = new REAL_Inventario();
            formularioDelInventario100porcientoreal.Show();
            formularioDelInventario100porcientoreal.Owner = this;
        }

        private void Boton_reportarProblema__Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si quieres reportar un problema, por favor envía un correo a: pastrana.moreno.pv25@cbtis81.edu.mx", "Reportar un problema.",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
