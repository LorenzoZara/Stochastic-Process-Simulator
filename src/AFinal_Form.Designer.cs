
namespace StochasticProcessSimulator
{
    partial class AFinal_Form
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
            this.startingPoint_label = new System.Windows.Forms.Label();
            this.startingPoint_trackbar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.scale_checkBox = new System.Windows.Forms.CheckBox();
            this.specting_label = new System.Windows.Forms.Label();
            this.spectingPoint_trackbar = new System.Windows.Forms.TrackBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.poisson_label = new System.Windows.Forms.Label();
            this.poisson_trackbar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startingPoint_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectingPoint_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mean_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviation_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPoints_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPaths_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisson_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // startingPoint_label
            // 
            this.startingPoint_label.AutoSize = true;
            this.startingPoint_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.startingPoint_label.ForeColor = System.Drawing.Color.White;
            this.startingPoint_label.Location = new System.Drawing.Point(15, 570);
            this.startingPoint_label.Name = "startingPoint_label";
            this.startingPoint_label.Size = new System.Drawing.Size(156, 17);
            this.startingPoint_label.TabIndex = 153;
            this.startingPoint_label.Text = "Number of points per path";
            // 
            // startingPoint_trackbar
            // 
            this.startingPoint_trackbar.LargeChange = 1;
            this.startingPoint_trackbar.Location = new System.Drawing.Point(18, 538);
            this.startingPoint_trackbar.Maximum = 200;
            this.startingPoint_trackbar.Minimum = 1;
            this.startingPoint_trackbar.Name = "startingPoint_trackbar";
            this.startingPoint_trackbar.Size = new System.Drawing.Size(235, 45);
            this.startingPoint_trackbar.TabIndex = 152;
            this.startingPoint_trackbar.TickFrequency = 100;
            this.startingPoint_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.startingPoint_trackbar.Value = 1;
            this.startingPoint_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.startingPoint_trackbar_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 151;
            this.label7.Text = "Initial price";
            // 
            // scale_checkBox
            // 
            this.scale_checkBox.AutoSize = true;
            this.scale_checkBox.Checked = true;
            this.scale_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scale_checkBox.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.scale_checkBox.ForeColor = System.Drawing.Color.White;
            this.scale_checkBox.Location = new System.Drawing.Point(268, 70);
            this.scale_checkBox.Name = "scale_checkBox";
            this.scale_checkBox.Size = new System.Drawing.Size(56, 21);
            this.scale_checkBox.TabIndex = 150;
            this.scale_checkBox.Text = "Scale";
            this.scale_checkBox.UseVisualStyleBackColor = true;
            this.scale_checkBox.Click += new System.EventHandler(this.scale_checkBox_CheckedChanged);
            // 
            // specting_label
            // 
            this.specting_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specting_label.AutoSize = true;
            this.specting_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.specting_label.ForeColor = System.Drawing.Color.White;
            this.specting_label.Location = new System.Drawing.Point(362, 609);
            this.specting_label.Name = "specting_label";
            this.specting_label.Size = new System.Drawing.Size(34, 17);
            this.specting_label.TabIndex = 145;
            this.specting_label.Text = "Spec";
            // 
            // spectingPoint_trackbar
            // 
            this.spectingPoint_trackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spectingPoint_trackbar.Location = new System.Drawing.Point(268, 629);
            this.spectingPoint_trackbar.Maximum = 520;
            this.spectingPoint_trackbar.Name = "spectingPoint_trackbar";
            this.spectingPoint_trackbar.Size = new System.Drawing.Size(861, 45);
            this.spectingPoint_trackbar.TabIndex = 144;
            this.spectingPoint_trackbar.TickFrequency = 100;
            this.spectingPoint_trackbar.Value = 5;
            this.spectingPoint_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spectingPoint_trackbar_MouseUp);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.pictureBox.Location = new System.Drawing.Point(268, 91);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1131, 485);
            this.pictureBox.TabIndex = 143;
            this.pictureBox.TabStop = false;
            // 
            // mean_label
            // 
            this.mean_label.AutoSize = true;
            this.mean_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.mean_label.ForeColor = System.Drawing.Color.White;
            this.mean_label.Location = new System.Drawing.Point(14, 381);
            this.mean_label.Name = "mean_label";
            this.mean_label.Size = new System.Drawing.Size(156, 17);
            this.mean_label.TabIndex = 142;
            this.mean_label.Text = "Number of points per path";
            // 
            // deviation_label
            // 
            this.deviation_label.AutoSize = true;
            this.deviation_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.deviation_label.ForeColor = System.Drawing.Color.White;
            this.deviation_label.Location = new System.Drawing.Point(11, 286);
            this.deviation_label.Name = "deviation_label";
            this.deviation_label.Size = new System.Drawing.Size(156, 17);
            this.deviation_label.TabIndex = 141;
            this.deviation_label.Text = "Number of points per path";
            // 
            // noPoints_label
            // 
            this.noPoints_label.AutoSize = true;
            this.noPoints_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.noPoints_label.ForeColor = System.Drawing.Color.White;
            this.noPoints_label.Location = new System.Drawing.Point(14, 192);
            this.noPoints_label.Name = "noPoints_label";
            this.noPoints_label.Size = new System.Drawing.Size(156, 17);
            this.noPoints_label.TabIndex = 140;
            this.noPoints_label.Text = "Number of points per path";
            // 
            // noPath_label
            // 
            this.noPath_label.AutoSize = true;
            this.noPath_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.noPath_label.ForeColor = System.Drawing.Color.White;
            this.noPath_label.Location = new System.Drawing.Point(14, 98);
            this.noPath_label.Name = "noPath_label";
            this.noPath_label.Size = new System.Drawing.Size(102, 17);
            this.noPath_label.TabIndex = 139;
            this.noPath_label.Text = "Number of paths";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 138;
            this.label5.Text = "Constant drift μ";
            // 
            // mean_trackbar
            // 
            this.mean_trackbar.LargeChange = 1;
            this.mean_trackbar.Location = new System.Drawing.Point(14, 349);
            this.mean_trackbar.Maximum = 200;
            this.mean_trackbar.Name = "mean_trackbar";
            this.mean_trackbar.Size = new System.Drawing.Size(235, 45);
            this.mean_trackbar.TabIndex = 137;
            this.mean_trackbar.TickFrequency = 0;
            this.mean_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mean_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mean_trackbar_MouseUp);
            // 
            // deviation_trackbar
            // 
            this.deviation_trackbar.LargeChange = 1;
            this.deviation_trackbar.Location = new System.Drawing.Point(14, 254);
            this.deviation_trackbar.Maximum = 25;
            this.deviation_trackbar.Minimum = 1;
            this.deviation_trackbar.Name = "deviation_trackbar";
            this.deviation_trackbar.Size = new System.Drawing.Size(235, 45);
            this.deviation_trackbar.TabIndex = 136;
            this.deviation_trackbar.TickFrequency = 100;
            this.deviation_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.deviation_trackbar.Value = 1;
            this.deviation_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.deviation_trackbar_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 135;
            this.label3.Text = "Diffusion volatility σ";
            // 
            // draw_button
            // 
            this.draw_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.draw_button.BackColor = System.Drawing.Color.DarkGray;
            this.draw_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw_button.ForeColor = System.Drawing.Color.Black;
            this.draw_button.Location = new System.Drawing.Point(20, 633);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(136, 40);
            this.draw_button.TabIndex = 134;
            this.draw_button.Text = "Retry";
            this.draw_button.UseVisualStyleBackColor = false;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 133;
            this.label2.Text = "Period (discrete temporal units)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 132;
            this.label1.Text = "Number of simulations";
            // 
            // noPoints_trackbar
            // 
            this.noPoints_trackbar.LargeChange = 1;
            this.noPoints_trackbar.Location = new System.Drawing.Point(17, 164);
            this.noPoints_trackbar.Maximum = 1000;
            this.noPoints_trackbar.Minimum = 2;
            this.noPoints_trackbar.Name = "noPoints_trackbar";
            this.noPoints_trackbar.Size = new System.Drawing.Size(235, 45);
            this.noPoints_trackbar.TabIndex = 131;
            this.noPoints_trackbar.TickFrequency = 1000;
            this.noPoints_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.noPoints_trackbar.Value = 365;
            this.noPoints_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.noPoints_trackbar_MouseUp);
            // 
            // noPaths_trackbar
            // 
            this.noPaths_trackbar.LargeChange = 1;
            this.noPaths_trackbar.Location = new System.Drawing.Point(16, 66);
            this.noPaths_trackbar.Maximum = 500;
            this.noPaths_trackbar.Minimum = 1;
            this.noPaths_trackbar.Name = "noPaths_trackbar";
            this.noPaths_trackbar.Size = new System.Drawing.Size(235, 45);
            this.noPaths_trackbar.TabIndex = 130;
            this.noPaths_trackbar.Tag = "";
            this.noPaths_trackbar.TickFrequency = 1000;
            this.noPaths_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.noPaths_trackbar.Value = 10;
            this.noPaths_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.noPaths_trackbar_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.label4.Font = new System.Drawing.Font("Calibri Light", 30F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(257, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(844, 49);
            this.label4.TabIndex = 154;
            this.label4.Text = "SDE: dX(t)/X(t) = µ dt + σ dW(t) + dΣ(Log(0,1) - 1)";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(262, 609);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 155;
            this.label6.Text = "Inspecting time";
            // 
            // poisson_label
            // 
            this.poisson_label.AutoSize = true;
            this.poisson_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.poisson_label.ForeColor = System.Drawing.Color.White;
            this.poisson_label.Location = new System.Drawing.Point(15, 475);
            this.poisson_label.Name = "poisson_label";
            this.poisson_label.Size = new System.Drawing.Size(156, 17);
            this.poisson_label.TabIndex = 158;
            this.poisson_label.Text = "Number of points per path";
            // 
            // poisson_trackbar
            // 
            this.poisson_trackbar.LargeChange = 1;
            this.poisson_trackbar.Location = new System.Drawing.Point(18, 443);
            this.poisson_trackbar.Maximum = 20;
            this.poisson_trackbar.Minimum = 1;
            this.poisson_trackbar.Name = "poisson_trackbar";
            this.poisson_trackbar.Size = new System.Drawing.Size(235, 45);
            this.poisson_trackbar.TabIndex = 157;
            this.poisson_trackbar.TickFrequency = 100;
            this.poisson_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.poisson_trackbar.Value = 1;
            this.poisson_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.poisson_trackbar_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 156;
            this.label9.Text = "Poisson arrivals λ";
            // 
            // AFinal_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.poisson_label);
            this.Controls.Add(this.poisson_trackbar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startingPoint_label);
            this.Controls.Add(this.startingPoint_trackbar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.scale_checkBox);
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
            this.Name = "AFinal_Form";
            this.Text = "Option Prices in Merton\'s Jump Diffusion Model - Stochastic Process Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.startingPoint_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectingPoint_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mean_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviation_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPoints_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPaths_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisson_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingPoint_label;
        private System.Windows.Forms.TrackBar startingPoint_trackbar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox scale_checkBox;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label poisson_label;
        private System.Windows.Forms.TrackBar poisson_trackbar;
        private System.Windows.Forms.Label label9;
    }
}