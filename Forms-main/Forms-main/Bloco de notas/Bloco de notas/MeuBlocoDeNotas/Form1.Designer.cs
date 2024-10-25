namespace MeuBlocoDeNotas
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
            buttonAbrir = new Button();
            buttonSalvar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            Encriptar = new Button();
            Desencriptar = new Button();
            SuspendLayout();
            // 
            // buttonAbrir
            // 
            buttonAbrir.Location = new Point(0, 0);
            buttonAbrir.Name = "buttonAbrir";
            buttonAbrir.Size = new Size(75, 23);
            buttonAbrir.TabIndex = 0;
            buttonAbrir.Text = "Abrir";
            buttonAbrir.UseVisualStyleBackColor = true;
            buttonAbrir.Click += buttonAbrir_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(81, 0);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 1;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 4);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 231);
            textBox1.TabIndex = 4;
            // 
            // Encriptar
            // 
            Encriptar.Location = new Point(162, 0);
            Encriptar.Name = "Encriptar";
            Encriptar.Size = new Size(75, 23);
            Encriptar.TabIndex = 5;
            Encriptar.Text = "Encriptar";
            Encriptar.UseVisualStyleBackColor = true;
            Encriptar.Click += buttonEncriptar_Click;
            // 
            // Desencriptar
            // 
            Desencriptar.Location = new Point(243, 0);
            Desencriptar.Name = "Desencriptar";
            Desencriptar.Size = new Size(90, 23);
            Desencriptar.TabIndex = 6;
            Desencriptar.Text = "Desencriptar";
            Desencriptar.UseVisualStyleBackColor = true;
            Desencriptar.Click += buttonDesencriptar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 267);
            Controls.Add(Desencriptar);
            Controls.Add(Encriptar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonAbrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAbrir;
        private Button buttonSalvar;
        private Label label1;
        private TextBox textBox1;
        private Button Encriptar;
        private Button Desencriptar;
    }
}
