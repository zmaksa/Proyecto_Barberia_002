namespace Proyecto_Barberia_002
{
    partial class Form_Opciones_sistemaBarberia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelTituloOpcionesDelInventario = new Label();
            LabelQuedeseaHacer_ = new Label();
            Boton_Abrir_Inventario = new Button();
            Voton_Salir_DelPrograma = new Button();
            Boton_reportarProblema_ = new Button();
            SuspendLayout();
            // 
            // LabelTituloOpcionesDelInventario
            // 
            LabelTituloOpcionesDelInventario.AutoSize = true;
            LabelTituloOpcionesDelInventario.Font = new Font("Arial", 14F);
            LabelTituloOpcionesDelInventario.Location = new Point(249, 37);
            LabelTituloOpcionesDelInventario.Name = "LabelTituloOpcionesDelInventario";
            LabelTituloOpcionesDelInventario.Size = new Size(271, 27);
            LabelTituloOpcionesDelInventario.TabIndex = 0;
            LabelTituloOpcionesDelInventario.Text = "Opciones del inventario.";
            // 
            // LabelQuedeseaHacer_
            // 
            LabelQuedeseaHacer_.AutoSize = true;
            LabelQuedeseaHacer_.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuedeseaHacer_.Location = new Point(264, 139);
            LabelQuedeseaHacer_.Name = "LabelQuedeseaHacer_";
            LabelQuedeseaHacer_.Size = new Size(232, 23);
            LabelQuedeseaHacer_.TabIndex = 1;
            LabelQuedeseaHacer_.Text = "Diga, ¿qué desea hacer?";
            // 
            // Boton_Abrir_Inventario
            // 
            Boton_Abrir_Inventario.Font = new Font("Arial", 11F);
            Boton_Abrir_Inventario.Location = new Point(194, 255);
            Boton_Abrir_Inventario.Name = "Boton_Abrir_Inventario";
            Boton_Abrir_Inventario.Size = new Size(111, 91);
            Boton_Abrir_Inventario.TabIndex = 2;
            Boton_Abrir_Inventario.Text = "Opciones del inventario.";
            Boton_Abrir_Inventario.UseVisualStyleBackColor = true;
            Boton_Abrir_Inventario.Click += Boton_Abrir_Inventario_Click;
            // 
            // Voton_Salir_DelPrograma
            // 
            Voton_Salir_DelPrograma.Font = new Font("Arial", 11F);
            Voton_Salir_DelPrograma.Location = new Point(463, 255);
            Voton_Salir_DelPrograma.Name = "Voton_Salir_DelPrograma";
            Voton_Salir_DelPrograma.Size = new Size(111, 91);
            Voton_Salir_DelPrograma.TabIndex = 3;
            Voton_Salir_DelPrograma.Text = "Salir.";
            Voton_Salir_DelPrograma.UseVisualStyleBackColor = true;
            Voton_Salir_DelPrograma.Click += Voton_Salir_DelPrograma_Click;
            // 
            // Boton_reportarProblema_
            // 
            Boton_reportarProblema_.Font = new Font("Arial", 11F);
            Boton_reportarProblema_.Location = new Point(12, 347);
            Boton_reportarProblema_.Name = "Boton_reportarProblema_";
            Boton_reportarProblema_.Size = new Size(111, 91);
            Boton_reportarProblema_.TabIndex = 4;
            Boton_reportarProblema_.Text = "Reportar un problema.";
            Boton_reportarProblema_.UseVisualStyleBackColor = true;
            Boton_reportarProblema_.Click += Boton_reportarProblema__Click;
            // 
            // Form_Opciones_sistemaBarberia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Boton_reportarProblema_);
            Controls.Add(Voton_Salir_DelPrograma);
            Controls.Add(Boton_Abrir_Inventario);
            Controls.Add(LabelQuedeseaHacer_);
            Controls.Add(LabelTituloOpcionesDelInventario);
            Name = "Form_Opciones_sistemaBarberia";
            Text = "Opciones del sistema de la Barbería.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTituloOpcionesDelInventario;
        private Label LabelQuedeseaHacer_;
        private Button Boton_Abrir_Inventario;
        private Button Voton_Salir_DelPrograma;
        private Button Boton_reportarProblema_;
    }
}