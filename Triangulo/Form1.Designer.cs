namespace Triangulo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.isoceles = new System.Windows.Forms.PictureBox();
            this.escaleno = new System.Windows.Forms.PictureBox();
            this.equilatero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.isoceles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escaleno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equilatero)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCalcular.Location = new System.Drawing.Point(76, 255);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 32);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Descubra!";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descubraqual é o triangulo é!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(44, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "1° Lado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(44, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "2° Lado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(44, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "3° Lado";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resultado.Location = new System.Drawing.Point(258, 274);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 8;
            // 
            // isoceles
            // 
            this.isoceles.Image = global::Triangulo.Properties.Resources.MicrosoftTeams_image__1_;
            this.isoceles.Location = new System.Drawing.Point(280, 77);
            this.isoceles.Name = "isoceles";
            this.isoceles.Size = new System.Drawing.Size(172, 155);
            this.isoceles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.isoceles.TabIndex = 11;
            this.isoceles.TabStop = false;
            this.isoceles.Visible = false;
            this.isoceles.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // escaleno
            // 
            this.escaleno.Image = global::Triangulo.Properties.Resources.MicrosoftTeams_image;
            this.escaleno.Location = new System.Drawing.Point(280, 77);
            this.escaleno.Name = "escaleno";
            this.escaleno.Size = new System.Drawing.Size(172, 155);
            this.escaleno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.escaleno.TabIndex = 10;
            this.escaleno.TabStop = false;
            this.escaleno.Visible = false;
            // 
            // equilatero
            // 
            this.equilatero.Image = global::Triangulo.Properties.Resources.MicrosoftTeams_image__2_;
            this.equilatero.Location = new System.Drawing.Point(280, 77);
            this.equilatero.Name = "equilatero";
            this.equilatero.Size = new System.Drawing.Size(172, 155);
            this.equilatero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.equilatero.TabIndex = 9;
            this.equilatero.TabStop = false;
            this.equilatero.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(510, 322);
            this.Controls.Add(this.isoceles);
            this.Controls.Add(this.escaleno);
            this.Controls.Add(this.equilatero);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.isoceles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escaleno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equilatero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.PictureBox equilatero;
        private System.Windows.Forms.PictureBox escaleno;
        private System.Windows.Forms.PictureBox isoceles;
    }
}

