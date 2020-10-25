namespace FastSpammer
{
    partial class SpamWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpamWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.mslabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.spamtimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(12, 378);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(121, 54);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.Enabled = false;
            this.stopbutton.Location = new System.Drawing.Point(139, 378);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(121, 54);
            this.stopbutton.TabIndex = 2;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(266, 378);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(121, 54);
            this.clearbutton.TabIndex = 3;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(393, 378);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(121, 54);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(56, 297);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(461, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 500;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delay:";
            // 
            // mslabel
            // 
            this.mslabel.AutoSize = true;
            this.mslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mslabel.Location = new System.Drawing.Point(256, 351);
            this.mslabel.Name = "mslabel";
            this.mslabel.Size = new System.Drawing.Size(61, 20);
            this.mslabel.TabIndex = 7;
            this.mslabel.Text = "500 ms";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(505, 279);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Type Text Here...";
            // 
            // spamtimer
            // 
            this.spamtimer.Interval = 500;
            this.spamtimer.Tick += new System.EventHandler(this.spamtimer_Tick);
            // 
            // SpamWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 444);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mslabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpamWindow";
            this.Text = "FastSpammer v1 - GitHub: wgex";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mslabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer spamtimer;
    }
}

