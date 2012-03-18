namespace EveOnline
{
    partial class LocationConfig
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
            this.button1 = new System.Windows.Forms.Button();
            this.SelectPhoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pointImage1 = new EveOnline.control.PointImage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pointImage2 = new EveOnline.control.PointImage();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectPhoto
            // 
            this.SelectPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectPhoto.Location = new System.Drawing.Point(3, 33);
            this.SelectPhoto.Name = "SelectPhoto";
            this.SelectPhoto.Size = new System.Drawing.Size(64, 64);
            this.SelectPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectPhoto.TabIndex = 2;
            this.SelectPhoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.SelectPhoto);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 768);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Check";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pointImage1
            // 
            this.pointImage1.Location = new System.Drawing.Point(178, 341);
            this.pointImage1.Name = "pointImage1";
            this.pointImage1.Size = new System.Drawing.Size(16, 16);
            this.pointImage1.TabIndex = 1;
            this.pointImage1.Text = "pointImage1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pointImage2
            // 
            this.pointImage2.Location = new System.Drawing.Point(23, 516);
            this.pointImage2.Name = "pointImage2";
            this.pointImage2.Size = new System.Drawing.Size(16, 16);
            this.pointImage2.TabIndex = 4;
            this.pointImage2.Text = "pointImage2";
            // 
            // LocationConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1024, 868);
            this.Controls.Add(this.pointImage2);
            this.Controls.Add(this.pointImage1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocationConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LocationConfig";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.SelectPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private control.PointImage pointImage1;
        private System.Windows.Forms.PictureBox SelectPhoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private control.PointImage pointImage2;
    }
}