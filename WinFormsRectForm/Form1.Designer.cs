namespace WinFormsRectForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBorderStyle;
        private Button btnResize;
        private Button btnOpacity;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBorderStyle = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnOpacity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBorderStyle
            // 
            this.btnBorderStyle.Location = new System.Drawing.Point(30, 30);
            this.btnBorderStyle.Name = "btnBorderStyle";
            this.btnBorderStyle.Size = new System.Drawing.Size(100, 30);
            this.btnBorderStyle.TabIndex = 0;
            this.btnBorderStyle.Text = "Border Style";
            this.btnBorderStyle.UseVisualStyleBackColor = true;
            this.btnBorderStyle.Click += new System.EventHandler(this.btnBorderStyle_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(30, 70);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(100, 30);
            this.btnResize.TabIndex = 1;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnOpacity
            // 
            this.btnOpacity.Location = new System.Drawing.Point(30, 110);
            this.btnOpacity.Name = "btnOpacity";
            this.btnOpacity.Size = new System.Drawing.Size(100, 30);
            this.btnOpacity.TabIndex = 2;
            this.btnOpacity.Text = "Opacity";
            this.btnOpacity.UseVisualStyleBackColor = true;
            this.btnOpacity.Click += new System.EventHandler(this.btnOpacity_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnOpacity);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnBorderStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.Opacity = 0.75D;
            this.ResumeLayout(false);
        }
    }
}
