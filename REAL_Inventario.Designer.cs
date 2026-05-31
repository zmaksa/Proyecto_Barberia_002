namespace Proyecto_Barberia_002
{
    partial class REAL_Inventario
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
            labelSistemaDeInventario = new Label();
            ListView_Inventario = new ListView();
            IDentificadorDelProducto = new ColumnHeader();
            NombresDelosProductos = new ColumnHeader();
            CanridadDelosProductos = new ColumnHeader();
            precioDeLosProductos = new ColumnHeader();
            Boton_Añadir_AlInventario = new Button();
            Boton_Eliminar_Seleccionado = new Button();
            SuspendLayout();
            // 
            // labelSistemaDeInventario
            // 
            labelSistemaDeInventario.AutoSize = true;
            labelSistemaDeInventario.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSistemaDeInventario.Location = new Point(12, 9);
            labelSistemaDeInventario.Name = "labelSistemaDeInventario";
            labelSistemaDeInventario.Size = new Size(289, 32);
            labelSistemaDeInventario.TabIndex = 0;
            labelSistemaDeInventario.Text = "Sistema de inventario.";
            // 
            // ListView_Inventario
            // 
            ListView_Inventario.Columns.AddRange(new ColumnHeader[] { IDentificadorDelProducto, NombresDelosProductos, CanridadDelosProductos, precioDeLosProductos });
            ListView_Inventario.FullRowSelect = true;
            ListView_Inventario.GridLines = true;
            ListView_Inventario.Location = new Point(12, 44);
            ListView_Inventario.Name = "ListView_Inventario";
            ListView_Inventario.Size = new Size(385, 385);
            ListView_Inventario.TabIndex = 1;
            ListView_Inventario.UseCompatibleStateImageBehavior = false;
            ListView_Inventario.View = View.Details;
            // 
            // IDentificadorDelProducto
            // 
            IDentificadorDelProducto.Text = "ID";
            IDentificadorDelProducto.Width = 40;
            // 
            // NombresDelosProductos
            // 
            NombresDelosProductos.Text = "Nombre";
            NombresDelosProductos.Width = 120;
            // 
            // CanridadDelosProductos
            // 
            CanridadDelosProductos.Text = "Cantidad";
            CanridadDelosProductos.Width = 120;
            // 
            // precioDeLosProductos
            // 
            precioDeLosProductos.Text = "Precio";
            precioDeLosProductos.Width = 100;
            // 
            // Boton_Añadir_AlInventario
            // 
            Boton_Añadir_AlInventario.Location = new Point(510, 44);
            Boton_Añadir_AlInventario.Name = "Boton_Añadir_AlInventario";
            Boton_Añadir_AlInventario.Size = new Size(195, 51);
            Boton_Añadir_AlInventario.TabIndex = 2;
            Boton_Añadir_AlInventario.Text = "Añadir al inventario.";
            Boton_Añadir_AlInventario.UseVisualStyleBackColor = true;
            Boton_Añadir_AlInventario.Click += Boton_Añadir_AlInventario_Click;
            // 
            // Boton_Eliminar_Seleccionado
            // 
            Boton_Eliminar_Seleccionado.Location = new Point(510, 123);
            Boton_Eliminar_Seleccionado.Name = "Boton_Eliminar_Seleccionado";
            Boton_Eliminar_Seleccionado.Size = new Size(195, 48);
            Boton_Eliminar_Seleccionado.TabIndex = 3;
            Boton_Eliminar_Seleccionado.Text = "Eliminar objeto seleccionado.";
            Boton_Eliminar_Seleccionado.UseVisualStyleBackColor = true;
            Boton_Eliminar_Seleccionado.Click += Boton_Eliminar_Seleccionado_Click;
            // 
            // REAL_Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Boton_Eliminar_Seleccionado);
            Controls.Add(Boton_Añadir_AlInventario);
            Controls.Add(ListView_Inventario);
            Controls.Add(labelSistemaDeInventario);
            Name = "REAL_Inventario";
            Text = "Inventario.";
            Load += REAL_Inventario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSistemaDeInventario;
        private ListView ListView_Inventario;
        private ColumnHeader IDentificadorDelProducto;
        private ColumnHeader NombresDelosProductos;
        private ColumnHeader CanridadDelosProductos;
        private ColumnHeader precioDeLosProductos;
        private Button Boton_Añadir_AlInventario;
        private Button Boton_Eliminar_Seleccionado;
    }
}