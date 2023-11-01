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
            textContraseña = new TextBox();
            label1 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            SuspendLayout();
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(329, 172);
            textUsuario.Margin = new Padding(3, 4, 3, 4);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "Usuario";
            textUsuario.Size = new Size(212, 27);
            textUsuario.TabIndex = 0;
            textUsuario.TextChanged += textUsuario_TextChanged;
            // 
            // textContraseña
            // 
            textContraseña.Location = new Point(329, 239);
            textContraseña.Margin = new Padding(3, 4, 3, 4);
            textContraseña.Name = "textContraseña";
            textContraseña.PasswordChar = '*';
            textContraseña.PlaceholderText = "Contraseña";
            textContraseña.Size = new Size(212, 27);
            textContraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(353, 89);
            label1.Name = "label1";
            label1.Size = new Size(178, 53);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido ";
            // 
            // button1
            // 
            button1.Location = new Point(346, 300);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(174, 59);
            button1.TabIndex = 3;
            button1.Text = "Ingresar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(402, 399);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrate";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 367);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 5;
            label2.Text = "Si no tienes una cuenta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textContraseña);
            Controls.Add(textUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsuario;
        private TextBox textContraseña;
        private Label label1;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label2;
    }
}