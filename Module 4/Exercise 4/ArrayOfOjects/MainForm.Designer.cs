﻿namespace ArrayOfOjectsTest
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
            this.btnForEach = new System.Windows.Forms.Button();
            this.btnArrayOfObjects = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForEach
            // 
            this.btnForEach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForEach.Location = new System.Drawing.Point(12, 50);
            this.btnForEach.Name = "btnForEach";
            this.btnForEach.Size = new System.Drawing.Size(282, 32);
            this.btnForEach.TabIndex = 7;
            this.btnForEach.Text = "Test of the foreach statement";
            this.btnForEach.UseVisualStyleBackColor = true;
            this.btnForEach.Click += new System.EventHandler(this.btnForEach_Click);
            // 
            // btnArrayOfObjects
            // 
            this.btnArrayOfObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrayOfObjects.Location = new System.Drawing.Point(12, 12);
            this.btnArrayOfObjects.Name = "btnArrayOfObjects";
            this.btnArrayOfObjects.Size = new System.Drawing.Size(282, 32);
            this.btnArrayOfObjects.TabIndex = 6;
            this.btnArrayOfObjects.Text = "Test Array of objects (BankLoans)";
            this.btnArrayOfObjects.UseVisualStyleBackColor = true;
            this.btnArrayOfObjects.Click += new System.EventHandler(this.btnArrayOfObjects_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(14, 113);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(279, 120);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "label1";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(16, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(277, 27);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Try me at your own risk!";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 289);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnForEach);
            this.Controls.Add(this.btnArrayOfObjects);
            this.Name = "MainForm";
            this.Text = "Array of objects";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForEach;
        private System.Windows.Forms.Button btnArrayOfObjects;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnExit;
    }
}

