﻿namespace Desktop
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
            this.kolcsonzokBox = new System.Windows.Forms.ListBox();
            this.konyvekBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kolcsonzokBox
            // 
            this.kolcsonzokBox.FormattingEnabled = true;
            this.kolcsonzokBox.Location = new System.Drawing.Point(12, 12);
            this.kolcsonzokBox.Name = "kolcsonzokBox";
            this.kolcsonzokBox.Size = new System.Drawing.Size(120, 420);
            this.kolcsonzokBox.TabIndex = 0;
            // 
            // konyvekBox
            // 
            this.konyvekBox.FormattingEnabled = true;
            this.konyvekBox.Location = new System.Drawing.Point(138, 12);
            this.konyvekBox.Name = "konyvekBox";
            this.konyvekBox.Size = new System.Drawing.Size(650, 225);
            this.konyvekBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Visszahozva";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(713, 415);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Bezár";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.konyvekBox);
            this.Controls.Add(this.kolcsonzokBox);
            this.Name = "Form1";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox kolcsonzokBox;
        private System.Windows.Forms.ListBox konyvekBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeBtn;
    }
}

