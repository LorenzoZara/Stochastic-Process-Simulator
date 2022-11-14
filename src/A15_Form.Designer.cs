namespace StochasticProcessSimulator
{
    partial class A15_Form
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
            this.m_label = new System.Windows.Forms.Label();
            this.n_label = new System.Windows.Forms.Label();
            this.timer_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sp_trackbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_trackbar = new System.Windows.Forms.TrackBar();
            this.start_button = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sp_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rv_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_label
            // 
            this.m_label.AutoSize = true;
            this.m_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.m_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.m_label.ForeColor = System.Drawing.Color.White;
            this.m_label.Location = new System.Drawing.Point(12, 176);
            this.m_label.Name = "m_label";
            this.m_label.Size = new System.Drawing.Size(42, 17);
            this.m_label.TabIndex = 21;
            this.m_label.Text = "label4";
            // 
            // n_label
            // 
            this.n_label.AutoSize = true;
            this.n_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.n_label.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.n_label.ForeColor = System.Drawing.Color.White;
            this.n_label.Location = new System.Drawing.Point(12, 76);
            this.n_label.Name = "n_label";
            this.n_label.Size = new System.Drawing.Size(42, 17);
            this.n_label.TabIndex = 20;
            this.n_label.Text = "label3";
            // 
            // timer_button
            // 
            this.timer_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timer_button.BackColor = System.Drawing.Color.DarkGray;
            this.timer_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_button.Location = new System.Drawing.Point(12, 457);
            this.timer_button.Name = "timer_button";
            this.timer_button.Size = new System.Drawing.Size(216, 31);
            this.timer_button.TabIndex = 19;
            this.timer_button.Text = "Start/Stop Timer";
            this.timer_button.UseVisualStyleBackColor = false;
            this.timer_button.Click += new System.EventHandler(this.timer_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.label2.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Number of sample means (m)";
            // 
            // sp_trackbar
            // 
            this.sp_trackbar.Location = new System.Drawing.Point(12, 148);
            this.sp_trackbar.Maximum = 25000;
            this.sp_trackbar.Minimum = 2;
            this.sp_trackbar.Name = "sp_trackbar";
            this.sp_trackbar.Size = new System.Drawing.Size(216, 45);
            this.sp_trackbar.TabIndex = 17;
            this.sp_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sp_trackbar.Value = 2;
            this.sp_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sp_trackbar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Number of random variables (n)";
            // 
            // rv_trackbar
            // 
            this.rv_trackbar.Location = new System.Drawing.Point(15, 48);
            this.rv_trackbar.Maximum = 2500;
            this.rv_trackbar.Minimum = 1;
            this.rv_trackbar.Name = "rv_trackbar";
            this.rv_trackbar.Size = new System.Drawing.Size(213, 45);
            this.rv_trackbar.TabIndex = 15;
            this.rv_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rv_trackbar.Value = 10;
            this.rv_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rv_trackbar_MouseUp);
            // 
            // start_button
            // 
            this.start_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.start_button.BackColor = System.Drawing.Color.DarkGray;
            this.start_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(12, 420);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(216, 31);
            this.start_button.TabIndex = 14;
            this.start_button.Text = "Draw";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.pictureBox.Location = new System.Drawing.Point(259, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(613, 350);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // A15_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.m_label);
            this.Controls.Add(this.n_label);
            this.Controls.Add(this.timer_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sp_trackbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rv_trackbar);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "A15_Form";
            this.Text = "Glivenko-Cantelli - Stochastic Process Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.sp_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rv_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_label;
        private System.Windows.Forms.Label n_label;
        private System.Windows.Forms.Button timer_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar sp_trackbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar rv_trackbar;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer;
    }
}