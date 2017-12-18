namespace Figuras_Geometricas
{
    partial class FormCirculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_raioP = new System.Windows.Forms.TextBox();
            this.txt_raioA = new System.Windows.Forms.TextBox();
            this.txt_resultA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_resultP = new System.Windows.Forms.TextBox();
            this.b_Area = new System.Windows.Forms.Button();
            this.b_Perimetro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERIMETRO DO CIRCULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por favor digite o valor do raio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AREA DO CIRCULO";
            // 
            // txt_raioP
            // 
            this.txt_raioP.Location = new System.Drawing.Point(256, 223);
            this.txt_raioP.Name = "txt_raioP";
            this.txt_raioP.Size = new System.Drawing.Size(100, 20);
            this.txt_raioP.TabIndex = 3;
            // 
            // txt_raioA
            // 
            this.txt_raioA.Location = new System.Drawing.Point(256, 72);
            this.txt_raioA.Name = "txt_raioA";
            this.txt_raioA.Size = new System.Drawing.Size(100, 20);
            this.txt_raioA.TabIndex = 4;
            // 
            // txt_resultA
            // 
            this.txt_resultA.Location = new System.Drawing.Point(256, 150);
            this.txt_resultA.Name = "txt_resultA";
            this.txt_resultA.Size = new System.Drawing.Size(100, 20);
            this.txt_resultA.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "O VALOR DA AREA É:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Por favor digite o valor do raio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "O VALOR DO PERIMETRO É:";
            // 
            // txt_resultP
            // 
            this.txt_resultP.Location = new System.Drawing.Point(256, 296);
            this.txt_resultP.Name = "txt_resultP";
            this.txt_resultP.Size = new System.Drawing.Size(100, 20);
            this.txt_resultP.TabIndex = 9;
            // 
            // b_Area
            // 
            this.b_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Area.Location = new System.Drawing.Point(156, 113);
            this.b_Area.Name = "b_Area";
            this.b_Area.Size = new System.Drawing.Size(75, 23);
            this.b_Area.TabIndex = 10;
            this.b_Area.Text = "OK";
            this.b_Area.UseVisualStyleBackColor = true;
            this.b_Area.Click += new System.EventHandler(this.b_Area_Click);
            // 
            // b_Perimetro
            // 
            this.b_Perimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Perimetro.Location = new System.Drawing.Point(156, 258);
            this.b_Perimetro.Name = "b_Perimetro";
            this.b_Perimetro.Size = new System.Drawing.Size(75, 23);
            this.b_Perimetro.TabIndex = 11;
            this.b_Perimetro.Text = "OK";
            this.b_Perimetro.UseVisualStyleBackColor = true;
            this.b_Perimetro.Click += new System.EventHandler(this.b_Perimetro_Click);
            // 
            // FormCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Figuras_Geometricas.Properties.Resources.circulo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 346);
            this.Controls.Add(this.b_Perimetro);
            this.Controls.Add(this.b_Area);
            this.Controls.Add(this.txt_resultP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_resultA);
            this.Controls.Add(this.txt_raioA);
            this.Controls.Add(this.txt_raioP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormCirculo";
            this.Text = "FormasApp";
            this.Load += new System.EventHandler(this.FormCirculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_raioP;
        private System.Windows.Forms.TextBox txt_raioA;
        private System.Windows.Forms.TextBox txt_resultA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_resultP;
        private System.Windows.Forms.Button b_Area;
        private System.Windows.Forms.Button b_Perimetro;
    }
}