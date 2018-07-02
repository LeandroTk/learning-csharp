namespace wfaCirculo
{
    partial class Form1
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
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.btnAtribuir = new System.Windows.Forms.Button();
            this.btnDiametro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnCircunferenca = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raio";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(118, 30);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 20);
            this.txtRaio.TabIndex = 1;
            // 
            // btnAtribuir
            // 
            this.btnAtribuir.Location = new System.Drawing.Point(253, 28);
            this.btnAtribuir.Name = "btnAtribuir";
            this.btnAtribuir.Size = new System.Drawing.Size(75, 23);
            this.btnAtribuir.TabIndex = 2;
            this.btnAtribuir.Text = "Atribuir";
            this.btnAtribuir.UseVisualStyleBackColor = true;
            this.btnAtribuir.Click += new System.EventHandler(this.btnAtribuir_Click);
            // 
            // btnDiametro
            // 
            this.btnDiametro.Location = new System.Drawing.Point(52, 89);
            this.btnDiametro.Name = "btnDiametro";
            this.btnDiametro.Size = new System.Drawing.Size(75, 23);
            this.btnDiametro.TabIndex = 3;
            this.btnDiametro.Text = "Diametro";
            this.btnDiametro.UseVisualStyleBackColor = true;
            this.btnDiametro.Click += new System.EventHandler(this.btnDiametro_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(153, 89);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnCircunferenca
            // 
            this.btnCircunferenca.Location = new System.Drawing.Point(253, 89);
            this.btnCircunferenca.Name = "btnCircunferenca";
            this.btnCircunferenca.Size = new System.Drawing.Size(112, 23);
            this.btnCircunferenca.TabIndex = 5;
            this.btnCircunferenca.Text = "Circunferenca";
            this.btnCircunferenca.UseVisualStyleBackColor = true;
            this.btnCircunferenca.Click += new System.EventHandler(this.btnCircunferenca_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(140, 159);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 335);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCircunferenca);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnDiametro);
            this.Controls.Add(this.btnAtribuir);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Button btnAtribuir;
        private System.Windows.Forms.Button btnDiametro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnCircunferenca;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

