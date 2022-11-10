namespace DrawPointsCS
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
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lstPoints = new System.Windows.Forms.ListBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpOutput.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.Label3);
            this.grpOutput.Controls.Add(this.Label2);
            this.grpOutput.Controls.Add(this.lstPoints);
            this.grpOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOutput.Location = new System.Drawing.Point(13, 131);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOutput.Size = new System.Drawing.Size(245, 344);
            this.grpOutput.TabIndex = 14;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Registered points";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(187, 22);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 20);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "currY";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(91, 22);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 20);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "currX";
            // 
            // lstPoints
            // 
            this.lstPoints.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPoints.ItemHeight = 17;
            this.lstPoints.Location = new System.Drawing.Point(11, 49);
            this.lstPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPoints.Name = "lstPoints";
            this.lstPoints.Size = new System.Drawing.Size(223, 276);
            this.lstPoints.TabIndex = 9;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnOK);
            this.grpInput.Controls.Add(this.txtPoints);
            this.grpInput.Controls.Add(this.Label1);
            this.grpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(12, 15);
            this.grpInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInput.Size = new System.Drawing.Size(331, 108);
            this.grpInput.TabIndex = 13;
            this.grpInput.TabStop = false;
            this.grpInput.Text = " Input ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(117, 69);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(149, 30);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(213, 30);
            this.txtPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(105, 26);
            this.txtPoints.TabIndex = 2;
            this.txtPoints.Text = "TextBox1";
            this.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(11, 30);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(208, 30);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Num of Points to Save";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(57, 492);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 28);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(21, 549);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(841, 29);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Text = "label4";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 575);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Draw points";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpOutput;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ListBox lstPoints;
        internal System.Windows.Forms.GroupBox grpInput;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.TextBox txtPoints;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMessage;
    }
}

