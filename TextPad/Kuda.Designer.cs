namespace TextPad
{
    partial class Kuda
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
            this.OK_btn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Eng_btn = new System.Windows.Forms.RadioButton();
            this.Uk_btn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(4, 145);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(154, 23);
            this.OK_btn.TabIndex = 4;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Uk_btn);
            this.groupBox1.Controls.Add(this.Eng_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Eng_btn
            // 
            this.Eng_btn.AutoSize = true;
            this.Eng_btn.Location = new System.Drawing.Point(7, 22);
            this.Eng_btn.Name = "Eng_btn";
            this.Eng_btn.Size = new System.Drawing.Size(75, 21);
            this.Eng_btn.TabIndex = 0;
            this.Eng_btn.TabStop = true;
            this.Eng_btn.Text = "English";
            this.Eng_btn.UseVisualStyleBackColor = true;
            // 
            // Uk_btn
            // 
            this.Uk_btn.AutoSize = true;
            this.Uk_btn.Checked = true;
            this.Uk_btn.Location = new System.Drawing.Point(7, 49);
            this.Uk_btn.Name = "Uk_btn";
            this.Uk_btn.Size = new System.Drawing.Size(101, 21);
            this.Uk_btn.TabIndex = 1;
            this.Uk_btn.TabStop = true;
            this.Uk_btn.Text = "Українська";
            this.Uk_btn.UseVisualStyleBackColor = true;
            // 
            // Kuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 180);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OK_btn);
            this.Name = "Kuda";
            this.Text = "Kuda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Eng_btn;
        private System.Windows.Forms.RadioButton Uk_btn;
    }
}