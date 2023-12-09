namespace stupidGX
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
            this.webbrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gosearch = new System.Windows.Forms.Button();
            this.switchengine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webbrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // webbrowser
            // 
            this.webbrowser.AllowExternalDrop = true;
            this.webbrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webbrowser.CreationProperties = null;
            this.webbrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webbrowser.Location = new System.Drawing.Point(1, 34);
            this.webbrowser.Name = "webbrowser";
            this.webbrowser.Size = new System.Drawing.Size(797, 415);
            this.webbrowser.TabIndex = 0;
            this.webbrowser.ZoomFactor = 1D;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(23, 23);
            this.back.TabIndex = 1;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(41, 5);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(23, 23);
            this.forward.TabIndex = 2;
            this.forward.Text = ">";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(70, 5);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(50, 23);
            this.reload.TabIndex = 3;
            this.reload.Text = "reload";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(568, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gosearch
            // 
            this.gosearch.Location = new System.Drawing.Point(700, 5);
            this.gosearch.Name = "gosearch";
            this.gosearch.Size = new System.Drawing.Size(55, 23);
            this.gosearch.TabIndex = 5;
            this.gosearch.Text = "search";
            this.gosearch.UseVisualStyleBackColor = true;
            this.gosearch.Click += new System.EventHandler(this.gosearch_Click);
            // 
            // switchengine
            // 
            this.switchengine.Location = new System.Drawing.Point(761, 5);
            this.switchengine.Name = "switchengine";
            this.switchengine.Size = new System.Drawing.Size(27, 23);
            this.switchengine.TabIndex = 6;
            this.switchengine.Text = "...";
            this.switchengine.UseVisualStyleBackColor = true;
            this.switchengine.Click += new System.EventHandler(this.switchengine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.switchengine);
            this.Controls.Add(this.gosearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.webbrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webbrowser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webbrowser;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button gosearch;
        private System.Windows.Forms.Button switchengine;
    }
}

