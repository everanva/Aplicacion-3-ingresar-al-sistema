namespace Aplicacion_3__ingresar_al_sistema.Ingresa
{
    partial class Administracion_de_vinos
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
            texttiempo = new TextBox();
            btnEditar = new Button();
            textprecio = new TextBox();
            textcantidad = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnRegresar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            textporcentajealcohol = new TextBox();
            textmaridaje = new TextBox();
            label5 = new Label();
            textsabor = new TextBox();
            texttipo = new TextBox();
            textmarca = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            datavinos = new DataGridView();
            marca = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            sabor = new DataGridViewTextBoxColumn();
            maridaje = new DataGridViewTextBoxColumn();
            porcentaje = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            tiempo = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datavinos).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(720, 342);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 35);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.BackgroundImage = Properties.Resources.descarga;
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(texttiempo);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(textprecio);
            groupBox1.Controls.Add(textcantidad);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnRegresar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(textporcentajealcohol);
            groupBox1.Controls.Add(textmaridaje);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textsabor);
            groupBox1.Controls.Add(texttipo);
            groupBox1.Controls.Add(textmarca);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(991, 382);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vinateria";
            // 
            // texttiempo
            // 
            texttiempo.Location = new Point(584, 175);
            texttiempo.Name = "texttiempo";
            texttiempo.Size = new Size(141, 33);
            texttiempo.TabIndex = 16;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(720, 298);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(142, 35);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // textprecio
            // 
            textprecio.Location = new Point(584, 124);
            textprecio.Name = "textprecio";
            textprecio.Size = new Size(141, 33);
            textprecio.TabIndex = 15;
            // 
            // textcantidad
            // 
            textcantidad.Location = new Point(584, 70);
            textcantidad.Name = "textcantidad";
            textcantidad.Size = new Size(141, 33);
            textcantidad.TabIndex = 14;
            textcantidad.TextChanged += textcantidad_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(390, 178);
            label8.Name = "label8";
            label8.Size = new Size(188, 25);
            label8.TabIndex = 0;
            label8.Text = "Tiempo de reserva ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(388, 124);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 0;
            label7.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 73);
            label6.Name = "label6";
            label6.Size = new Size(168, 25);
            label6.TabIndex = 0;
            label6.Text = "Cantidad el vino ";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(783, 178);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(165, 36);
            btnRegresar.TabIndex = 13;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(565, 298);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 35);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(404, 298);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // textporcentajealcohol
            // 
            textporcentajealcohol.Location = new Point(210, 290);
            textporcentajealcohol.Name = "textporcentajealcohol";
            textporcentajealcohol.Size = new Size(141, 33);
            textporcentajealcohol.TabIndex = 10;
            // 
            // textmaridaje
            // 
            textmaridaje.Location = new Point(210, 234);
            textmaridaje.Name = "textmaridaje";
            textmaridaje.Size = new Size(141, 33);
            textmaridaje.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 293);
            label5.Name = "label5";
            label5.Size = new Size(198, 25);
            label5.TabIndex = 8;
            label5.Text = "Porcentaje _ alcohol";
            // 
            // textsabor
            // 
            textsabor.Location = new Point(210, 178);
            textsabor.Name = "textsabor";
            textsabor.Size = new Size(141, 33);
            textsabor.TabIndex = 5;
            // 
            // texttipo
            // 
            texttipo.Location = new Point(210, 121);
            texttipo.Name = "texttipo";
            texttipo.Size = new Size(141, 33);
            texttipo.TabIndex = 4;
            // 
            // textmarca
            // 
            textmarca.Location = new Point(210, 65);
            textmarca.Name = "textmarca";
            textmarca.Size = new Size(141, 33);
            textmarca.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 234);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 1;
            label4.Text = "Maridaje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 178);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Sabor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 121);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 68);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 0;
            label1.Text = "Marca";
            // 
            // datavinos
            // 
            datavinos.BackgroundColor = Color.BurlyWood;
            datavinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datavinos.Columns.AddRange(new DataGridViewColumn[] { marca, tipo, sabor, maridaje, porcentaje, cantidad, precio, tiempo });
            datavinos.Dock = DockStyle.Top;
            datavinos.Location = new Point(0, 382);
            datavinos.Name = "datavinos";
            datavinos.ReadOnly = true;
            datavinos.RowHeadersWidth = 51;
            datavinos.RowTemplate.Height = 25;
            datavinos.Size = new Size(991, 202);
            datavinos.TabIndex = 1;
            datavinos.CellContentClick += datavinos_CellContentClick;
            datavinos.RowPostPaint += datavinos_RowPostPaint;
            // 
            // marca
            // 
            marca.HeaderText = "Marca";
            marca.MinimumWidth = 6;
            marca.Name = "marca";
            marca.ReadOnly = true;
            marca.Width = 125;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.ReadOnly = true;
            tipo.Width = 125;
            // 
            // sabor
            // 
            sabor.HeaderText = "Sabor";
            sabor.MinimumWidth = 6;
            sabor.Name = "sabor";
            sabor.ReadOnly = true;
            sabor.Width = 125;
            // 
            // maridaje
            // 
            maridaje.HeaderText = "Maridaje ";
            maridaje.MinimumWidth = 6;
            maridaje.Name = "maridaje";
            maridaje.ReadOnly = true;
            maridaje.Width = 125;
            // 
            // porcentaje
            // 
            porcentaje.HeaderText = "Porcentaje de alcohol";
            porcentaje.MinimumWidth = 6;
            porcentaje.Name = "porcentaje";
            porcentaje.ReadOnly = true;
            porcentaje.Width = 125;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad de vino";
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // tiempo
            // 
            tiempo.HeaderText = "Tiempo de reserva ";
            tiempo.Name = "tiempo";
            tiempo.ReadOnly = true;
            // 
            // Administracion_de_vinos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 623);
            Controls.Add(datavinos);
            Controls.Add(groupBox1);
            Name = "Administracion_de_vinos";
            Text = "Administracion_de_vinos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datavinos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textsabor;
        private TextBox texttipo;
        private TextBox textmarca;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private DataGridView datavinos;
        private TextBox textporcentajealcohol;
        private TextBox textmaridaje;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnRegresar;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox texttiempo;
        private TextBox textprecio;
        private TextBox textcantidad;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn sabor;
        private DataGridViewTextBoxColumn maridaje;
        private DataGridViewTextBoxColumn porcentaje;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn tiempo;
    }
}