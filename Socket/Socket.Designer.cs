namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Maco = new System.Windows.Forms.CheckBox();
            this.Longitud = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Desconnecta = new System.Windows.Forms.Button();
            this.Connecta = new System.Windows.Forms.Button();
            this.Grandesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Alt = new System.Windows.Forms.CheckBox();
            this.Palindrom = new System.Windows.Forms.CheckBox();
            this.Majuscula = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Maco
            // 
            this.Maco.AutoSize = true;
            this.Maco.Location = new System.Drawing.Point(15, 49);
            this.Maco.Name = "Maco";
            this.Maco.Size = new System.Drawing.Size(53, 17);
            this.Maco.TabIndex = 1;
            this.Maco.Text = "Maco";
            this.Maco.UseVisualStyleBackColor = true;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(15, 72);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(70, 17);
            this.Longitud.TabIndex = 2;
            this.Longitud.Text = "Longitud ";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(47, 23);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 20);
            this.Nom.TabIndex = 4;
            // 
            // Desconnecta
            // 
            this.Desconnecta.Location = new System.Drawing.Point(207, 122);
            this.Desconnecta.Name = "Desconnecta";
            this.Desconnecta.Size = new System.Drawing.Size(79, 23);
            this.Desconnecta.TabIndex = 5;
            this.Desconnecta.Text = "Desconnecta";
            this.Desconnecta.UseVisualStyleBackColor = true;
            this.Desconnecta.Click += new System.EventHandler(this.Desconnecta_Click);
            // 
            // Connecta
            // 
            this.Connecta.Location = new System.Drawing.Point(15, 122);
            this.Connecta.Name = "Connecta";
            this.Connecta.Size = new System.Drawing.Size(75, 23);
            this.Connecta.TabIndex = 6;
            this.Connecta.Text = "Connecta";
            this.Connecta.UseVisualStyleBackColor = true;
            this.Connecta.Click += new System.EventHandler(this.Connecta_Click);
            // 
            // Grandesa
            // 
            this.Grandesa.Location = new System.Drawing.Point(186, 69);
            this.Grandesa.Name = "Grandesa";
            this.Grandesa.Size = new System.Drawing.Size(100, 20);
            this.Grandesa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Grandesa";
            // 
            // Alt
            // 
            this.Alt.AutoSize = true;
            this.Alt.Location = new System.Drawing.Point(15, 96);
            this.Alt.Name = "Alt";
            this.Alt.Size = new System.Drawing.Size(38, 17);
            this.Alt.TabIndex = 9;
            this.Alt.Text = "Alt";
            this.Alt.UseVisualStyleBackColor = true;
            // 
            // Palindrom
            // 
            this.Palindrom.AutoSize = true;
            this.Palindrom.Location = new System.Drawing.Point(94, 49);
            this.Palindrom.Name = "Palindrom";
            this.Palindrom.Size = new System.Drawing.Size(72, 17);
            this.Palindrom.TabIndex = 10;
            this.Palindrom.Text = "Palindrom";
            this.Palindrom.UseVisualStyleBackColor = true;
            // 
            // Majuscula
            // 
            this.Majuscula.AutoSize = true;
            this.Majuscula.Location = new System.Drawing.Point(94, 73);
            this.Majuscula.Name = "Majuscula";
            this.Majuscula.Size = new System.Drawing.Size(74, 17);
            this.Majuscula.TabIndex = 11;
            this.Majuscula.Text = "Majuscula";
            this.Majuscula.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 162);
            this.Controls.Add(this.Majuscula);
            this.Controls.Add(this.Palindrom);
            this.Controls.Add(this.Alt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grandesa);
            this.Controls.Add(this.Connecta);
            this.Controls.Add(this.Desconnecta);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Longitud);
            this.Controls.Add(this.Maco);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Maco;
        private System.Windows.Forms.CheckBox Longitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Button Desconnecta;
        private System.Windows.Forms.Button Connecta;
        private System.Windows.Forms.TextBox Grandesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Alt;
        private System.Windows.Forms.CheckBox Palindrom;
        private System.Windows.Forms.CheckBox Majuscula;
    }
}

