namespace Aplicacion_3__ingresar_al_sistema.Ingresa
{
    partial class Administracion_de_estudiantes
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
            Button btnEliminar;
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            textgrupo = new TextBox();
            textcarrera = new TextBox();
            label5 = new Label();
            textNocontrol = new TextBox();
            textapellidos = new TextBox();
            textnombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataestudiante = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            NoControl = new DataGridViewTextBoxColumn();
            Carrera = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            btnEditar = new Button();
            btnRegresar = new Button();
            btnEliminar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataestudiante).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(697, 569);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 47);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnRegresar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(textgrupo);
            groupBox1.Controls.Add(textcarrera);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textNocontrol);
            groupBox1.Controls.Add(textapellidos);
            groupBox1.Controls.Add(textnombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(985, 509);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Estudiante";
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(646, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 47);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(462, 397);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(162, 47);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // textgrupo
            // 
            textgrupo.Location = new Point(189, 397);
            textgrupo.Margin = new Padding(3, 4, 3, 4);
            textgrupo.Name = "textgrupo";
            textgrupo.Size = new Size(161, 39);
            textgrupo.TabIndex = 10;
            // 
            // textcarrera
            // 
            textcarrera.Location = new Point(189, 312);
            textcarrera.Margin = new Padding(3, 4, 3, 4);
            textcarrera.Name = "textcarrera";
            textcarrera.Size = new Size(161, 39);
            textcarrera.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 397);
            label5.Name = "label5";
            label5.Size = new Size(93, 31);
            label5.TabIndex = 8;
            label5.Text = "Grupo ";
            // 
            // textNocontrol
            // 
            textNocontrol.Location = new Point(189, 237);
            textNocontrol.Margin = new Padding(3, 4, 3, 4);
            textNocontrol.Name = "textNocontrol";
            textNocontrol.Size = new Size(161, 39);
            textNocontrol.TabIndex = 5;
            // 
            // textapellidos
            // 
            textapellidos.Location = new Point(189, 161);
            textapellidos.Margin = new Padding(3, 4, 3, 4);
            textapellidos.Name = "textapellidos";
            textapellidos.Size = new Size(161, 39);
            textapellidos.TabIndex = 4;
            // 
            // textnombre
            // 
            textnombre.Location = new Point(189, 91);
            textnombre.Margin = new Padding(3, 4, 3, 4);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(161, 39);
            textnombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 312);
            label4.Name = "label4";
            label4.Size = new Size(104, 31);
            label4.TabIndex = 1;
            label4.Text = "Carrera ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 237);
            label3.Name = "label3";
            label3.Size = new Size(180, 31);
            label3.TabIndex = 2;
            label3.Text = "No de control ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 161);
            label2.Name = "label2";
            label2.Size = new Size(119, 31);
            label2.TabIndex = 1;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 91);
            label1.Name = "label1";
            label1.Size = new Size(109, 31);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // dataestudiante
            // 
            dataestudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataestudiante.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellidos, NoControl, Carrera, Grupo });
            dataestudiante.Dock = DockStyle.Top;
            dataestudiante.Location = new Point(0, 509);
            dataestudiante.Margin = new Padding(3, 4, 3, 4);
            dataestudiante.Name = "dataestudiante";
            dataestudiante.RowHeadersWidth = 51;
            dataestudiante.RowTemplate.Height = 25;
            dataestudiante.Size = new Size(985, 269);
            dataestudiante.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            Apellidos.Width = 125;
            // 
            // NoControl
            // 
            NoControl.HeaderText = "No de Control ";
            NoControl.MinimumWidth = 6;
            NoControl.Name = "NoControl";
            NoControl.Width = 125;
            // 
            // Carrera
            // 
            Carrera.HeaderText = "Carrera";
            Carrera.MinimumWidth = 6;
            Carrera.Name = "Carrera";
            Carrera.Width = 125;
            // 
            // Grupo
            // 
            Grupo.HeaderText = "Grupo";
            Grupo.MinimumWidth = 6;
            Grupo.Name = "Grupo";
            Grupo.Width = 125;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(697, 516);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(162, 47);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(758, 21);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(189, 48);
            btnRegresar.TabIndex = 13;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Administracion_de_estudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 831);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dataestudiante);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Administracion_de_estudiantes";
            Text = "Administracion_de_maestros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataestudiante).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textNocontrol;
        private TextBox textapellidos;
        private TextBox textnombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private DataGridView dataestudiante;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn NoControl;
        private DataGridViewTextBoxColumn Carrera;
        private DataGridViewTextBoxColumn Grupo;
        private TextBox textgrupo;
        private TextBox textcarrera;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnRegresar;
    }
}