namespace stupidGX
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.passwordtext1 = new System.Windows.Forms.TextBox();
            this.passwordtext2 = new System.Windows.Forms.TextBox();
            this.passwordtext3 = new System.Windows.Forms.TextBox();
            this.passwordtext4 = new System.Windows.Forms.TextBox();
            this.savepswrd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // passwordtext1
            // 
            this.passwordtext1.Location = new System.Drawing.Point(12, 11);
            this.passwordtext1.Name = "passwordtext1";
            this.passwordtext1.Size = new System.Drawing.Size(263, 20);
            this.passwordtext1.TabIndex = 1;
            this.passwordtext1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordtext2
            // 
            this.passwordtext2.Location = new System.Drawing.Point(12, 37);
            this.passwordtext2.Name = "passwordtext2";
            this.passwordtext2.Size = new System.Drawing.Size(263, 20);
            this.passwordtext2.TabIndex = 3;
            // 
            // passwordtext3
            // 
            this.passwordtext3.Location = new System.Drawing.Point(12, 63);
            this.passwordtext3.Name = "passwordtext3";
            this.passwordtext3.Size = new System.Drawing.Size(263, 20);
            this.passwordtext3.TabIndex = 5;
            // 
            // passwordtext4
            // 
            this.passwordtext4.Location = new System.Drawing.Point(12, 89);
            this.passwordtext4.Name = "passwordtext4";
            this.passwordtext4.Size = new System.Drawing.Size(263, 20);
            this.passwordtext4.TabIndex = 6;
            // 
            // savepswrd
            // 
            this.savepswrd.Location = new System.Drawing.Point(12, 115);
            this.savepswrd.Name = "savepswrd";
            this.savepswrd.Size = new System.Drawing.Size(43, 23);
            this.savepswrd.TabIndex = 7;
            this.savepswrd.Text = "save";
            this.savepswrd.UseVisualStyleBackColor = true;
            this.savepswrd.Click += new System.EventHandler(this.savepswrd_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.savepswrd);
            this.Controls.Add(this.passwordtext4);
            this.Controls.Add(this.passwordtext3);
            this.Controls.Add(this.passwordtext2);
            this.Controls.Add(this.passwordtext1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox passwordtext1;
        private System.Windows.Forms.TextBox passwordtext2;
        private System.Windows.Forms.TextBox passwordtext3;
        private System.Windows.Forms.TextBox passwordtext4;
        private System.Windows.Forms.Button savepswrd;
    }
}