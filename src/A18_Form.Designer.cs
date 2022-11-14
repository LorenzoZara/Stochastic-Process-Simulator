namespace StochasticProcessSimulator
{
    partial class A18_Form
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.specting_label = new System.Windows.Forms.Label();
            this.spectingPoint_trackbar = new System.Windows.Forms.TrackBar();
            this.probability_label = new System.Windows.Forms.Label();
            this.noPoints_label = new System.Windows.Forms.Label();
            this.noPath_label = new System.Windows.Forms.Label();
            this.probability_trackbar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.draw_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.noPoints_trackbar = new System.Windows.Forms.TrackBar();
            this.noPaths_trackbar = new System.Windows.Forms.TrackBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spectingPoint_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probability_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPoints_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPaths_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(12, 589);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "INDIVIDUAL DISTANCES DISTRIBUTION";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(12, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "CONSECUTIVE DISTANCES DISTRIBUTION";
            // 
            // specting_label
            // 
            this.specting_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.specting_label.AutoSize = true;
            this.specting_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.specting_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.specting_label.ForeColor = System.Drawing.Color.White;
            this.specting_label.Location = new System.Drawing.Point(431, 616);
            this.specting_label.Name = "specting_label";
            this.specting_label.Size = new System.Drawing.Size(34, 17);
            this.specting_label.TabIndex = 52;
            this.specting_label.Text = "Spec";
            // 
            // spectingPoint_trackbar
            // 
            this.spectingPoint_trackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spectingPoint_trackbar.Location = new System.Drawing.Point(334, 636);
            this.spectingPoint_trackbar.Maximum = 520;
            this.spectingPoint_trackbar.Minimum = 1;
            this.spectingPoint_trackbar.Name = "spectingPoint_trackbar";
            this.spectingPoint_trackbar.Size = new System.Drawing.Size(861, 45);
            this.spectingPoint_trackbar.TabIndex = 50;
            this.spectingPoint_trackbar.TickFrequency = 100;
            this.spectingPoint_trackbar.Value = 260;
            this.spectingPoint_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spectingPoint_trackbar_MouseUp);
            // 
            // probability_label
            // 
            this.probability_label.AutoSize = true;
            this.probability_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.probability_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.probability_label.ForeColor = System.Drawing.Color.White;
            this.probability_label.Location = new System.Drawing.Point(23, 314);
            this.probability_label.Name = "probability_label";
            this.probability_label.Size = new System.Drawing.Size(156, 17);
            this.probability_label.TabIndex = 47;
            this.probability_label.Text = "Number of points per path";
            // 
            // noPoints_label
            // 
            this.noPoints_label.AutoSize = true;
            this.noPoints_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.noPoints_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.noPoints_label.ForeColor = System.Drawing.Color.White;
            this.noPoints_label.Location = new System.Drawing.Point(24, 209);
            this.noPoints_label.Name = "noPoints_label";
            this.noPoints_label.Size = new System.Drawing.Size(156, 17);
            this.noPoints_label.TabIndex = 46;
            this.noPoints_label.Text = "Number of points per path";
            // 
            // noPath_label
            // 
            this.noPath_label.AutoSize = true;
            this.noPath_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.noPath_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.noPath_label.ForeColor = System.Drawing.Color.White;
            this.noPath_label.Location = new System.Drawing.Point(26, 104);
            this.noPath_label.Name = "noPath_label";
            this.noPath_label.Size = new System.Drawing.Size(102, 17);
            this.noPath_label.TabIndex = 45;
            this.noPath_label.Text = "Number of paths";
            // 
            // probability_trackbar
            // 
            this.probability_trackbar.Location = new System.Drawing.Point(26, 285);
            this.probability_trackbar.Maximum = 100;
            this.probability_trackbar.Minimum = 1;
            this.probability_trackbar.Name = "probability_trackbar";
            this.probability_trackbar.Size = new System.Drawing.Size(279, 45);
            this.probability_trackbar.TabIndex = 42;
            this.probability_trackbar.TickFrequency = 100;
            this.probability_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.probability_trackbar.Value = 50;
            this.probability_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.probability_trackbar_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.label3.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Parameter λ ( p = λ / n )";
            // 
            // draw_button
            // 
            this.draw_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.draw_button.BackColor = System.Drawing.Color.DarkGray;
            this.draw_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw_button.ForeColor = System.Drawing.Color.Black;
            this.draw_button.Location = new System.Drawing.Point(26, 642);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(127, 45);
            this.draw_button.TabIndex = 40;
            this.draw_button.Text = "Retry";
            this.draw_button.UseVisualStyleBackColor = false;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.label2.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Number of points per path (n)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Number of paths (m)";
            // 
            // noPoints_trackbar
            // 
            this.noPoints_trackbar.Location = new System.Drawing.Point(26, 181);
            this.noPoints_trackbar.Maximum = 1000;
            this.noPoints_trackbar.Minimum = 20;
            this.noPoints_trackbar.Name = "noPoints_trackbar";
            this.noPoints_trackbar.Size = new System.Drawing.Size(279, 45);
            this.noPoints_trackbar.TabIndex = 37;
            this.noPoints_trackbar.TickFrequency = 1000;
            this.noPoints_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.noPoints_trackbar.Value = 520;
            this.noPoints_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.noPoints_trackbar_MouseUp);
            // 
            // noPaths_trackbar
            // 
            this.noPaths_trackbar.Location = new System.Drawing.Point(26, 75);
            this.noPaths_trackbar.Maximum = 1000;
            this.noPaths_trackbar.Minimum = 1;
            this.noPaths_trackbar.Name = "noPaths_trackbar";
            this.noPaths_trackbar.Size = new System.Drawing.Size(279, 45);
            this.noPaths_trackbar.TabIndex = 36;
            this.noPaths_trackbar.Tag = "";
            this.noPaths_trackbar.TickFrequency = 1000;
            this.noPaths_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.noPaths_trackbar.Value = 1000;
            this.noPaths_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.noPaths_trackbar_MouseUp);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.pictureBox.Location = new System.Drawing.Point(334, 75);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(413, 507);
            this.pictureBox.TabIndex = 49;
            this.pictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.label4.Font = new System.Drawing.Font("Calibri Light", 30F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(325, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 49);
            this.label4.TabIndex = 55;
            this.label4.Text = "y(t) = y(t-1) + B(1, λ/n)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.label5.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(331, 616);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Inspecting time";
            // 
            // A18_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.specting_label);
            this.Controls.Add(this.spectingPoint_trackbar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.probability_label);
            this.Controls.Add(this.noPoints_label);
            this.Controls.Add(this.noPath_label);
            this.Controls.Add(this.probability_trackbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.draw_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noPoints_trackbar);
            this.Controls.Add(this.noPaths_trackbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "A18_Form";
            this.Text = "Bernoulli\'s Random Walk - Stochastic Process Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.spectingPoint_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probability_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPoints_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPaths_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label specting_label;
        private System.Windows.Forms.TrackBar spectingPoint_trackbar;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label probability_label;
        private System.Windows.Forms.Label noPoints_label;
        private System.Windows.Forms.Label noPath_label;
        private System.Windows.Forms.TrackBar probability_trackbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar noPoints_trackbar;
        private System.Windows.Forms.TrackBar noPaths_trackbar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}