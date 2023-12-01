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
            btnEstudiantes = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.Location = new Point(24, 30);
            btnEstudiantes.Margin = new Padding(3, 2, 3, 2);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(341, 50);
            btnEstudiantes.TabIndex = 1;
            btnEstudiantes.Text = "Administrar vinos";
            btnEstudiantes.UseVisualStyleBackColor = true;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(12, 115);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(341, 50);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar Sesion";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.descarga__1_;
            ClientSize = new Size(387, 216);
            Controls.Add(btnCerrar);
            Controls.Add(btnEstudiantes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEstudiantes;
        private Button btnCerrar;
    }
}