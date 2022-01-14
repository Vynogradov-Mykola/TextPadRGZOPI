namespace TextPad
{
    partial class TextFind
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
            this.Text_To_Find = new System.Windows.Forms.TextBox();
            this.Check_Match = new System.Windows.Forms.CheckBox();
            this.Check_whole = new System.Windows.Forms.CheckBox();
            this.OK_buttn = new System.Windows.Forms.Button();
            this.Cancel_buttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_To_Find
            // 
            this.Text_To_Find.Location = new System.Drawing.Point(12, 4);
            this.Text_To_Find.Name = "Text_To_Find";
            this.Text_To_Find.Size = new System.Drawing.Size(327, 22);
            this.Text_To_Find.TabIndex = 0;
            // 
            // Check_Match
            // 
            this.Check_Match.AutoSize = true;
            this.Check_Match.Location = new System.Drawing.Point(12, 38);
            this.Check_Match.Name = "Check_Match";
            this.Check_Match.Size = new System.Drawing.Size(102, 21);
            this.Check_Match.TabIndex = 2;
            this.Check_Match.Text = "Match case";
            this.Check_Match.UseVisualStyleBackColor = true;
            // 
            // Check_whole
            // 
            this.Check_whole.AutoSize = true;
            this.Check_whole.Location = new System.Drawing.Point(204, 30);
            this.Check_whole.Name = "Check_whole";
            this.Check_whole.Size = new System.Drawing.Size(109, 38);
            this.Check_whole.TabIndex = 3;
            this.Check_whole.Text = "Check whole\r\nword";
            this.Check_whole.UseVisualStyleBackColor = true;
            // 
            // OK_buttn
            // 
            this.OK_buttn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_buttn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OK_buttn.Location = new System.Drawing.Point(345, 4);
            this.OK_buttn.Name = "OK_buttn";
            this.OK_buttn.Size = new System.Drawing.Size(65, 22);
            this.OK_buttn.TabIndex = 1;
            this.OK_buttn.Text = "Ok";
            this.OK_buttn.UseVisualStyleBackColor = true;
       
            // 
            // Cancel_buttn
            // 
            this.Cancel_buttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_buttn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cancel_buttn.Location = new System.Drawing.Point(345, 36);
            this.Cancel_buttn.Name = "Cancel_buttn";
            this.Cancel_buttn.Size = new System.Drawing.Size(65, 22);
            this.Cancel_buttn.TabIndex = 4;
            this.Cancel_buttn.Text = "Cancel";
            this.Cancel_buttn.UseVisualStyleBackColor = true;
            this.Cancel_buttn.Click += new System.EventHandler(this.Cancel_buttn_Click);
            // 
            // TextFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 68);
            this.Controls.Add(this.Cancel_buttn);
            this.Controls.Add(this.OK_buttn);
            this.Controls.Add(this.Check_whole);
            this.Controls.Add(this.Check_Match);
            this.Controls.Add(this.Text_To_Find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TextFind";
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_To_Find;
        private System.Windows.Forms.CheckBox Check_Match;
        private System.Windows.Forms.CheckBox Check_whole;
        private System.Windows.Forms.Button OK_buttn;
        private System.Windows.Forms.Button Cancel_buttn;
    }
}