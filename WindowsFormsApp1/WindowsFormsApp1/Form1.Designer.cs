﻿namespace WindowsFormsApp1
{
    partial class Start_Menu
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
            this.Pizza_label = new System.Windows.Forms.Label();
            this.Menu_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pizza_label
            // 
            this.Pizza_label.AutoSize = true;
            this.Pizza_label.Font = new System.Drawing.Font("Segoe Print", 130.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pizza_label.ForeColor = System.Drawing.Color.Brown;
            this.Pizza_label.Location = new System.Drawing.Point(49, 47);
            this.Pizza_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pizza_label.Name = "Pizza_label";
            this.Pizza_label.Size = new System.Drawing.Size(1004, 382);
            this.Pizza_label.TabIndex = 2;
            this.Pizza_label.Text = "Pizzeria";
            this.Pizza_label.Click += new System.EventHandler(this.Pizza_label_Click);
            // 
            // Menu_Button
            // 
            this.Menu_Button.BackColor = System.Drawing.Color.Black;
            this.Menu_Button.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu_Button.Location = new System.Drawing.Point(525, 480);
            this.Menu_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(138, 51);
            this.Menu_Button.TabIndex = 3;
            this.Menu_Button.Text = "Menu";
            this.Menu_Button.UseVisualStyleBackColor = false;
            this.Menu_Button.Click += new System.EventHandler(this.Menu_Button_Click);
            // 
            // Start_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.Menu_Button);
            this.Controls.Add(this.Pizza_label);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Start_Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pizza_label;
        private System.Windows.Forms.Button Menu_Button;
    }
}

