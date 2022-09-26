namespace GuessANumberV1CS
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpPlay = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoEllipsis = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblInfo.Location = new System.Drawing.Point(16, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(354, 68);
            this.lblInfo.TabIndex = 15;
            this.lblInfo.Text = "The program chooses an arbitrary number between 0 and 100.   Guess the number!";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(97, 82);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(195, 39);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "&Start New Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpPlay
            // 
            this.grpPlay.Controls.Add(this.btnOk);
            this.grpPlay.Controls.Add(this.txtNumber);
            this.grpPlay.Controls.Add(this.lblAttempts);
            this.grpPlay.Controls.Add(this.label3);
            this.grpPlay.Controls.Add(this.label2);
            this.grpPlay.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlay.Location = new System.Drawing.Point(16, 129);
            this.grpPlay.Name = "grpPlay";
            this.grpPlay.Size = new System.Drawing.Size(360, 142);
            this.grpPlay.TabIndex = 16;
            this.grpPlay.TabStop = false;
            this.grpPlay.Text = "   Playing   ";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(130, 86);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 37);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(317, 59);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(39, 28);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAttempts
            // 
            this.lblAttempts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAttempts.Location = new System.Drawing.Point(317, 29);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(39, 24);
            this.lblAttempts.TabIndex = 1;
            this.lblAttempts.Text = "Number of attempts left";
            this.lblAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of attempts left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Write your guess";
            // 
            // lblResult
            // 
            this.lblResult.AutoEllipsis = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblResult.Location = new System.Drawing.Point(12, 274);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(360, 77);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Results";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 360);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpPlay);
            this.Controls.Add(this.lblResult);
            this.Name = "MainForm";
            this.Text = "Free Game - Guess A Number";
            this.grpPlay.ResumeLayout(false);
            this.grpPlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpPlay;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
    }
}

