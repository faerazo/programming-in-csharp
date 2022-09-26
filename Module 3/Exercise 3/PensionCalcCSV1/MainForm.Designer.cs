namespace PensionCalculatorV1
{
    partial class MainForm
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
            this.btnKalk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonthlyPay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.grpUtdata = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPensionSalary = new System.Windows.Forms.Label();
            this.lblPensionYear = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.grpUtdata.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKalk
            // 
            this.btnKalk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnKalk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKalk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnKalk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnKalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.btnKalk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKalk.Location = new System.Drawing.Point(156, 180);
            this.btnKalk.Name = "btnKalk";
            this.btnKalk.Size = new System.Drawing.Size(204, 43);
            this.btnKalk.TabIndex = 2;
            this.btnKalk.Text = "&Calculate";
            this.btnKalk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKalk.UseVisualStyleBackColor = true;
            this.btnKalk.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMonthlyPay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNamn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monthly salary";
            // 
            // txtMonthlyPay
            // 
            this.txtMonthlyPay.Location = new System.Drawing.Point(350, 97);
            this.txtMonthlyPay.Name = "txtMonthlyPay";
            this.txtMonthlyPay.Size = new System.Drawing.Size(88, 22);
            this.txtMonthlyPay.TabIndex = 3;
            this.txtMonthlyPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Age (at end of current year)";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(395, 69);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(43, 22);
            this.txtAge.TabIndex = 2;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name (first name, last name";
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(210, 33);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(228, 22);
            this.txtNamn.TabIndex = 4;
            // 
            // grpUtdata
            // 
            this.grpUtdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(162)))), ((int)(((byte)(112)))));
            this.grpUtdata.Controls.Add(this.label5);
            this.grpUtdata.Controls.Add(this.lblPensionSalary);
            this.grpUtdata.Controls.Add(this.lblPensionYear);
            this.grpUtdata.Controls.Add(this.label4);
            this.grpUtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUtdata.Location = new System.Drawing.Point(15, 229);
            this.grpUtdata.Name = "grpUtdata";
            this.grpUtdata.Size = new System.Drawing.Size(457, 123);
            this.grpUtdata.TabIndex = 5;
            this.grpUtdata.TabStop = false;
            this.grpUtdata.Text = "Namn  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Monthly salary";
            // 
            // lblPensionSalary
            // 
            this.lblPensionSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionSalary.ForeColor = System.Drawing.Color.Black;
            this.lblPensionSalary.Location = new System.Drawing.Point(350, 74);
            this.lblPensionSalary.Name = "lblPensionSalary";
            this.lblPensionSalary.Size = new System.Drawing.Size(88, 18);
            this.lblPensionSalary.TabIndex = 8;
            this.lblPensionSalary.Text = "Pensionsår";
            this.lblPensionSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPensionYear
            // 
            this.lblPensionYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionYear.ForeColor = System.Drawing.Color.Black;
            this.lblPensionYear.Location = new System.Drawing.Point(369, 50);
            this.lblPensionYear.Name = "lblPensionYear";
            this.lblPensionYear.Size = new System.Drawing.Size(69, 18);
            this.lblPensionYear.TabIndex = 5;
            this.lblPensionYear.Text = "Pensionsår";
            this.lblPensionYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Retirement year";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnKalk);
            this.panel1.Controls.Add(this.grpUtdata);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 365);
            this.panel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 363);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Pension Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpUtdata.ResumeLayout(false);
            this.grpUtdata.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKalk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonthlyPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.GroupBox grpUtdata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPensionSalary;
        private System.Windows.Forms.Label lblPensionYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}

