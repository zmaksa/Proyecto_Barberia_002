namespace Proyecto_Barberia_002
{
    partial class Inicio_De_Sesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelTituloIniciodesesion = new Label();
            label1 = new Label();
            TextboxDondeIngresaLaContraseña = new TextBox();
            BotonContinuar_Iniciosesion = new Button();
            SuspendLayout();
            // 
            // LabelTituloIniciodesesion
            // 
            LabelTituloIniciodesesion.AutoSize = true;
            LabelTituloIniciodesesion.Font = new Font("Arial", 14F);
            LabelTituloIniciodesesion.Location = new Point(292, 34);
            LabelTituloIniciodesesion.Name = "LabelTituloIniciodesesion";
            LabelTituloIniciodesesion.Size = new Size(177, 27);
            LabelTituloIniciodesesion.TabIndex = 0;
            LabelTituloIniciodesesion.Text = "Inicio de sesión";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(180, 167);
            label1.Name = "label1";
            label1.Size = new Size(423, 23);
            label1.TabIndex = 1;
            label1.Text = "Ingrese la contraseña para entrar al programa.";
            // 
            // TextboxDondeIngresaLaContraseña
            // 
            TextboxDondeIngresaLaContraseña.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextboxDondeIngresaLaContraseña.Location = new Point(292, 246);
            TextboxDondeIngresaLaContraseña.Name = "TextboxDondeIngresaLaContraseña";
            TextboxDondeIngresaLaContraseña.PasswordChar = '*';
            TextboxDondeIngresaLaContraseña.Size = new Size(177, 28);
            TextboxDondeIngresaLaContraseña.TabIndex = 2;
            TextboxDondeIngresaLaContraseña.KeyDown += TextboxDondeIngresaLaContraseña_KeyDown;
            // 
            // BotonContinuar_Iniciosesion
            // 
            BotonContinuar_Iniciosesion.Location = new Point(331, 279);
            BotonContinuar_Iniciosesion.Name = "BotonContinuar_Iniciosesion";
            BotonContinuar_Iniciosesion.Size = new Size(94, 34);
            BotonContinuar_Iniciosesion.TabIndex = 3;
            BotonContinuar_Iniciosesion.Text = "Continuar";
            BotonContinuar_Iniciosesion.UseVisualStyleBackColor = true;
            BotonContinuar_Iniciosesion.Click += BotonContinuar_Iniciosesion_Click;
            // 
            // Inicio_De_Sesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonContinuar_Iniciosesion);
            Controls.Add(TextboxDondeIngresaLaContraseña);
            Controls.Add(label1);
            Controls.Add(LabelTituloIniciodesesion);
            Name = "Inicio_De_Sesion";
            Text = "Inicio de sesión.";
            Load += Inicio_De_Sesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTituloIniciodesesion;
        private Label label1;
        private TextBox TextboxDondeIngresaLaContraseña;
        private Button BotonContinuar_Iniciosesion;
    }
}
