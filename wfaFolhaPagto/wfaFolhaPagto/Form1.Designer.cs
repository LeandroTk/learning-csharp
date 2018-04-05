namespace wfaFolhaPagto
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.dependentsNumberInput = new System.Windows.Forms.TextBox();
            this.HourValueInput = new System.Windows.Forms.TextBox();
            this.workHoursInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtInss = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtLiquidSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(182, 23);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 0;
            // 
            // dependentsNumberInput
            // 
            this.dependentsNumberInput.Location = new System.Drawing.Point(182, 149);
            this.dependentsNumberInput.Name = "dependentsNumberInput";
            this.dependentsNumberInput.Size = new System.Drawing.Size(100, 20);
            this.dependentsNumberInput.TabIndex = 4;
            // 
            // HourValueInput
            // 
            this.HourValueInput.Location = new System.Drawing.Point(182, 105);
            this.HourValueInput.Name = "HourValueInput";
            this.HourValueInput.Size = new System.Drawing.Size(100, 20);
            this.HourValueInput.TabIndex = 3;
            // 
            // workHoursInput
            // 
            this.workHoursInput.Location = new System.Drawing.Point(182, 61);
            this.workHoursInput.Name = "workHoursInput";
            this.workHoursInput.Size = new System.Drawing.Size(100, 20);
            this.workHoursInput.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nome do Funcionário";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Num. Dependentes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Valor da Hora";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Horas trabalhadas";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(43, 211);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calcular";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(255, 211);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 9;
            this.endButton.Text = "Fim";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(152, 211);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Limpar";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Salário Bruto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "INSS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 360);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Imposto de Renda";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 407);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Salário Líquido";
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Location = new System.Drawing.Point(182, 273);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 15;
            // 
            // txtInss
            // 
            this.txtInss.Enabled = false;
            this.txtInss.Location = new System.Drawing.Point(182, 316);
            this.txtInss.Name = "txtInss";
            this.txtInss.Size = new System.Drawing.Size(100, 20);
            this.txtInss.TabIndex = 16;
            // 
            // txtTax
            // 
            this.txtTax.Enabled = false;
            this.txtTax.Location = new System.Drawing.Point(182, 360);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 17;
            // 
            // txtLiquidSalary
            // 
            this.txtLiquidSalary.Enabled = false;
            this.txtLiquidSalary.Location = new System.Drawing.Point(182, 407);
            this.txtLiquidSalary.Name = "txtLiquidSalary";
            this.txtLiquidSalary.Size = new System.Drawing.Size(100, 20);
            this.txtLiquidSalary.TabIndex = 18;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(544, 571);
            this.Controls.Add(this.txtLiquidSalary);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtInss);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.workHoursInput);
            this.Controls.Add(this.HourValueInput);
            this.Controls.Add(this.dependentsNumberInput);
            this.Controls.Add(this.nameInput);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox workHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hourValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dependentsNumber;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox dependentsNumberInput;
        private System.Windows.Forms.TextBox HourValueInput;
        private System.Windows.Forms.TextBox workHoursInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtInss;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtLiquidSalary;
    }
}

