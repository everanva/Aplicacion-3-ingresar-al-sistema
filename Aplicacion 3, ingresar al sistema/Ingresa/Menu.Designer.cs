namespace Aplicacion_3__ingresar_al_sistema.Ingresa
{
    partial class Menu
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
            Button btnMaestros;
            btnEstudiantes = new Button();
            btnCerrar = new Button();
            btnMaestros = new Button();
            SuspendLayout();
            // 
            // btnMaestros
            // 
            btnMaestros.Location = new Point(28, 27);
            btnMaestros.Name = "btnMaestros";
            btnMaestros.Size = new Size(390, 66);
            btnMaestros.TabIndex = 0;
            btnMaestros.Text = "Administrar Maestros";
            btnMaestros.UseVisualStyleBackColor = true;
            btnMaestros.Click += btnMaestros_Click;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.Location = new Point(28, 120);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(390, 66);
            btnEstudiantes.TabIndex = 1;
            btnEstudiantes.Text = "Administrar Estudiantes";
            btnEstudiantes.UseVisualStyleBackColor = true;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(28, 210);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(390, 66);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar Sesion";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 288);
            Controls.Add(btnCerrar);
            Controls.Add(btnEstudiantes);
            Controls.Add(btnMaestros);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEstudiantes;
        private Button btnCerrar;
    }
}