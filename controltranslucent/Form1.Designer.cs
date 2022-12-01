namespace controltranslucent
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
            this.userControl12 = new controltranslucent.UserControl1();
            this.userControl11 = new controltranslucent.UserControl1();
            this.SuspendLayout();
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControl12.Location = new System.Drawing.Point(-18, -17);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(67, 70);
            this.userControl12.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Orange;
            this.userControl11.Location = new System.Drawing.Point(-2, -2);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(27, 28);
            this.userControl11.TabIndex = 0;
            this.userControl11.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.userControl11_MouseDoubleClick);
            this.userControl11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userControl11_MouseDown);
            this.userControl11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.userControl11_MouseMove);
            this.userControl11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.userControl11_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(190, 151);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.54D;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private UserControl1 userControl12;
    }
}

