
namespace show_dialog_with_property_change_notifications
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxShowForm2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxShowForm2
            // 
            this.checkBoxShowForm2.AutoSize = true;
            this.checkBoxShowForm2.Location = new System.Drawing.Point(30, 36);
            this.checkBoxShowForm2.Name = "checkBoxShowForm2";
            this.checkBoxShowForm2.Size = new System.Drawing.Size(139, 29);
            this.checkBoxShowForm2.TabIndex = 0;
            this.checkBoxShowForm2.Text = "Show Form2";
            this.checkBoxShowForm2.UseVisualStyleBackColor = true;
            this.checkBoxShowForm2.CheckedChanged += new System.EventHandler(this.checkBoxShowForm2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(30, 87);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "No Text Received";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxShowForm2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowForm2;
        private System.Windows.Forms.Label label1;
    }
}

