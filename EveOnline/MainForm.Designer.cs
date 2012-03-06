using System;

namespace EveOnline
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Point2 = new System.Windows.Forms.Button();
            this.Point1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RunStopButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Point2);
            this.panel1.Controls.Add(this.Point1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 768);
            this.panel1.TabIndex = 0;
            // 
            // Point2
            // 
            this.Point2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Point2.Location = new System.Drawing.Point(65, 293);
            this.Point2.Name = "Point2";
            this.Point2.Size = new System.Drawing.Size(16, 23);
            this.Point2.TabIndex = 1;
            this.Point2.TabStop = false;
            this.Point2.Text = "2";
            this.Point2.UseVisualStyleBackColor = true;
            // 
            // Point1
            // 
            this.Point1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Point1.Location = new System.Drawing.Point(65, 452);
            this.Point1.Name = "Point1";
            this.Point1.Size = new System.Drawing.Size(16, 23);
            this.Point1.TabIndex = 0;
            this.Point1.TabStop = false;
            this.Point1.Text = "1";
            this.Point1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.PlayerPannel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 768);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 72);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // RunStopButton
            // 
            this.RunStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RunStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunStopButton.Location = new System.Drawing.Point(6, 3);
            this.RunStopButton.Name = "RunStopButton";
            this.RunStopButton.Size = new System.Drawing.Size(56, 23);
            this.RunStopButton.TabIndex = 4;
            this.RunStopButton.Text = "Run";
            this.RunStopButton.UseVisualStyleBackColor = true;
            this.RunStopButton.Click += new System.EventHandler(this.RunStopButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Location = new System.Drawing.Point(68, 3);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(23, 23);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "X";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(815, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello, World.";
            // 
            // PlayerPannel
            // 
            this.PlayerPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlayerPannel.Location = new System.Drawing.Point(0, 0);
            this.PlayerPannel.Name = "PlayerPannel";
            this.PlayerPannel.Size = new System.Drawing.Size(320, 72);
            this.PlayerPannel.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RunStopButton);
            this.panel3.Controls.Add(this.QuitButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(927, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 72);
            this.panel3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(400, 293);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 23);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "3";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(264, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hello, World. How are you today?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 840);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button Point2;
        private System.Windows.Forms.Button Point1;
        private System.Windows.Forms.Button RunStopButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel PlayerPannel;
        private System.Windows.Forms.Button button1;



    }
}