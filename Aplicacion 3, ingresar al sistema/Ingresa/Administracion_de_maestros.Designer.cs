namespace Aplicacion_3__ingresar_al_sistema.Ingresa
{
    partial class Administracion_de_maestros
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
            textsalario = new TextBox();
            textturno = new TextBox();
            label5 = new Label();
            textNoempleado = new TextBox();
            textapellidos = new TextBox();
            textnombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            datamaestro = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            NoEmpleado = new DataGridViewTextBoxColumn();
            Turno = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            btnEditar = new Button();
            btnRegresar = new Button();
            btnEliminar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datamaestro).BeginInit();
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
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(btnRegresar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(textsalario);
            groupBox1.Controls.Add(textturno);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textNoempleado);
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
            groupBox1.Text = "Datos del Maestro";
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
            // textsalario
            // 
            textsalario.Location = new Point(233, 397);
            textsalario.Margin = new Padding(3, 4, 3, 4);
            textsalario.Name = "textsalario";
            textsalario.Size = new Size(161, 39);
            textsalario.TabIndex = 10;
            // 
            // textturno
            // 
            textturno.Location = new Point(233, 312);
            textturno.Margin = new Padding(3, 4, 3, 4);
            textturno.Name = "textturno";
            textturno.Size = new Size(161, 39);
            textturno.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 397);
            label5.Name = "label5";
            label5.Size = new Size(90, 31);
            label5.TabIndex = 8;
            label5.Text = "Salario";
            // 
            // textNoempleado
            // 
            textNoempleado.Location = new Point(233, 237);
            textNoempleado.Margin = new Padding(3, 4, 3, 4);
            textNoempleado.Name = "textNoempleado";
            textNoempleado.Size = new Size(161, 39);
            textNoempleado.TabIndex = 5;
            textNoempleado.TextChanged += textNocontrol_TextChanged;
            // 
            // textapellidos
            // 
            textapellidos.Location = new Point(233, 161);
            textapellidos.Margin = new Padding(3, 4, 3, 4);
            textapellidos.Name = "textapellidos";
            textapellidos.Size = new Size(161, 39);
            textapellidos.TabIndex = 4;
            // 
            // textnombre
            // 
            textnombre.Location = new Point(233, 91);
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
            label4.Size = new Size(82, 31);
            label4.TabIndex = 1;
            label4.Text = "Turno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 237);
            label3.Name = "label3";
            label3.Size = new Size(205, 31);
            label3.TabIndex = 2;
            label3.Text = "No de Empleado";
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
            // datamaestro
            // 
            datamaestro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datamaestro.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellidos, NoEmpleado, Turno, Salario });
            datamaestro.Dock = DockStyle.Top;
            datamaestro.Location = new Point(0, 509);
            datamaestro.Margin = new Padding(3, 4, 3, 4);
            datamaestro.Name = "datamaestro";
            datamaestro.RowHeadersWidth = 51;
            datamaestro.RowTemplate.Height = 25;
            datamaestro.Size = new Size(985, 269);
            datamaestro.TabIndex = 1;
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
            // NoEmpleado
            // 
            NoEmpleado.HeaderText = "No de Empleado";
            NoEmpleado.MinimumWidth = 6;
            NoEmpleado.Name = "NoEmpleado";
            NoEmpleado.Width = 125;
            // 
            // Turno
            // 
            Turno.HeaderText = "Turno";
            Turno.MinimumWidth = 6;
            Turno.Name = "Turno";
            Turno.Width = 125;
            // 
            // Salario
            // 
            Salario.HeaderText = "Salario";
            Salario.MinimumWidth = 6;
            Salario.Name = "Salario";
            Salario.Width = 125;
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
            btnRegresar.Location = new Point(775, 27);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(189, 48);
            btnRegresar.TabIndex = 14;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Administracion_de_maestros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 803);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(datamaestro);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Administracion_de_maestros";
            Text = "Administracion_de_maestros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datamaestro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textNoempleado;
        private TextBox textapellidos;
        private TextBox textnombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private DataGridView datamaestro;
        private TextBox textsalario;
        private TextBox textturno;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnEditar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn NoEmpleado;
        private DataGridViewTextBoxColumn Turno;
        private DataGridViewTextBoxColumn Salario;
        private Button btnRegresar;
    }
}