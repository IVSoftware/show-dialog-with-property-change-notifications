﻿
namespace show_dialog_with_property_change_notifications
{
    partial class Form2
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
            this.buttonChangeText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangeText
            // 
            this.buttonChangeText.Location = new System.Drawing.Point(24, 48);
            this.buttonChangeText.Name = "buttonChangeText";
            this.buttonChangeText.Size = new System.Drawing.Size(168, 34);
            this.buttonChangeText.TabIndex = 0;
            this.buttonChangeText.Text = "Change Text";
            this.buttonChangeText.UseVisualStyleBackColor = true;
            this.buttonChangeText.Click += new System.EventHandler(this.buttonChangeText_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.buttonChangeText);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeText;
    }
}