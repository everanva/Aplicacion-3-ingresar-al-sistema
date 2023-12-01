namespace Aplicacion_3__ingresar_al_sistema
{
    partial class Form1
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
            textUsuario = new TextBox();
            textContrasena = new TextBox();
            label1 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            SuspendLayout();
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(288, 129);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "Usuario";
            textUsuario.Size = new Size(186, 23);
            textUsuario.TabIndex = 0;
            textUsuario.TextChanged += textUsuario_TextChanged;
            // 
            // textContraseña
            // 
            textContrasena.Location = new Point(288, 179);
            textContrasena.Name = "textContraseña";
            textContrasena.PasswordChar = '*';
            textContrasena.PlaceholderText = "Contraseña";
            textContrasena.Size = new Size(186, 23);
            textContrasena.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(309, 67);
            label1.Name = "label1";
            label1.Size = new Size(146, 43);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido ";
            // 
            // button1
            // 
            button1.Location = new Point(303, 225);
            button1.Name = "button1";
            button1.Size = new Size(152, 44);
            button1.TabIndex = 3;
            button1.Text = "Ingresar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(352, 299);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrate";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 275);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 5;
            label2.Text = "Si no tienes una cuenta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textContrasena);
            Controls.Add(textUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsuario;
        private TextBox textContrasena;
        private Label label1;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label2;
    }
}