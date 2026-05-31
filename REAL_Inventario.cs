using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Barberia_002
{
    public partial class REAL_Inventario : Form
    {
        public REAL_Inventario()
        {
            InitializeComponent();
        }

        //para visualizar cómo va mi programa xddd
        //Inicio de sesión >
        //Opciones programa >
        //Ver Inventario >
        //Añadir al inventario || Eliminar del inventario
        //Eliminar del inventario:
        //Form eliminar;
        //














        private void REAL_Inventario_Load(object sender, EventArgs e)
        {

        }
        


        //AÑADIR AL INVENTARIO  
        private void Boton_Añadir_AlInventario_Click(object sender, EventArgs e)
        {

        }

        private void Boton_Eliminar_Seleccionado_Click(object sender, EventArgs e)
        {
            if(ListView_Inventario.SelectedItems.Count==1)
            {
                //código a ejecutar si hay un solo elemento seleccionado
                //pantalla eliminar
                Form_Eliminar_Algo_Del_Inventario eliminar_Form = new Form_Eliminar_Algo_Del_Inventario();
                eliminar_Form.ShowDialog();


            }
            else if (ListView_Inventario.SelectedItems.Count > 1)
            {
                //si hay varios seleccionados
                MessageBox.Show("Por favor, seleccione solo un elemento.","Vaarios elementos seleccionados.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //si no hay ningún elemento seleccionado
                MessageBox.Show("Seleccione un elemento.","Ningún elemento seleccionado.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
