namespace StochasticProcessSimulator
{
    partial class A20_Form
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
            this.specting_label = new System.Windows.Forms.Label();
            this.spectingPoint_trackbar = new System.Windows.Forms.TrackBar();
            this.mean_label = new System.Windows.Forms.Label();
            this.deviation_label = new System.Windows.Forms.Label();
            this.noPoints_label = new System.Windows.Forms.Label();
            this.noPath_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mean_trackbar = new System.Windows.Forms.TrackBar();
            this.deviation_trackbar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.draw_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.noPoints_trackbar = new System.Windows.Forms.TrackBar();
            this.noPaths_trackbar = new System.Windows.Forms.TrackBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.startingPoint_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spectingPoint_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mean_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviation_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPoints_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPaths_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // specting_label
            // 
            this.specting_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.specting_label.AutoSize = true;
            this.specting_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.specting_label.ForeColor = System.Drawing.Color.White;
            this.specting_label.Location = new System.Drawing.Point(367, 613);
            this.specting_label.Name = "specting_label";
            this.specting_label.Size = new System.Drawing.Size(34, 17);
            this.specting_label.TabIndex = 69;
            this.specting_label.Text = "Spec";
            // 
            // spectingPoint_trackbar
            // 
            this.spectingPoint_trackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spectingPoint_trackbar.Location = new System.Drawing.Point(270, 633);
            this.spectingPoint_trackbar.Maximum = 520;
            this.spectingPoint_trackbar.Minimum = 1;
            this.spectingPoint_trackbar.Name = "spectingPoint_trackbar";
            this.spectingPoint_trackbar.Size = new System.Drawing.Size(861, 45);
            this.spectingPoint_trackbar.TabIndex = 68;
            this.spectingPoint_trackbar.TickFrequency = 100;
            this.spectingPoint_trackbar.Value = 5;
            this.spectingPoint_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spectingPoint_trackbar_MouseUp);
            // 
            // mean_label
            // 
            this.mean_label.AutoSize = true;
            this.mean_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.mean_label.ForeColor = System.Drawing.Color.White;
            this.mean_label.Location = new System.Drawing.Point(28, 420);
            this.mean_label.Name = "mean_label";
            this.mean_label.Size = new System.Drawing.Size(156, 17);
            this.mean_label.TabIndex = 66;
            this.mean_label.Text = "Number of points per path";
            // 
            // deviation_label
            // 
            this.deviation_label.AutoSize = true;
            this.deviation_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.deviation_label.ForeColor = System.Drawing.Color.White;
            this.deviation_label.Location = new System.Drawing.Point(28, 306);
            this.deviation_label.Name = "deviation_label";
            this.deviation_label.Size = new System.Drawing.Size(156, 17);
            this.deviation_label.TabIndex = 65;
            this.deviation_label.Text = "Number of points per path";
            // 
            // noPoints_label
            // 
            this.noPoints_label.AutoSize = true;
            this.noPoints_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.noPoints_label.ForeColor = System.Drawing.Color.White;
            this.noPoints_label.Location = new System.Drawing.Point(28, 197);
            this.noPoints_label.Name = "noPoints_label";
            this.noPoints_label.Size = new System.Drawing.Size(156, 17);
            this.noPoints_label.TabIndex = 64;
            this.noPoints_label.Text = "Number of points per path";
            // 
            // noPath_label
            // 
            this.noPath_label.AutoSize = true;
            this.noPath_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.noPath_label.ForeColor = System.Drawing.Color.White;
            this.noPath_label.Location = new System.Drawing.Point(31, 94);
            this.noPath_label.Name = "noPath_label";
            this.noPath_label.Size = new System.Drawing.Size(102, 17);
            this.noPath_label.TabIndex = 63;
            this.noPath_label.Text = "Number of paths";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Mean μ";
            // 
            // mean_trackbar
            // 
            this.mean_trackbar.Location = new System.Drawing.Point(31, 388);
            this.mean_trackbar.Maximum = 100;
            this.mean_trackbar.Minimum = -100;
            this.mean_trackbar.Name = "mean_trackbar";
            this.mean_trackbar.Size = new System.Drawing.Size(200, 45);
            this.mean_trackbar.TabIndex = 61;
            this.mean_trackbar.TickFrequency = 0;
            this.mean_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mean_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mean_trackbar_MouseUp);
            // 
            // deviation_trackbar
            // 
            this.deviation_trackbar.Location = new System.Drawing.Point(31, 278);
            this.deviation_trackbar.Maximum = 100;
            this.deviation_trackbar.Minimum = 1;
            this.deviation_trackbar.Name = "deviation_trackbar";
            this.deviation_trackbar.Size = new System.Drawing.Size(200, 45);
            this.deviation_trackbar.TabIndex = 60;
            this.deviation_trackbar.TickFrequency = 100;
            this.deviation_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.deviation_trackbar.Value = 10;
            this.deviation_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.deviation_trackbar_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Deviation σ ";
            // 
            // draw_button
            // 
            this.draw_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.draw_button.BackColor = System.Drawing.Color.DarkGray;
            this.draw_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw_button.ForeColor = System.Drawing.Color.Black;
            this.draw_button.Location = new System.Drawing.Point(31, 645);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(140, 33);
            this.draw_button.TabIndex = 58;
            this.draw_button.Text = "Retry";
            this.draw_button.UseVisualStyleBackColor = false;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Number of points per path (n)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Number of paths (m)";
            // 
            // noPoints_trackbar
            // 
            this.noPoints_trackbar.Location = new System.Drawing.Point(31, 165);
            this.noPoints_trackbar.Maximum = 1000;
            this.noPoints_trackbar.Minimum = 2;
            this.noPoints_trackbar.Name = "noPoints_trackbar";
            this.noPoints_trackbar.Size = new System.Drawing.Size(200, 45);
            this.noPoints_trackbar.TabIndex = 55;
            this.noPoints_trackbar.TickFrequency = 1000;
            this.noPoints_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.noPoints_trackbar.Value = 520;
            this.noPoints_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.noPoints_trackbar_MouseUp);
            // 
            // noPaths_trackbar
            // 
            this.noPaths_trackbar.Location = new System.Drawing.Point(31, 62);
            this.noPaths_trackbar.Maximum = 2000;
            this.noPaths_trackbar.Minimum = 1;
            this.noPaths_trackbar.Name = "noPaths_trackbar";
            this.noPaths_trackbar.Size = new System.Drawing.Size(200, 45);
            this.noPaths_trackbar.TabIndex = 54;
            this.noPaths_trackbar.Tag = "";
            this.noPaths_trackbar.TickFrequency = 1000;
            this.noPaths_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.noPaths_trackbar.Value = 1000;
            this.noPaths_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.noPaths_trackbar_MouseUp);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.pictureBox.Location = new System.Drawing.Point(270, 81);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1131, 491);
            this.pictureBox.TabIndex = 67;
            this.pictureBox.TabStop = false;
            // 
            // startingPoint_label
            // 
            this.startingPoint_label.AutoSize = true;
            this.startingPoint_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.startingPoint_label.ForeColor = System.Drawing.Color.White;
            this.startingPoint_label.Location = new System.Drawing.Point(28, 477);
            this.startingPoint_label.Name = "startingPoint_label";
            this.startingPoint_label.Size = new System.Drawing.Size(85, 51);
            this.startingPoint_label.TabIndex = 106;
            this.startingPoint_label.Text = "Starting point\r\n\r\ny = 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.label4.Font = new System.Drawing.Font("Calibri Light", 30F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(270, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(678, 49);
            this.label4.TabIndex = 107;
            this.label4.Text = "y(t) = y(t-1) + µ (1/n) + σ N(0, 1) √(1/n)";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(267, 613);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 108;
            this.label6.Text = "Inspecting time";
            // 
            // A20_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startingPoint_label);
            this.Controls.Add(this.specting_label);
            this.Controls.Add(this.spectingPoint_trackbar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.mean_label);
            this.Controls.Add(this.deviation_label);
            this.Controls.Add(this.noPoints_label);
            this.Controls.Add(this.noPath_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mean_trackbar);
            this.Controls.Add(this.deviation_trackbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.draw_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noPoints_trackbar);
            this.Controls.Add(this.noPaths_trackbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "A20_Form";
            this.Text = "Brownian Motion - Stochastic Process Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.spectingPoint_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mean_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviation_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPoints_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPaths_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label specting_label;
        private System.Windows.Forms.TrackBar spectingPoint_trackbar;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label mean_label;
        private System.Windows.Forms.Label deviation_label;
        private System.Windows.Forms.Label noPoints_label;
        private System.Windows.Forms.Label noPath_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar mean_trackbar;
        private System.Windows.Forms.TrackBar deviation_trackbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar noPoints_trackbar;
        private System.Windows.Forms.TrackBar noPaths_trackbar;
        private System.Windows.Forms.Label startingPoint_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}