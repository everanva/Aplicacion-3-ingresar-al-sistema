namespace Aplicacion_3__ingresar_al_sistema.Ingresa
{
    partial class Registrate
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textnombre = new TextBox();
            textpellido = new TextBox();
            textemail = new TextBox();
            textcontraseña = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(354, 33);
            label1.Name = "label1";
            label1.Size = new Size(162, 42);
            label1.TabIndex = 0;
            label1.Text = "Registrate ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(125, 135);
            label2.Name = "label2";
            label2.Size = new Size(113, 35);
            label2.TabIndex = 1;
            label2.Text = "Nombre ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(125, 209);
            label3.Name = "label3";
            label3.Size = new Size(115, 35);
            label3.TabIndex = 2;
            label3.Text = "Apellido ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(125, 283);
            label4.Name = "label4";
            label4.Size = new Size(84, 35);
            label4.TabIndex = 3;
            label4.Text = "Email ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(125, 345);
            label5.Name = "label5";
            label5.Size = new Size(137, 35);
            label5.TabIndex = 4;
            label5.Text = "Contraseña";
            // 
            // textnombre
            // 
            textnombre.Location = new Point(283, 141);
            textnombre.Margin = new Padding(3, 4, 3, 4);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(161, 27);
            textnombre.TabIndex = 5;
            // 
            // textpellido
            // 
            textpellido.Location = new Point(283, 209);
            textpellido.Margin = new Padding(3, 4, 3, 4);
            textpellido.Name = "textpellido";
            textpellido.Size = new Size(161, 27);
            textpellido.TabIndex = 6;
            // 
            // textemail
            // 
            textemail.Location = new Point(283, 283);
            textemail.Margin = new Padding(3, 4, 3, 4);
            textemail.Name = "textemail";
            textemail.Size = new Size(161, 27);
            textemail.TabIndex = 7;
            // 
            // textcontraseña
            // 
            textcontraseña.Location = new Point(283, 345);
            textcontraseña.Margin = new Padding(3, 4, 3, 4);
            textcontraseña.Name = "textcontraseña";
            textcontraseña.Size = new Size(161, 27);
            textcontraseña.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(354, 443);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(174, 55);
            button1.TabIndex = 9;
            button1.Text = "Registrate ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Registrate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(textcontraseña);
            Controls.Add(textemail);
            Controls.Add(textpellido);
            Controls.Add(textnombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registrate";
            Text = "Registrate";
            Load += Registrate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textnombre;
        private TextBox textpellido;
        private TextBox textemail;
        private TextBox textcontraseña;
        private Button button1;
    }
}