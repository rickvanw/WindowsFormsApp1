namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.exerciseName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exerciseRepetitions = new System.Windows.Forms.Label();
            this.exerciseVideoBrowser = new System.Windows.Forms.WebBrowser();
            this.exerciseDescriptionBrowser = new System.Windows.Forms.WebBrowser();
            this.exerciseImageBrowser = new System.Windows.Forms.WebBrowser();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonDislike = new System.Windows.Forms.Button();
            this.buttonLike = new System.Windows.Forms.Button();
            this.buttonNotDone = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "KomInBeweging";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // exerciseName
            // 
            this.exerciseName.AutoSize = true;
            this.exerciseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(163)))), ((int)(((byte)(231)))));
            this.exerciseName.Location = new System.Drawing.Point(60, 46);
            this.exerciseName.MaximumSize = new System.Drawing.Size(600, 67);
            this.exerciseName.Name = "exerciseName";
            this.exerciseName.Size = new System.Drawing.Size(205, 55);
            this.exerciseName.TabIndex = 2;
            this.exerciseName.Text = "Planken";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(163)))), ((int)(((byte)(231)))));
            this.label2.Location = new System.Drawing.Point(688, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Herhalingen";
            // 
            // exerciseRepetitions
            // 
            this.exerciseRepetitions.AutoSize = true;
            this.exerciseRepetitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseRepetitions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(163)))), ((int)(((byte)(231)))));
            this.exerciseRepetitions.Location = new System.Drawing.Point(744, 80);
            this.exerciseRepetitions.Name = "exerciseRepetitions";
            this.exerciseRepetitions.Size = new System.Drawing.Size(52, 55);
            this.exerciseRepetitions.TabIndex = 4;
            this.exerciseRepetitions.Text = "5";
            // 
            // exerciseVideoBrowser
            // 
            this.exerciseVideoBrowser.Location = new System.Drawing.Point(128, 392);
            this.exerciseVideoBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.exerciseVideoBrowser.Name = "exerciseVideoBrowser";
            this.exerciseVideoBrowser.Size = new System.Drawing.Size(620, 350);
            this.exerciseVideoBrowser.TabIndex = 6;
            // 
            // exerciseDescriptionBrowser
            // 
            this.exerciseDescriptionBrowser.AllowNavigation = false;
            this.exerciseDescriptionBrowser.AllowWebBrowserDrop = false;
            this.exerciseDescriptionBrowser.IsWebBrowserContextMenuEnabled = false;
            this.exerciseDescriptionBrowser.Location = new System.Drawing.Point(336, 162);
            this.exerciseDescriptionBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.exerciseDescriptionBrowser.Name = "exerciseDescriptionBrowser";
            this.exerciseDescriptionBrowser.Size = new System.Drawing.Size(414, 208);
            this.exerciseDescriptionBrowser.TabIndex = 7;
            // 
            // exerciseImageBrowser
            // 
            this.exerciseImageBrowser.AllowNavigation = false;
            this.exerciseImageBrowser.AllowWebBrowserDrop = false;
            this.exerciseImageBrowser.IsWebBrowserContextMenuEnabled = false;
            this.exerciseImageBrowser.Location = new System.Drawing.Point(66, 154);
            this.exerciseImageBrowser.Name = "exerciseImageBrowser";
            this.exerciseImageBrowser.ScrollBarsEnabled = false;
            this.exerciseImageBrowser.Size = new System.Drawing.Size(258, 208);
            this.exerciseImageBrowser.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.half_circle_right;
            this.pictureBox3.Location = new System.Drawing.Point(296, 768);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.half_circle_left;
            this.pictureBox2.Location = new System.Drawing.Point(536, 768);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 50);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // buttonDislike
            // 
            this.buttonDislike.BackColor = System.Drawing.Color.White;
            this.buttonDislike.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dislike1;
            this.buttonDislike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDislike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDislike.FlatAppearance.BorderSize = 0;
            this.buttonDislike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDislike.ForeColor = System.Drawing.Color.White;
            this.buttonDislike.Location = new System.Drawing.Point(488, 768);
            this.buttonDislike.Name = "buttonDislike";
            this.buttonDislike.Size = new System.Drawing.Size(50, 50);
            this.buttonDislike.TabIndex = 12;
            this.buttonDislike.UseVisualStyleBackColor = false;
            this.buttonDislike.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonLike
            // 
            this.buttonLike.BackColor = System.Drawing.Color.White;
            this.buttonLike.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.like1;
            this.buttonLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLike.FlatAppearance.BorderSize = 0;
            this.buttonLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLike.ForeColor = System.Drawing.Color.White;
            this.buttonLike.Location = new System.Drawing.Point(440, 768);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(50, 50);
            this.buttonLike.TabIndex = 11;
            this.buttonLike.UseVisualStyleBackColor = false;
            this.buttonLike.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonNotDone
            // 
            this.buttonNotDone.BackColor = System.Drawing.Color.White;
            this.buttonNotDone.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.close1;
            this.buttonNotDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNotDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNotDone.FlatAppearance.BorderSize = 0;
            this.buttonNotDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotDone.ForeColor = System.Drawing.Color.White;
            this.buttonNotDone.Location = new System.Drawing.Point(392, 768);
            this.buttonNotDone.Name = "buttonNotDone";
            this.buttonNotDone.Size = new System.Drawing.Size(50, 50);
            this.buttonNotDone.TabIndex = 10;
            this.buttonNotDone.UseVisualStyleBackColor = false;
            this.buttonNotDone.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.White;
            this.buttonDone.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.checkmark1;
            this.buttonDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Location = new System.Drawing.Point(344, 768);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(50, 50);
            this.buttonDone.TabIndex = 9;
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.exercise;
            this.pictureBox1.Location = new System.Drawing.Point(66, 162);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(250, 200);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 144);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(884, 848);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonDislike);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.buttonNotDone);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.exerciseImageBrowser);
            this.Controls.Add(this.exerciseDescriptionBrowser);
            this.Controls.Add(this.exerciseVideoBrowser);
            this.Controls.Add(this.exerciseRepetitions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exerciseName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exerciseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exerciseRepetitions;
        private System.Windows.Forms.WebBrowser exerciseVideoBrowser;
        private System.Windows.Forms.WebBrowser exerciseDescriptionBrowser;
        private System.Windows.Forms.WebBrowser exerciseImageBrowser;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonNotDone;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Button buttonDislike;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

