namespace Proyecto_Barberia_002
{

    //ESTE FORM YA ESTÁ COMPLETO EN FUNCIONALIDAD.
    //faltan cambios de diseño, pero eso es en el de diseño xd.

    public partial class Inicio_De_Sesion : Form
    {
        public Inicio_De_Sesion()
        {
            InitializeComponent();
        }



        //asignar un valor correcto a la contraseña

        public string contraseñaCorrecta = "Contraseña";
        public string contraseñaIngresada;

        public int vecesQuePoneContraseñaIncorrecta = 0;
        private void TextboxDondeIngresaLaContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            contraseñaIngresada = TextboxDondeIngresaLaContraseña.Text;
            if (e.KeyCode == Keys.Enter)
            {
                if (contraseñaIngresada == contraseñaCorrecta)
                {
                    MessageBox.Show("Contraseña correcta. Acceso concedido.", "Contraseña correcta.", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //abrir opciones inventraio
                    Form_Opciones_sistemaBarberia formularioOpcionesInventario = new Form_Opciones_sistemaBarberia();
                    formularioOpcionesInventario.Show();
                    //cuando se cierre el formulario de opcionessistema se cierra este tambien.
                    formularioOpcionesInventario.FormClosed += (s, args) => this.Close(); 
                    this.Hide();
                }
                else
                {
                    if (vecesQuePoneContraseñaIncorrecta < 6)
                    {
                        MessageBox.Show("¡La contraseña ingresada no es la correcta! Inténtalo de nuevo.", "Contraseña incorrecta.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        vecesQuePoneContraseñaIncorrecta++;
                        TextboxDondeIngresaLaContraseña.Focus();
                    }
                    else
                    {
                        MessageBox.Show("¡La contraseña ingresada no es la correcta! ¡Recuerda cuál es la contraseña, vamos!.", "Contraseña incorrecta.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        vecesQuePoneContraseñaIncorrecta = 0;
                    }
                }
            }
        }

        //
        private void Inicio_De_Sesion_Load(object sender, EventArgs e)//este no importa
        {//
        }//


        //este es el mismo que presionar enter.
        private void BotonContinuar_Iniciosesion_Click(object sender, EventArgs e)
        {
            contraseñaIngresada = TextboxDondeIngresaLaContraseña.Text;
            if (contraseñaIngresada == contraseñaCorrecta)
           {
                  MessageBox.Show("Contraseña correcta. Acceso concedido.","Contraseña correcta.",MessageBoxButtons.OK,MessageBoxIcon.Information);

                //Abrir siguiente formulario.
                Form_Opciones_sistemaBarberia formularioOpcionesInventario = new Form_Opciones_sistemaBarberia();
                //cuando se cierre el formulario de opcionessistema se cierra este tambien.
                formularioOpcionesInventario.FormClosed += (s, args) => this.Close();
                formularioOpcionesInventario.Show();
                this.Hide();
            }
           else
           {
                if (vecesQuePoneContraseñaIncorrecta < 6)
                {
                    MessageBox.Show("¡La contraseña ingresada no es la correcta! Inténtalo de nuevo.", "Contraseña incorrecta.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    vecesQuePoneContraseñaIncorrecta++;
                    TextboxDondeIngresaLaContraseña.Focus();
                }
                else
                {
                    MessageBox.Show("¡La contraseña ingresada no es la correcta! ¡Recuerda cuál es la contraseña, vamos!.", "Contraseña incorrecta.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                vecesQuePoneContraseñaIncorrecta = 0;
           }
        }
    }
}
